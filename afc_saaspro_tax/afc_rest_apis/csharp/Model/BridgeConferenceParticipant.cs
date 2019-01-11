using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Structure returned when invoking the bridge conference tax calculation APIs.
    /// </summary>
    [DataContract]
    public partial class BridgeConferenceParticipant
    {
        /// <summary>
        /// Address for participant - all participants must use address values if any participant uses an address.
        /// Not required if ParticipantPCode or ParticipantNpaNxx are specified.
        /// </summary>
        [DataMember(Name="ParticipantAddress", EmitDefaultValue=false)]
        public ZipAddress ParticipantAddress { get; set; }

        /// <summary>
        /// PCode forpParticipant – all participants must use PCode values if any participant uses PCode.
        /// Not required if ParticipantAddress or ParticipantNpaNxx are specified.
        /// </summary>
        [DataMember(Name="ParticipantPCode", EmitDefaultValue=false)]
        public int? ParticipantPCode { get; set; }

        /// <summary>
        /// NpaNxx for participant – all participants must use NPANXX values if any participant uses NPANXX.
        /// Not required if ParticipantAddress or ParticipantPCode are specified.
        /// </summary>
        [DataMember(Name="ParticipantNpaNxx", EmitDefaultValue=false)]
        public int? ParticipantNpaNxx { get; set; }

        /// <summary>
        /// Alpha-numeric reference that will tie a participant in the request to participant taxes in response
        /// if ReturnParticipantTaxes is true. Max 127 bytes.
        /// </summary>
        [DataMember(Name="ParticipantRef", EmitDefaultValue=false)]
        public string ParticipantRef { get; set; }
  
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
