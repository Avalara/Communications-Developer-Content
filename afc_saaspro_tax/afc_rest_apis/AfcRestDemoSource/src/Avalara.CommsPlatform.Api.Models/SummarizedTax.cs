using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax data for summarized invoice taxes.
    /// </summary>
    public class SummarizedTax: TaxBase
    {
        /// <summary>
        /// Maximum base for tax bracket.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxBase { get; set; }

        /// <summary>
        /// Minimim base for tax bracket.
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinBase { get; set; }

        /// <summary>
        /// Total charge amount.
        /// </summary>
        [JsonProperty("tchg", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalCharge { get; set; }
    }
}