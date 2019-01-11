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
        /// PCode for taxing jurisdiction.
        /// </summary>
        [JsonProperty("pcd", NullValueHandling = NullValueHandling.Ignore)]
        public uint? PCode { get; set; }

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
    }
}