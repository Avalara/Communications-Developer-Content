using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax data.
    /// </summary>
    public class TaxBase
    {
        /// <summary>
        /// Calculation type.
        /// </summary>
        [JsonProperty("calc", NullValueHandling = NullValueHandling.Ignore)]
        public short? CalculationType { get; set; }

        /// <summary>
        /// Tax category name.
        /// </summary>
        [JsonProperty("cat", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }
        
        /// <summary>
        /// Tax category ID.
        /// </summary>
        [JsonProperty("cid", NullValueHandling = NullValueHandling.Ignore)]
        public short? CategoryID { get; set; }

        /// <summary>
        /// Tax name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Exempt sale amount.
        /// </summary>
        [JsonProperty("exm", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExemptSaleAmount { get; set; }

        /// <summary>
        /// Lines.
        /// </summary>
        [JsonProperty("lns", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lines { get; set; }

        /// <summary>
        /// Minutes.
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minutes { get; set; }

        /// <summary>
        /// PCode for reporting jurisdiction.
        /// </summary>
        [JsonProperty("pcd", NullValueHandling = NullValueHandling.Ignore)]
        public uint? PCode { get; set; }

        /// <summary>
        /// PCode for taxing jurisdiction.
        /// Only returned if return extended tax data flag is true
        /// </summary>
        [JsonProperty("taxpcd", NullValueHandling = NullValueHandling.Ignore)]
        public uint? TaxingPCode { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate { get; set; }

        /// <summary>
        /// Indicates if this tax is a surcharge.
        /// </summary>
        [JsonProperty("sur", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surcharge { get; set; }

        /// <summary>
        /// Tax amount.
        /// </summary>
        [JsonProperty("tax", NullValueHandling = NullValueHandling.Ignore)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// Tax level ID.
        /// </summary>
        [JsonProperty("lvl", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxLevel { get; set; }

        /// <summary>
        /// Tax type ID.
        /// </summary>
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxType { get; set; }

        /// <summary>
        /// Flag indicating if tax was user exempted
        /// Only returned if return extended tax data flag is true
        /// </summary>
        [JsonProperty("usexm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserExempt { get; set; }

        /// <summary>
        /// Flag indicating the item is a no tax entry
        /// There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response
        /// Only returned if return extended tax data flag is true
        /// </summary>
        [JsonProperty("notax", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoTaxItem { get; set; }

        /// <summary>
        /// Transaction type used to calculate tax
        /// For bundles will be specific bundled item transaction type
        /// Only returned if return extended tax data flag is true
        /// </summary>
        [JsonProperty("trans", NullValueHandling = NullValueHandling.Ignore)]
        public short? TransactionType { get; set; }

        /// <summary>
        /// Service type used to calculate tax
        /// For bundles will be specific bundled item service type
        /// Only returned if return extended tax data flag is true
        /// </summary>
        [JsonProperty("svc", NullValueHandling = NullValueHandling.Ignore)]
        public short? ServiceType { get; set; }

        /// <summary>
        /// Charge used to calculate tax
        /// For bundles will be the percentage of charge applied to bundled item
        /// For tax inclusive calls will be the calculated charge
        /// Only returned if return extended tax data flag is true
        /// </summary>
        [JsonProperty("chg", NullValueHandling = NullValueHandling.Ignore)]
        public double? TransactionCharge { get; set; }
    }
}