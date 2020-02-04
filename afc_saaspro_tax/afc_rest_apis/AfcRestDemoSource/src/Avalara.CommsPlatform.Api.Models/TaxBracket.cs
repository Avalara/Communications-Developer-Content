using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Rate information for a tax bracket.
    /// </summary>
    public class TaxBracket
    {
        /// <summary>
        /// Tax rate. Value cannot be negative. For rated taxes, value must be from 0 to 1. Otherwise, value may be larger.
        /// </summary>
        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate { get; set; }

        /// <summary>
        /// Maximum base that this rate applies to.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxBase { get; set; }
    }
}