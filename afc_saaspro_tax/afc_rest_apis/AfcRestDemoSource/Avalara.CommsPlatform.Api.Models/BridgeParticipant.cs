using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Conference bridge participant information.
    /// </summary>
    public class BridgeParticipant
    {
        /// <summary>
        /// Reference ID for participant.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceID { get; set; }

        /// <summary>
        /// Participant's location.
        /// </summary>
        [JsonProperty("loc", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }
    }
}