using Newtonsoft.Json;
using System;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Address information.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Street address.
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// State name or abbreviation.
        /// </summary>
        [JsonProperty("st", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }
    }
}