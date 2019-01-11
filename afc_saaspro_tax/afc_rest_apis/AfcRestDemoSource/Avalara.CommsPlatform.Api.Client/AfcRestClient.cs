using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using Avalara.CommsPlatform.Api.Models;

namespace Avalara.CommsPlatform.Api.Client
{
    /// <summary>
    /// Client class used for making API calls to the AFC REST service.
    /// </summary>
    public class AfcRestClient : IDisposable
    {
        private HttpClient client;
        private readonly JsonSerializerSettings jsonSettings = 
            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        /// <summary>
        /// Username for AFC REST service.
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Client ID.
        /// </summary>
        public int? ClientID { get; private set; } = null;

        /// <summary>
        /// Profile ID.
        /// </summary>
        public int? ProfileID { get; private set; } = null;

        public TimeSpan Timeout
        {
            get { return client.Timeout; }
            set { client.Timeout = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="baseAddress">URL for Comms Platform.</param>
        /// <param name="userName">User name for Comms Platform authentication.</param>
        /// <param name="password">Password for Comms Platform authentication.</param>
        /// <param name="clientID">Comms Platform client ID.</param>
        /// <param name="profileId">Comms Platform client profile ID.</param>
        public AfcRestClient(string baseAddress, string userName, string password, int? clientID = null, 
            int? profileId = null): base()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.Timeout = new TimeSpan(0, 20, 0);

            UserName = userName;
            ClientID = clientID;
            ProfileID = profileId;

            string token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{userName}:{password}"));

            client.DefaultRequestHeaders.Add("api_key", token);

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);

            // client_id header is required if user has access to more than one client in Comms Platform
            if (ClientID.HasValue)
                client.DefaultRequestHeaders.Add("client_id", ClientID.ToString());

            // client_profile_id header is required if using a customized profile
            if (ProfileID.HasValue)
                client.DefaultRequestHeaders.Add("client_profile_id", ProfileID.ToString());
        }

        #region Geocoding APIs

        /// <summary>
        /// Geocodes one or multiple address or latitude/longitude coordinates.
        /// </summary>
        /// <param name="geoRequests">List of address or latitude/longitude information to geocode.</param>
        /// <returns>Geocode results.</returns>
        public async Task<IEnumerable<GeocodeResult>> Geocode(IEnumerable<GeocodeRequest> geoRequests)
        {
            return await PostAsJsonAsync<IEnumerable<GeocodeResult>>("api/v2/geo/Geocode", geoRequests);
        }

        #endregion

        #region Tax Calculation APIs

        /// <summary>
        /// Performs tax calculations on one or multiple invoices and returns the taxes generated.
        /// </summary>
        /// <param name="calcTaxesRequest">Object containing invoice data to be processed for tax calculations.</param>
        /// <returns>Object containing tax calculation results.</returns>
        public async Task<CalcTaxesResponse> CalcTaxes(CalcTaxesRequest calcTaxesRequest)
        {
            return await PostAsJsonAsync<CalcTaxesResponse>("api/v2/afc/CalcTaxes", calcTaxesRequest);
        }

        /// <summary>
        /// Commits or un-commits a document code and all related transactions.
        /// </summary>
        /// <param name="commitRequest">Object containing document code to update.</param>
        /// <returns>Object containing status of request.</returns>
        public async Task<CommitResponse> Commit(CommitRequest commitRequest)
        {
            return await PostAsJsonAsync<CommitResponse>("api/v2/afc/Commit", commitRequest);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Submits a POST request to the specified URI within the Base Address
        /// </summary>
        /// <param name="requestUri">URI for POST request.</param>
        /// <param name="data">Data to serialize as JSON in the request body.</param>
        /// <returns></returns>
        public async Task<T> PostAsJsonAsync<T>(string requestUri, object data)
        {
            var json = JsonConvert.SerializeObject(data, jsonSettings);
            HttpResponseMessage response =
                await client.PostAsync(requestUri, new StringContent(json, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains("error") ?
                    string.Join(". ", response.Headers.GetValues("error")) : null;

                throw new AfcRestException(response.StatusCode, error);
            }

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        /// <summary>
        /// Submits a GET request to the specified URI within the Base Address
        /// </summary>
        /// <param name="requestUri">URI for GET request.</param>
        /// <returns></returns>
        public async Task<string> GetAsync(string requestUri)
        {
            HttpResponseMessage response = client.GetAsync(requestUri).Result;

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains("error") ?
                    string.Join(". ", response.Headers.GetValues("error")) : null;

                throw new AfcRestException(response.StatusCode, error);
            }

            return await response.Content.ReadAsStringAsync();
        }

        #endregion

        #region IDisposable Implementation

        /// <summary>
        /// Dispose underlying resources.
        /// </summary>
        public void Dispose()
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }
        }

        #endregion
    }
}
