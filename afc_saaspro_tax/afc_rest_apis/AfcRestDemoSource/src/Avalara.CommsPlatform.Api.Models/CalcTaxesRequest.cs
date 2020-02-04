using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Request body for tax calculation API.
    /// </summary>
    public class CalcTaxesRequest
    {
        /// <summary>
        /// Request configuration options.
        /// </summary>
        [JsonProperty("cfg", NullValueHandling = NullValueHandling.Ignore)]
        public RequestConfig ConfigOptions { get; set; }

        /// <summary>
        /// Company information required for tax calculations.
        /// </summary>
        [JsonProperty("cmpn", NullValueHandling = NullValueHandling.Ignore)]
        public CompanyData CompanyData { get; set; }

        /// <summary>
        /// List of invoices to process.
        /// </summary>
        [JsonProperty("inv", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Invoice> Invoices { get; set; }

        /// <summary>
        /// Tax rate overrides.
        /// </summary>
        [JsonProperty("ovr", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TaxOverride> TaxOverrides { get; set; }

        /// <summary>
        /// Safe harbor overrides for USF taxes.
        /// </summary>
        [JsonProperty("sovr", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SafeHarborOverride> SafeHarborOverrides { get; set; }
    }
}