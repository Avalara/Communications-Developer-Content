using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax rate override information.
    /// </summary>
    public class ReportingInformation
    {
        /// <summary>
        /// Account id
        /// </summary>
        [JsonProperty("acct", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountRef { get; set; }

        /// <summary>
        /// Customer reference
        /// </summary>
        [JsonProperty("custref", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerRef { get; set; }

        /// <summary>
        /// Invoice Number reference
        /// </summary>
        [JsonProperty("invn", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceRef { get; set; }

        /// <summary>
        /// Bill Cycle reference
        /// </summary>
        [JsonProperty("bcyc", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycleRef { get; set; }

        /// <summary>
        /// Currency code for invoice
        /// </summary>
        [JsonProperty("ccycd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Currency description
        /// </summary>
        [JsonProperty("ccydesc", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyDesc { get; set; }
    }
}