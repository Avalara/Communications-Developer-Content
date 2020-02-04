using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Individual File Status For Geo Batch result
    /// </summary>
    public class GeoBatchStatus
    {
        /// <summary>
        /// Process ID for Batch file.
        /// </summary>
        [JsonProperty("ProcessId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Request Date.
        /// </summary>
        [JsonProperty("RequestDate", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime? RequestDate { get; set; }

        /// <summary>
        /// Request Date.
        /// </summary>
        [JsonProperty("ProcessingStart", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime? ProcessingStart { get; set; }

        /// <summary>
        /// Processing End.
        /// </summary>
        [JsonProperty("ProcessingEnd", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime? ProcessingEnd { get; set; }

        /// <summary>
        /// Status Of Batch File.
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Output File Name.
        /// </summary>
        [JsonProperty("Downloads", NullValueHandling = NullValueHandling.Ignore)]
        public GeoBatchDownloadResponse Downloads { get; set; }

        /// <summary>
        /// Error information.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public List<Error> Error { get; set; }
     
    }
}
