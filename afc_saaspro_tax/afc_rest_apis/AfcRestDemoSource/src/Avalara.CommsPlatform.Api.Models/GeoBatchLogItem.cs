using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for Geo Batch Submit File API.
    /// </summary>
    public class GeoBatchLogItem
    {
        /// <summary>
        /// DateTime of Log.
        /// </summary>
        [JsonProperty("Date", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// Level of Status.
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Output File Name.
        /// </summary>
        [JsonProperty("Message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
}
