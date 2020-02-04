using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Specifies a tax exclusion by state.
    /// </summary>
    public class Exclusion
    {
        /// <summary>
        /// Country ISO code.
        /// </summary>
        [JsonProperty("ctry", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// State abbreviation.
        /// </summary>
        [JsonProperty("st", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Indicates if exclusion applies to the specified state.
        /// </summary>
        [JsonProperty("excl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExclusionOn { get; set; }
    }
}