using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Contains information about an invoice or quote.
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Document code.
        /// </summary>
        [JsonProperty("doc", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// Indicates if invoice should be committed as soon as it is processed.
        /// Default: false.
        /// </summary>
        [JsonProperty("cmmt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Commit { get; set; }

        /// <summary>
        /// Bill-to location.
        /// </summary>
        [JsonProperty("bill", NullValueHandling = NullValueHandling.Ignore)]
        public Location BillTo { get; set; }

        /// <summary>
        /// Customer type.
        /// </summary>
        [JsonProperty("cust", NullValueHandling = NullValueHandling.Ignore)]
        public short? CustomerType { get; set; }

        /// <summary>
        /// Indicates if customer is a Lifeline participant.
        /// Default: false.
        /// </summary>
        [JsonProperty("lfln", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lifeline { get; set; }

        /// <summary>
        /// Invoice date.
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Tax exemptions.
        /// </summary>
        [JsonProperty("exms", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TaxExemption> Exemptions { get; set; }

        /// <summary>
        /// Line items.
        /// </summary>
        [JsonProperty("itms", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LineItem> Items { get; set; }

        /// <summary>
        /// Indicates if all line items within invoice should be processed in invoice mode.
        /// Default: true.
        /// </summary>
        [JsonProperty("invm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InvoiceMode { get; set; }

        /// <summary>
        /// Indicates if individual line item taxes should be included in response.
        /// Default: true.
        /// </summary>
        [JsonProperty("dtl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnDetail { get; set; }

        /// <summary>
        /// Indicates if the summarized taxes for the invoice should be included in the resonse.
        /// Default: false.
        /// </summary>
        [JsonProperty("summ", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnSummary { get; set; }

        /// <summary>
        /// Optional values for invoice. Maximum of 5. Keys must be numeric from 1 to 5.
        /// </summary>
        [JsonProperty("opt", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeyValuePair> OptionalFields { get; set; }
    }
}