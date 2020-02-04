using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for Geo Batch Submit File API.
    /// </summary>
    public class GeoBatchSubmitFileResponse
    {
        /// <summary>
        /// File ID that was uploaded
        /// </summary>
        [JsonProperty("ProcessId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }
    }
}
