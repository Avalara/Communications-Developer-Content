using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for tax calculation API.
    /// </summary>
    public class CalcTaxesResponse
    {
        /// <summary>
        /// Tax calculation results for each invoice submitted in request.
        /// </summary>
        [JsonProperty("inv", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<InvoiceResult> InvoiceResults { get; set; }

        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }
    }
}
