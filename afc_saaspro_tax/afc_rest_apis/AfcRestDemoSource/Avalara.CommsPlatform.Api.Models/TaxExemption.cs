using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax exemption data.
    /// </summary>
    public class TaxExemption
    {
        /// <summary>
        /// For exemptions based on TaxLevel only, forces taxes that normally do not allow exemptions to be exempt.
        /// Default: false.
        /// </summary>
        [JsonProperty("frc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// Jurisdiction for exemption.
        /// </summary>
        [JsonProperty("loc", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        /// <summary>
        /// Tax type ID.
        /// </summary>
        [JsonProperty("tpe", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxType { get; set; }

        /// <summary>
        /// Tax level ID.
        /// </summary>
        [JsonProperty("lvl", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxLevel { get; set; }

        /// <summary>
        /// Tax category to exempt. If present, will override TaxType and TaxLevel.
        /// </summary>
        [JsonProperty("cat", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxCategory { get; set; }
    }
}