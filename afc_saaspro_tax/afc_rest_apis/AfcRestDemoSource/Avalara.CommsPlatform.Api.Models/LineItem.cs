using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Data for an invoice or quote line item.
    /// </summary>
    public class LineItem
    {
        /// <summary>
        /// Reference ID for line item.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNumber { get; set; }

        /// <summary>
        /// Location for origination point. If null, will default to Invoice's BillTo location.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public Location From { get; set; }

        /// <summary>
        /// Location for destination point. If null, will default to Invoice's BillTo location.
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public Location To { get; set; }

        /// <summary>
        /// Charge amount.
        /// Default: 0.
        /// </summary>
        [JsonProperty("chg", NullValueHandling = NullValueHandling.Ignore)]
        public double? Charge { get; set; }

        /// <summary>
        /// Number of lines.
        /// Default: 0.
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lines { get; set; }

        /// <summary>
        /// Number of locations.
        /// Default: 0.
        /// </summary>
        [JsonProperty("loc", NullValueHandling = NullValueHandling.Ignore)]
        public int? Locations { get; set; }

        /// <summary>
        /// Number of minutes.
        /// Default: 0.
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minutes { get; set; }

        /// <summary>
        /// Indicates if this is a retail (true) or wholesale (false) transaction.
        /// </summary>
        [JsonProperty("sale", NullValueHandling = NullValueHandling.Ignore)]
        public short? SaleType { get; set; }

        /// <summary>
        /// Split for private-line transactions.
        /// </summary>
        [JsonProperty("plsp", NullValueHandling = NullValueHandling.Ignore)]
        public double? PrivateLineSplit { get; set; }

        /// <summary>
        /// Indicates if the charge for this line item is tax-inclusive.
        /// </summary>
        [JsonProperty("incl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// For pro-rated tax calculations. Percentage to pro-rate.
        /// </summary>
        [JsonProperty("pror", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProRatedPct { get; set; }

        /// <summary>
        /// Data for conference bridge transactions.
        /// </summary>
        [JsonProperty("brdg", NullValueHandling = NullValueHandling.Ignore)]
        public BridgeData BridgeData { get; set; }

        /// <summary>
        /// Transaction type ID.
        /// </summary>
        [JsonProperty("tran", NullValueHandling = NullValueHandling.Ignore)]
        public short? TransactionType { get; set; }

        /// <summary>
        /// Service type ID.
        /// </summary>
        [JsonProperty("serv", NullValueHandling = NullValueHandling.Ignore)]
        public short? ServiceType { get; set; }

        /// <summary>
        /// Indicates if this line item is a debit card transaction.
        /// Default: false.
        /// </summary>
        [JsonProperty("dbt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Debit { get; set; }

        /// <summary>
        /// Indicates if this line item is an adjustment.
        /// Default: false.
        /// </summary>
        [JsonProperty("adj", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdjustment { get; set; }

        /// <summary>
        /// Adjustment method.
        /// </summary>
        [JsonProperty("adjm", NullValueHandling = NullValueHandling.Ignore)]
        public short? AdjustmentMethod { get; set; }

        /// <summary>
        /// Discount type for adjustments.
        /// </summary>
        [JsonProperty("disc", NullValueHandling = NullValueHandling.Ignore)]
        public short? DiscountType { get; set; }

        /// <summary>
        /// Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10.
        /// </summary>
        [JsonProperty("opt", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeyValuePair> OptionalFields { get; set; }
    }
}