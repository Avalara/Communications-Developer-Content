using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Key/value pair data.
    /// </summary>
    public class KeyValuePair
    {
        /// <summary>
        /// Key.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        [JsonProperty("val", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}