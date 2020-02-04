using System;
using System.Collections.Generic;
using System.Net.Http;
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
        private HttpClient _client;
        private readonly JsonSerializerSettings _jsonSettings =
            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        /// <summary>
        /// Username for AFC REST service.
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Client ID.
        /// </summary>
        public int? ClientId { get; }

        /// <summary>
        /// Profile ID.
        /// </summary>
        public int? ProfileId { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="baseAddress">URL for Comms Platform.</param>
        /// <param name="userName">User name for Comms Platform authentication.</param>
        /// <param name="password">Password for Comms Platform authentication.</param>
        /// <param name="clientId">Comms Platform client ID.</param>
        /// <param name="profileId">Comms Platform client profile ID.</param>
        public AfcRestClient(string baseAddress, string userName, string password, int? clientId = null, 
            int? profileId = null)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress),
                Timeout = new TimeSpan(0, 20, 0)
            };

            _client.DefaultRequestHeaders.Accept.Clear();

            UserName = userName;
            ClientId = clientId;
            ProfileId = profileId;

            string token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{userName}:{password}"));
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", token);

            // client_id header is required if user has access to more than one client in Comms Platform
            if (ClientId.HasValue)
            {
                _client.DefaultRequestHeaders.Add("client_id", ClientId.ToString());
            }

            // client_profile_id header is required if using a customized profile
            if (ProfileId.HasValue)
            {
                _client.DefaultRequestHeaders.Add("client_profile_id", ProfileId.ToString());
            }
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


        /// <summary>
        /// Submits Geo Batch file to v2 REST API
        /// </summary>
        /// <param name="buffer">Byte Array of uploaded .csv file</param>
        /// <returns>Geocode results.</returns>
        public async Task<GeoBatchSubmitFileResponse> GeoBatchUpload(byte[] buffer, string fileName)
        {
            return await PostAsFormDataAsync("api/v2/geo/batch/Upload", buffer, fileName);
        }

        /// <summary>
        /// Retrieves Geo Batch File Status info
        /// </summary>
        /// <param name="processId">Submitted ProcessId</param>
        /// <returns>Geocode results.</returns>
        public async Task<GeoBatchStatus> GetGeoBatchStatus(string processId)
        {
            return await GetGeoBatchStatusAsync("api/v2/geo/batch/Status/" + processId);
        }

        /// <summary>
        /// Retrieves Geo Batch File Log info
        /// </summary>
        /// <param name="processId">Submitted ProcessId</param>
        /// <returns>Geocode results.</returns>
        public async Task<GeoBatchLog> GetGeoBatchLog(string processId)
        {
            return await GetGeoBatchLogAsync("api/v2/geo/batch/Log/" + processId);
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
            var json = JsonConvert.SerializeObject(data, _jsonSettings);
            HttpResponseMessage response =
                await _client.PostAsync(requestUri, new StringContent(json, Encoding.UTF8, "application/json"));

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
        /// Submits a POST request to the specified URI within the Base Address using form data
        /// </summary>
        /// <param name="requestUri">URI for POST request.</param>
        /// <param name="data">Byte Array of submitted .csv file</param>
        /// <param name="fileName">Name of file uploaded</param>
        /// <returns></returns>
        public async Task<GeoBatchSubmitFileResponse> PostAsFormDataAsync(string requestUri, byte[] data, string fileName)
        {
            var httpResponse = new GeoBatchSubmitFileResponse();
            var form = new MultipartFormDataContent
            {
                { new ByteArrayContent(data, 0, data.Length), "GeoBatchFile", fileName }
            };
            HttpResponseMessage response =
                await _client.PostAsync(requestUri, form);

            if (!response.IsSuccessStatusCode)
            {
                string error = response.Headers.Contains("error") ?
                    string.Join(". ", response.Headers.GetValues("error")) : null;

                throw new AfcRestException(response.StatusCode, error);
            }

            var processIdResponse = JsonConvert.DeserializeObject<GeoBatchSubmitFileResponse>( await response.Content.ReadAsStringAsync());
            httpResponse.ProcessId = processIdResponse.ProcessId;
            return httpResponse;

        }

        /// <summary>
        /// Submits a GET request to the specified URI within the Base Address
        /// </summary>
        /// <param name="requestUri">URI for GET request.</param>
        /// <returns></returns>
        public async Task<string> GetAsync(string requestUri)
        {
            HttpResponseMessage response = _client.GetAsync(requestUri).Result;

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            string error = response.Headers.Contains("error") ?
                string.Join(". ", response.Headers.GetValues("error")) : null;

            throw new AfcRestException(response.StatusCode, error);

        }

        /// <summary>
        /// Submits a GET request to the specified URI using the submitted processId and the Base Address
        /// </summary>
        /// <param name="requestUri">URI for GET request.</param>
        /// <returns></returns>
        public async Task<GeoBatchStatus> GetGeoBatchStatusAsync(string requestUri)
        {
            HttpResponseMessage response = _client.GetAsync(requestUri).Result;

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeoBatchStatus>(await response.Content.ReadAsStringAsync());
            }

            string error = response.Headers.Contains("error") ?
                string.Join(". ", response.Headers.GetValues("error")) : null;

            throw new AfcRestException(response.StatusCode, error);

        }

        /// <summary>
        /// Submits a GET request to the specified URI using the submitted processId and the Base Address
        /// </summary>
        /// <param name="requestUri">URI for GET request.</param>
        /// <returns></returns>
        public async Task<GeoBatchLog> GetGeoBatchLogAsync(string requestUri)
        {
            HttpResponseMessage response = _client.GetAsync(requestUri).Result;

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeoBatchLog>(await response.Content.ReadAsStringAsync());
            }

            string error = response.Headers.Contains("error") ?
                string.Join(". ", response.Headers.GetValues("error")) : null;

            throw new AfcRestException(response.StatusCode, error);

        }

        #endregion

        #region IDisposable Implementation

        /// <summary>
        /// Dispose underlying resources.
        /// </summary>
        public void Dispose()
        {
            if (_client == null)
            {
                return;
            }

            _client.Dispose();
            _client = null;
        }

        #endregion
    }
}