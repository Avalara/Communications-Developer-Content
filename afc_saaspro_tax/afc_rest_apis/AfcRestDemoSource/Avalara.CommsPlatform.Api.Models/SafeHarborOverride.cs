using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Safe harbor rate override for a USF tax type.
    /// </summary>
    public class SafeHarborOverride
    {
        /// <summary>
        /// Safe harbor type (1 = Cellular, 2 = VoIP, 4 = Paging).
        /// </summary>
        [JsonProperty("sh", NullValueHandling = NullValueHandling.Ignore)]
        public short? SafeHarborType { get; set; }

        /// <summary>
        /// Original Federal TAM value to override.
        /// </summary>
        [JsonProperty("old", NullValueHandling = NullValueHandling.Ignore)]
        public double? OriginalFederalTam { get; set; }

        /// <summary>
        /// New TAM value that will replace the original TAM value.
        /// </summary>
        [JsonProperty("new", NullValueHandling = NullValueHandling.Ignore)]
        public double? NewFederalTam { get; set; }
    }
}