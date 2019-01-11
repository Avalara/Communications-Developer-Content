using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax rate override information.
    /// </summary>
    public class TaxOverride
    {
        /// <summary>
        /// Jurisdiction PCode for this tax rate override.
        /// </summary>
        [JsonProperty("loc", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        /// <summary>
        /// Scope for override. 0 = Country, 1 = State, 2 = County, 3 = City.
        /// </summary>
        [JsonProperty("scp", NullValueHandling = NullValueHandling.Ignore)]
        public short? Scope { get; set; }

        /// <summary>
        /// Tax type ID. 
        /// </summary>
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxType { get; set; }

        /// <summary>
        /// Tax level ID. 0 = Federal, 1 = State, 2 = County, 3 = City.
        /// </summary>
        [JsonProperty("lvl", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxLevel { get; set; }

        /// <summary>
        /// Indicates if the tax can be exempted using level exemptions.
        /// </summary>
        [JsonProperty("lvlExm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LevelExemptible { get; set; }

        /// <summary>
        /// Tax rate/bracket information.
        /// </summary>
        [JsonProperty("brkt", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TaxBracket> BracketInfo { get; set; }
    }
}
