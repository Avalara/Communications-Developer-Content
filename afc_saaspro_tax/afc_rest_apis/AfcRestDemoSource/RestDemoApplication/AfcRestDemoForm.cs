using Avalara.CommsPlatform.Api.Client;
using Avalara.CommsPlatform.Api.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalara.CommsPlatform.Api.RestDemoApplication
{
    /// <summary>
    /// Avalara for Communications REST demo application form.
    /// </summary>
    public partial class AfcRestDemoForm : Form
    {
        #region Initialization

        private Telerik.WinControls.UI.LineSeries lineSeries;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private CalcTaxesRequest performanceTestRequest;
        private ConcurrentQueue<int> responseStats;
        private SortedSet<int> sortedResponseStats = new SortedSet<int>();
        private DateTime startTime = DateTime.MinValue;
        private int lastChartMinute;
        private int requestCount = 0;
        private int lastRequestCount = 0;
        private int failedRequests = 0;
        private int taxesReturned = 0;
        private int maxThreads;
        private int maxMinutes;

        /// <summary>
        /// Constructor.
        /// </summary>
        public AfcRestDemoForm()
        {
            // Initialize controls
            InitializeComponent();
            maxTimeComboBox.Text = "10";
            maxThreadsComboBox.Text = "5";
            usernameTextBox.Text = ConfigurationManager.AppSettings["DefaultUsername"];
            passwordTextBox.Text = ConfigurationManager.AppSettings["DefaultPassword"];
            clientIDTextBox.Text = ConfigurationManager.AppSettings["DefaultClientID"];
            profileIDTextBox.Text = ConfigurationManager.AppSettings["DefaultProfileID"];
            urlStatusLabel.Text = $"URL: {ConfigurationManager.AppSettings["AfcRestApiUrl"]}";
            versionStatusLabel.Text = string.Empty;
            
            // Initialize line series for chart
            lineSeries = new Telerik.WinControls.UI.LineSeries();
            chart.ShowLegend = false;
            lineSeries.BorderColor = Color.Orange;
            chart.Series.Add(lineSeries);
            chart.Area.Axes[0].Title = "Time Elapsed (minutes)";
            chart.Area.Axes[1].Title = "Requests Per Minute";

            // Set default sample request
            CalcTaxesRequest request = CreateDefaultRequest();
            string requestBody = Newtonsoft.Json.JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.Indented);
            requestTextBox.Text = requestBody;
        }

        #endregion

        #region Sample Request Processing

        /// <summary>
        /// De-serializes the request body entered into the sample request text box.
        /// </summary>
        /// <returns>CalcTaxesRequest object</returns>
        private CalcTaxesRequest GetSampleRequest()
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<CalcTaxesRequest>(requestTextBox.Text);
            }
            catch
            {
                MessageBox.Show(this, "The request body is invalid. Please check the request format and fields.", 
                    "Invalid Request Body", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /// <summary>
        /// Invokes the Avalara for Communications REST API to process the sample request.
        /// </summary>
        private async Task ProcessSampleRequest()
        {
            // Get client for invoking Avalara for Communications REST API
            AfcRestClient client = await GetAfcRestClient();

            if (client == null)
            {
                return;
            }

            // Get request from input
            CalcTaxesRequest request = GetSampleRequest();

            if (request == null)
            {
                return;
            }

            try
            {
                CalcTaxesResponse response = await client.CalcTaxes(request);
                responseTextBox.Text = Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            }
            catch (AggregateException ex)
            {
                MessageBox.Show(this, ex.InnerException?.Message ?? ex.Message, "Error Processing Sample Request", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error Processing Sample Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                client.Dispose();
            }
        }

        #endregion

        #region Performance Testing

        /// <summary>
        /// Begins running the performance test for the Avalara for Communications REST service.
        /// </summary>
        private async Task StartPerformanceTest()
        {
            ClearPerformanceStats();

            // Get client for invoking Avalara for Communications REST API
            AfcRestClient afcClient = await GetAfcRestClient();

            if (afcClient == null)
            {
                EndPerformanceTest(false);
                return;
            }

            // Get request from input
            performanceTestRequest = GetSampleRequest();

            if (performanceTestRequest == null)
            {
                EndPerformanceTest(false);
                return;
            }

            try
            {
                // Process request once to validate request body
                await afcClient.CalcTaxes(performanceTestRequest);
                
                maxThreads = int.Parse(maxThreadsComboBox.Text);
                maxMinutes = int.Parse(maxTimeComboBox.Text);

                // Create tasks for the specified number of threads
                var tasks = new List<Task>();

                for (int threadCount = 0; threadCount < maxThreads; threadCount++)
                {
                    tasks.Add(new Task(async () =>
                    {
                        AfcRestClient client = afcClient;
                        Stopwatch stopwatch = new Stopwatch();

                        try
                        {
                            while (!cancellationToken.IsCancellationRequested)
                            {
                                stopwatch.Restart();
                                var response = await client.CalcTaxes(performanceTestRequest);
                                stopwatch.Stop();
                                responseStats.Enqueue((int)stopwatch.ElapsedMilliseconds);
                                int taxCount = response.InvoiceResults?.Sum(inv => inv.ItemResults?.Sum(item => item.Taxes?.Count() ?? 0) ?? 0) ?? 0;
                                Interlocked.Increment(ref requestCount);
                                Interlocked.Add(ref taxesReturned, taxCount);
                            }
                        }
                        catch
                        {
                            Interlocked.Increment(ref failedRequests);
                        }
                    }));
                }

                // Begin making calls to Avalara for Communications REST API
                startTime = DateTime.UtcNow;
                tasks.ForEach(t => t.Start());
            }
            catch
            {
                afcClient.Dispose();
            }
        }

        /// <summary>
        /// End performance test processing.
        /// </summary>
        private void EndPerformanceTest(bool updateStats = true)
        {
            timer.Enabled = false;
            cancellationTokenSource.Cancel();
            abortButton.Enabled = false;
            startButton.Enabled = true;
            maxThreadsComboBox.Enabled = true;
            maxTimeComboBox.Enabled = true;

            if (updateStats)
            {
                UpdatePerformanceStats();
            }
        }

        /// <summary>
        /// Clears the performance stats displayed in the UI.
        /// </summary>
        private void ClearPerformanceStats()
        {
            requestCount = 0;
            failedRequests = 0;
            taxesReturned = 0;
            lastChartMinute = 0;
            responseStats = new ConcurrentQueue<int>();
            startTime = DateTime.MinValue;
            lineSeries.DataPoints.Clear();
            sortedResponseStats.Clear();
            timeElapsedTextBox.Clear();
            requestCountTextBox.Clear();
            invoiceCountTextBox.Clear();
            lineItemCountTextBox.Clear();
            taxCountTextBox.Clear();
            averageTimeTextBox.Clear();
            averageResponseTextBox.Clear();
            slowestResponseTextBox.Clear();
            percentile25TextBox.Clear();
            medianTextBox.Clear();
            percentile75TextBox.Clear();
            fastestTextBox.Clear();
        }

        /// <summary>
        /// Updates the performance stats text displayed in the UI.
        /// </summary>
        private void UpdatePerformanceStats(bool complete = false)
        {
            if (startTime == DateTime.MinValue)
            {
                return;
            }

            // Set processing stats
            TimeSpan timeElapsed = DateTime.UtcNow - startTime;
            int invoiceCount = (performanceTestRequest.Invoices?.Count() ?? 0) * requestCount;
            int itemCount = (performanceTestRequest.Invoices?.Sum(inv => inv.Items?.Count() ?? 0) ?? 0) * requestCount;
            int avgItemsPerMin = itemCount == 0 ? 0 : (int)((itemCount / timeElapsed.TotalMilliseconds) * 60000);

            timeElapsedTextBox.Text = timeElapsed.ToString(@"hh\:mm\:ss");
            requestCountTextBox.Text = $"{requestCount}";
            invoiceCountTextBox.Text = $"{invoiceCount}";
            lineItemCountTextBox.Text = $"{itemCount}";
            taxCountTextBox.Text = $"{taxesReturned}";
            averageTimeTextBox.Text =  $"{avgItemsPerMin}";

            // Move response stats from queue to sorted list for response time stats
            int responseTime;
            while (responseStats.TryDequeue(out responseTime))
            {
                sortedResponseStats.Add(responseTime);
            }

            // Set response times
            if (sortedResponseStats.Count > 0)
            {
                int totalResponseTime = sortedResponseStats.Sum();
                int p75Index = sortedResponseStats.Count / 4;
                int medianIndex = p75Index * 2;
                int p25Index = p75Index * 3;

                averageResponseTextBox.Text = $"{totalResponseTime / sortedResponseStats.Count}";
                slowestResponseTextBox.Text = $"{sortedResponseStats.Last()}";
                percentile25TextBox.Text = $"{sortedResponseStats.ElementAt(p25Index)}";
                medianTextBox.Text = $"{sortedResponseStats.ElementAt(medianIndex)}";
                percentile75TextBox.Text = $"{sortedResponseStats.ElementAt(p75Index)}";
                fastestTextBox.Text = $"{sortedResponseStats.First()}";
            }

            // Update chart every 1 minute
            if (complete || (int)timeElapsed.TotalMinutes > lastChartMinute)
            {
                if (lineSeries.DataPoints.Count == 0)
                {
                    lineSeries.DataPoints.Add(new Telerik.Charting.CategoricalDataPoint(0, "0"));
                }

                // Determine the number of requests that were processed the last minute
                int currentRequestCount = requestCount - lastRequestCount;
                lastRequestCount = requestCount;
                lastChartMinute = complete ? maxMinutes : (int)timeElapsed.TotalMinutes;
                lineSeries.DataPoints.Add(new Telerik.Charting.CategoricalDataPoint(currentRequestCount, lastChartMinute.ToString()));
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates a CalcTaxesRequest object with default values.
        /// </summary>
        /// <returns>CalcTaxesRequest object.</returns>
        private CalcTaxesRequest CreateDefaultRequest()
        {
            return new CalcTaxesRequest()
            {
                CompanyData = new CompanyData
                {
                    BusinessClass = (short)BusinessClass.ILEC,
                    Facilities = false,
                    Franchise = false,
                    Regulated = false,
                    ServiceClass = (short)ServiceClass.PrimaryLongDistance
                },
                Invoices = new[]
                {
                    new Invoice
                    {
                        BillTo = new Location
                        {
                            Country = "USA",
                            State = "WA",
                            City = "Seattle",
                            PostalCode = "98101"
                        },
                        Commit = false,
                        CustomerType = (short)CustomerType.Business,
                        Date = DateTime.UtcNow,
                        DocumentCode = "Invoice 1",
                        InvoiceMode = true,
                        Items = new []
                        {
                            new LineItem
                            {
                                Charge = 125.55,
                                LineNumber = "Line Item 1",
                                SaleType = (short)SaleType.Retail,
                                ServiceType = 6,        // Access Charge
                                TaxInclusive = false,
                                TransactionType = 19    // VoIP
                            },
                            new LineItem
                            {
                                Charge = 55.55,
                                LineNumber = "Line Item 2",
                                Lines = 2,
                                SaleType = (short)SaleType.Retail,
                                ServiceType = 21,       // Lines
                                TaxInclusive = false,
                                TransactionType = 19    // VoIP
                            }
                        }
                    },
                    new Invoice
                    {
                        BillTo = new Location
                        {
                            Country = "USA",
                            State = "NC",
                            City = "Durham",
                            PostalCode = "27701"
                        },
                        Commit = false,
                        CustomerType = (short)CustomerType.Business,
                        Date = DateTime.UtcNow,
                        DocumentCode = "Invoice 2",
                        InvoiceMode = true,
                        Items = new []
                        {
                            new LineItem
                            {
                                Charge = 125.55,
                                LineNumber = "Line Item 1",
                                SaleType = (short)SaleType.Retail,
                                ServiceType = 6,        // Access Charge
                                TaxInclusive = false,
                                TransactionType = 19    // VoIP
                            },
                            new LineItem
                            {
                                Charge = 55.55,
                                LineNumber = "Line Item 2",
                                Lines = 2,
                                SaleType = (short)SaleType.Retail,
                                ServiceType = 21,       // Lines
                                TaxInclusive = false,
                                TransactionType = 19    // VoIP
                            }
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Validates the credentials and retuns an instance of the AfcRestClient for invoking the REST API.
        /// </summary>
        /// <returns>AfcRestClient object or null if credentials are invalid.</returns>
        private async Task<AfcRestClient> GetAfcRestClient()
        {
            string error = string.Empty;

            if (string.IsNullOrWhiteSpace(urlStatusLabel.Text))
            {
                MessageBox.Show(this, "Enter the URL for the AFC REST API in the RestDemoApplication.exe.config file.",
                    "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show(this, "Please enter username.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show(this, "Please enter password.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                int? clientID = string.IsNullOrEmpty(clientIDTextBox.Text) ? null : (int?)int.Parse(clientIDTextBox.Text);
                int? profileID = string.IsNullOrEmpty(profileIDTextBox.Text) ? null : (int?)int.Parse(profileIDTextBox.Text);

                // Invoke API to get validate credentials and return the Comms Platform version
                var client = new AfcRestClient(ConfigurationManager.AppSettings["AfcRestApiUrl"], usernameTextBox.Text,
                    passwordTextBox.Text, clientID, profileID);
                string version = await client.GetAsync($"api/v1/Application/RESTVersion");
                versionStatusLabel.Text = $"Comms Platform Version: {version}";

                return client;
            }
            catch (AggregateException ex)
            {
                MessageBox.Show(this, ex.InnerException?.Message ?? ex.Message, "Authentication Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Process button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void processButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            processButton.Enabled = false;
            await ProcessSampleRequest();
            processButton.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Start button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void startButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            startButton.Enabled = false;
            maxThreadsComboBox.Enabled = false;
            maxTimeComboBox.Enabled = false;
            timer.Enabled = true;
            abortButton.Enabled = true;
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            try
            {
                await StartPerformanceTest();
            }
            catch (AggregateException ex)
            {
                MessageBox.Show(this, ex.InnerException?.Message ?? ex.Message, "Performance Test Error.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Performance Test Error.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Abort button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abortButton_Click(object sender, EventArgs e)
        {
            EndPerformanceTest();
            MessageBox.Show(this, "The performance test has been aborted.", "Performance Test Aborted.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Timer event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (startTime != DateTime.MinValue && (DateTime.UtcNow - startTime).TotalMinutes >= maxMinutes)
            {
                EndPerformanceTest(false);
                UpdatePerformanceStats(true);

                if (failedRequests > 0)
                {
                    MessageBox.Show(this, $"The performance test has completed with {failedRequests} failed requests.", 
                        "Performance Test Completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "The performance test has completed successfully.", "Performance Test Completed.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                UpdatePerformanceStats();
            }
        }

        /// <summary>
        /// Ensure only numeric characters can be entered in a text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void integerTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
