using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Avalara.Comms.Rest.Sample.Model;
using System.Text;

namespace Avalara.Comms.Rest.Sample.Client
{
    /// <summary>
    /// Client for AFC REST service. NOTE: Only APIs shown in this sample are implemented.
    /// </summary>
    public class AfcRestClient: IDisposable
    {
        private const string AuthHeader = "Basic";
        private const string ErrorHeader = "error";
        private const char ForwardSlash = '/';
        private HttpClient httpClient;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="baseAddress">AFC REST service base address.</param>
        /// <param name="userName">User name for authentication.</param>
        /// <param name="password">Password for authentication.</param>
        /// <param name="clientId">Client Id</param>
        /// <param name="clientProfileId">Client Profile Id.</param>
        public AfcRestClient(string baseAddress, string userName, string password, int clientId, int clientProfileId)
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseAddress.TrimEnd(ForwardSlash));
            httpClient.DefaultRequestHeaders.Accept.Clear();
            
            string token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format($"{userName}:{password}")));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthHeader, token);
            httpClient.DefaultRequestHeaders.Add("client_id", clientId.ToString());
            httpClient.DefaultRequestHeaders.Add("client_profile_id", clientProfileId.ToString());
        }

        /// <summary>
        /// Get server time
        /// </summary>
        /// <remarks>Returns the server time converted to local date/time.</remarks>
        /// <returns>Server time converted to local DateTime.</returns>
        public async Task<DateTime> GetServerTime()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"api/v1/Application/ServerTime");

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DateTime>(content);
        }
        
        /// <summary>
        /// Determine PCode for a location
        /// </summary>
        /// <remarks>Converts the given request data to a PCode. 
        /// Only one of the fields should be used for the conversion: ZipAddress, FipsCode or NPANXX.</remarks>
        /// <param name="request">Object containing ZipAddress, FipsCode or NPANXX to be converted.</param>
        /// <returns>PCode for specified ZipAddress, FipsCode or NPANXX.</returns>
        public async Task<uint> GetPCode(RequestPCodeDetail request)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync($"api/v1/Location/PCode", request);
            
            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string content = await response.Content.ReadAsStringAsync();
            return Convert.ToUInt32(content);
        }
        
        /// <summary>
        /// Calculate taxes on a transaction
        /// </summary>
        /// <remarks>Accepts transaction data and performs appropriate tax calculations.</remarks>
        /// <param name="transaction">Transaction data.</param>
        /// <returns>An array of TaxData objects that contain the information about the taxes applied.</returns>
        public async Task<TaxData[]> CalculateTaxes(Transaction transaction)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync($"api/v1/CalculateTaxes", transaction);

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TaxData[]>(responseContent);
        }

        /// <summary>
        /// Calculate tax adjustments on transaction
        /// </summary>
        /// <remarks>This method accepts transaction data and performs appropriate tax adjustment calculations.</remarks>
        /// <param name="transaction">Transaction data.</param>
        /// <returns>An array of TaxData objects that contain the information about the taxes applied.</returns>
        public async Task<TaxData[]> CalculateAdjustments(Transaction transaction)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync($"api/v1/CalculateAdjustments", transaction);

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TaxData[]>(content);
        }
        
        /// <summary>
        /// Get address information for a jurisdiction
        /// </summary>
        /// <remarks>This method returns a list of addresses for the specified jurisdiction.</remarks>
        /// <param name="pcode">PCode for jurisdiction.</param>
        /// <returns>List of addresses for jurisdiction.</returns>
        public async Task<AddressData[]> GetAddress(uint pcode)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"api/v1/Location/Address/{pcode}");

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AddressData[]>(content);
        }
        
        /// <summary>
        /// Calculate taxes on a bridge conference transaction
        /// </summary>
        /// <remarks>This method will take a Billing address, Bridge Address, Host Address (optional) and list of participants.
        /// The system will determine which taxes apply for each participant and return the summarized taxes for the bridge 
        /// conference transaction. The individual participant results are returned if ReturnParticipantResults is true.</remarks>
        /// <param name="transaction">Bridge conference transaction details including list of participants.</param>
        /// <returns>BridgeConferenceResults object containing an array of BridgeConferenceParticipantResult objects for each 
        /// participant transaction processed and TaxData array containing the summarized taxes for the bridge conference calculation.</returns>
        public async Task<BridgeConferenceResults> CalculateBridgeConferenceTaxes(BridgeConferenceTransaction transaction)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync($"api/v1/BridgeConference/Taxes", transaction);

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BridgeConferenceResults>(content);
        }
        
        /// <summary>
        /// Calculate taxes using overrides
        /// </summary>
        /// <remarks>Accepts transaction and tax rate override data to perform tax calculations with the provided 
        /// override information.</remarks>
        /// <param name="request">Transaction data to be processed and tax rate override list.</param>
        /// <returns>An array of TaxData objects that contain the information about the taxes applied.</returns>
        public async Task<TaxData[]> CalculateTaxesWithOverrides(CalculateWithOverridesRequest request)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync($"api/v1/CalculateWithOverrides/Taxes", request);

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains(ErrorHeader) ?
                    response.Headers.GetValues(ErrorHeader).FirstOrDefault() :
                    null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TaxData[]>(content);
        }

        /// <summary>
        /// Release any resources from the underlying HttpClient.
        /// </summary>
        public void Dispose()
        {
            if (httpClient != null)
            {
                httpClient.Dispose();
                httpClient = null;
            }
        }
    }
}