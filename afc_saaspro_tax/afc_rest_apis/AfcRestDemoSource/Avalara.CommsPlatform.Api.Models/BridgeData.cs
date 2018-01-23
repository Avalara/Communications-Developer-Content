using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Conference bridge transaction data.
    /// </summary>
    public class BridgeData
    {
        /// <summary>
        /// Indicates if invalid participants should fail the transaction (false) or continue processing (true).
        /// </summary>
        [JsonProperty("proc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProcessInvalidParticipant { get; set; }

        /// <summary>
        /// Indicates if the individual participant taxes should be included in the response.
        /// </summary>
        [JsonProperty("rtrn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnParticipantTaxes { get; set; }

        /// <summary>
        /// List of conference bridge participants.
        /// </summary>
        [JsonProperty("prts", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BridgeParticipant> Participants { get; set; }
    }
}