using Newtonsoft.Json;
using System;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Version specific results for service info request.
    /// </summary>
    public class VersionInfo
    {
        /// <summary>
        /// AFC Engine Version
        /// </summary>
        [JsonProperty("AfcEngineVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string AfcEngineVersion { get; set; }

        /// <summary>
        /// Service Build Version.
        /// </summary>
        [JsonProperty("BuildVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildVersion { get; set; }

    }
}