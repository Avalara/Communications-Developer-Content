using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Structure returned when invoking the bridge conference tax calculation APIs.
    /// </summary>
    [DataContract]
    public partial class BridgeConferenceParticipantResult
    {
        /// <summary>
        /// Participant reference from request.
        /// </summary>
        [DataMember(Name = "ParticipantRef", EmitDefaultValue = false)]
        public string ParticipantRef { get; set; }

        /// <summary>
        /// Error code for participant tax calculation (as applicable).
        /// </summary>
        [DataMember(Name = "ErrorCode", EmitDefaultValue = false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Transaction type used for participant.
        /// </summary>
        [DataMember(Name = "TransactionType", EmitDefaultValue = false)]
        public int? TransactionType { get; set; }

        /// <summary>
        /// Service type used for participant.
        /// </summary>
        [DataMember(Name = "ServiceType", EmitDefaultValue = false)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// List of objects that contain information about the taxes for an individual participant.
        /// </summary>
        [DataMember(Name = "ParticipantTaxes", EmitDefaultValue = false)]
        public List<TaxData> ParticipantTaxes { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
