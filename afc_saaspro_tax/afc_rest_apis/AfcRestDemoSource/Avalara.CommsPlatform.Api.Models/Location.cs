using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Location data used to determine taxing jurisdiction.
    /// </summary>
    public class Location : Address
    {
        /// <summary>
        /// County name.
        /// </summary>
        [JsonProperty("cnty", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; set; }

        /// <summary>
        /// Country ISO code.
        /// </summary>
        [JsonProperty("ctry", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Indicates if the location is within city limits.
        /// Default: true.
        /// </summary>
        [JsonProperty("int", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incorporated { get; set; }

        /// <summary>
        /// Indicates if this address should be geocoded in order to obtain taxing jurisdiction.
        /// Default: false.
        /// </summary>
        [JsonProperty("geo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Geocode { get; set; }

        /// <summary>
        /// PCode for taxing jurisdiction.
        /// </summary>
        [JsonProperty("pcd", NullValueHandling = NullValueHandling.Ignore)]
        public uint? PCode { get; set; }

        /// <summary>
        /// NPANXX number.
        /// </summary>
        [JsonProperty("npa", NullValueHandling = NullValueHandling.Ignore)]
        public uint? NpaNxx { get; set; }

        /// <summary>
        /// FIPS code for taxing jurisdiction.
        /// </summary>
        [JsonProperty("fips", NullValueHandling = NullValueHandling.Ignore)]
        public string FipsCode { get; set; }
    }
}