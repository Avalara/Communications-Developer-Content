using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Structure returned when invoking the bridge conference tax calculation APIs.
    /// </summary>
    [DataContract]
    public partial class BridgeConferenceResults
    {
        /// <summary>
        /// Participant taxes
        /// </summary>
        [DataMember(Name="ParticipantResults", EmitDefaultValue=false)]
        public List<BridgeConferenceParticipantResult> ParticipantResults { get; set; }

        /// <summary>
        /// Summarized taxes for bridge conference
        /// </summary>
        [DataMember(Name="Taxes", EmitDefaultValue=false)]
        public List<TaxData> Taxes { get; set; }
  
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
