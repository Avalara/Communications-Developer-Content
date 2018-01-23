using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax data for individual line item.
    /// </summary>
    public class Tax: TaxBase
    {
        /// <summary>
        /// Indicates if tax is billable to customer.
        /// </summary>
        [JsonProperty("bill", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Indicates if the tax is to be reported to jurisdiction.
        /// </summary>
        [JsonProperty("cmpl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Compliance { get; set; }

        /// <summary>
        /// Taxable measure.
        /// </summary>
        [JsonProperty("tm", NullValueHandling = NullValueHandling.Ignore)]
        public double? TaxableMeasure { get; set; }
    }
}