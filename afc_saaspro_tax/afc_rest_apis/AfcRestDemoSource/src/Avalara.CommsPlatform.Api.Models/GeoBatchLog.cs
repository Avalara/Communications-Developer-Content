using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for Geo Batch Submit File API.
    /// </summary>
    public class GeoBatchLog
    {
        /// <summary>
        /// DateTime of Log.
        /// </summary>
        [JsonProperty("Log", NullValueHandling = NullValueHandling.Ignore)]
        public List<GeoBatchLogItem> Log { get; set; }

        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }
    }
}
