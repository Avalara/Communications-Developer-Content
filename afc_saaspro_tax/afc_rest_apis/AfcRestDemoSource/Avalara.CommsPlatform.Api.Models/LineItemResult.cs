using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax calculation results for a single line item.
    /// </summary>
    public class LineItemResult
    {
        /// <summary>
        /// Reference ID for line item.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNumber { get; set; }

        /// <summary>
        /// Base sale amount for tax-inclusive line items.
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public double? BaseSaleAmount { get; set; }

        /// <summary>
        /// Taxes generated for line item.
        /// </summary>
        [JsonProperty("txs", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Tax> Taxes { get; set; }

        /// <summary>
        /// Conference bridge participant tax calculation results.
        /// </summary>
        [JsonProperty("brdg", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BridgeParticipantResult> BridgeResults { get; set; }
        
        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }
    }
}