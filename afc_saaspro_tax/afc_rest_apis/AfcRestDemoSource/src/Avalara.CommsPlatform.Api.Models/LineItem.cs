using System;
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
        /// Maximum length of a LineItem string.
        /// </summary>
        public static int MAX_LINETEM_STRING = 150;      
        
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
        /// 0 - Wholesale : Indicates that the item was sold to a wholeseller.
        /// 1 - Retail : Indicates that the item was sold to an end user - a retail sale.
        /// 2 - Consumed : Indicates that the item was consumed directly (SAU products only).
        /// 3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only).
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
        /// For pro-rated credit or adjustment calculations.
        /// 0 = default
        /// 1 = do not return non-proratable fixed taxes in response
        /// 2 = return non-proratable fixed taxes in response
        /// </summary>
        [JsonProperty("proadj", NullValueHandling = NullValueHandling.Ignore)]
        public int ProRatedAdjType { get; set; }

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

        /// <summary>
        /// Attribute/property value for sales and use transaction/service pairs.
        /// </summary>
        [JsonProperty("prop", NullValueHandling = NullValueHandling.Ignore)]
        public short? AttributeProperty { get; set; }

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
        /// Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity
        /// </summary>
        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public short? Quantity { get; set; }

        /// <summary>
        /// General Ledger reference to be used in reporting
        /// </summary>
        [JsonProperty("glref", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneralLedgerRef { get; set; }
    }
}