using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for service info API.
    /// </summary>
    public class ServiceInfo
    {
        /// <summary>
        /// Server time.
        /// </summary>
        [JsonProperty("ServerTime", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime ServerTime { get; set; }

        /// <summary>
        /// Version information.
        /// </summary>
        [JsonProperty("Versions", NullValueHandling = NullValueHandling.Ignore)]
        public VersionInfo Versions { get; set; }

        /// <summary>
        /// Error information.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}
