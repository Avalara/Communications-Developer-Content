using Newtonsoft.Json;
using System;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Results for geocoding request.
    /// </summary>
    public class GeocodeResult
    {
        /// <summary>
        /// Reference Id from geocode request input.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// CASS certified address.
        /// </summary>
        [JsonProperty("cass", NullValueHandling = NullValueHandling.Ignore)]
        public Address CassAddress { get; set; }

        /// <summary>
        /// Census block.
        /// </summary>
        [JsonProperty("cBlk", NullValueHandling = NullValueHandling.Ignore)]
        public int? CensusBlock { get; set; }

        /// <summary>
        /// Census tract.
        /// </summary>
        [JsonProperty("cTrc", NullValueHandling = NullValueHandling.Ignore)]
        public int? CensusTract { get; set; }

        /// <summary>
        /// County
        /// </summary>
        [JsonProperty("cnty", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; set; }

        /// <summary>
        /// Feature ID.
        /// </summary>
        [JsonProperty("feat", NullValueHandling = NullValueHandling.Ignore)]
        public int? FeatureId { get; set; }

        /// <summary>
        /// FIPS Code.
        /// </summary>
        [JsonProperty("fips", NullValueHandling = NullValueHandling.Ignore)]
        public string FipsCode { get; set; }

        /// <summary>
        /// Indicates if address is within city limits.
        /// </summary>
        [JsonProperty("inc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incorporated { get; set; }

        /// <summary>
        /// Tax jurisdiction name.
        /// </summary>
        [JsonProperty("jur", NullValueHandling = NullValueHandling.Ignore)]
        public string JurisdictionName { get; set; }

        /// <summary>
        /// Latitude.
        /// </summary>
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude.
        /// </summary>
        [JsonProperty("long", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        /// <summary>
        /// PCode for tax jurisdiction.
        /// </summary>
        [JsonProperty("pcd", NullValueHandling = NullValueHandling.Ignore)]
        public uint? PCode { get; set; }

        /// <summary>
        /// Score indicating accuracy of address match in mapping database.
        /// </summary>
        [JsonProperty("scr", NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}