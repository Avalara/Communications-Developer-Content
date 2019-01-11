using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Conference bridge participant tax calculation results.
    /// </summary>
    public class BridgeParticipantResult
    {
        /// <summary>
        /// Reference ID for participant.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantReferenceID { get; set; }

        /// <summary>
        /// Transaction type ID used for participant.
        /// </summary>
        [JsonProperty("tran", NullValueHandling = NullValueHandling.Ignore)]
        public short TransactionType { get; set; }

        /// <summary>
        /// Service type ID used for participant.
        /// </summary>
        [JsonProperty("serv", NullValueHandling = NullValueHandling.Ignore)]
        public short ServiceType { get; set; }

        /// <summary>
        /// Taxes for participant.
        /// </summary>
        [JsonProperty("txs", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Tax> Taxes { get; set; }

        /// <summary>
        /// Error message for participant tax calculation (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}