using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax calculation results for an invoice.
    /// </summary>
    public class InvoiceResult
    {
        /// <summary>
        /// Document number for invoice.
        /// </summary>
        [JsonProperty("doc", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// Individual tax calculation results for each line item.
        /// </summary>
        [JsonProperty("itms", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LineItemResult> ItemResults { get; set; }

        /// <summary>
        /// Summarized taxes for invoice.
        /// </summary>
        [JsonProperty("summ", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SummarizedTax> SummarizedTaxes { get; set; }

        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }

        /// <summary>
        /// Flag indicating reporting information should be returned.
        /// Reference online documentation for more details 
        /// </summary>
        [JsonProperty("incrf", NullValueHandling = NullValueHandling.Ignore)]
        public ReportingInformation ReportingInformation { get; set; }
    }
}