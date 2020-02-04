using Newtonsoft.Json;
using System;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Input data for Geocoding API. 
    /// </summary>
    public class GeocodeRequest: Address
    {
        /// <summary>
        /// Optional reference Id for geocode request. 
        /// Only address information or latitude/longitude should be provided in request body but not both.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Indicates if the CASS validated address is desired in the results.
        /// </summary>
        [JsonProperty("cass", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnCass { get; set; }

        /// <summary>
        /// Latitude for geocoding based on lat/long coordinates.
        /// </summary>
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude for geocoding based on lat/long coordinates.
        /// </summary>
        [JsonProperty("long", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }
    }
}