using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Specifies a tax exclusion by state.
    /// </summary>
    [DataContract]
    public partial class Exclusion
    {
        /// <summary>
        /// Three-character country ISO code. Required if State not specified.
        /// </summary>
        [DataMember(Name="CountryISO", EmitDefaultValue=false)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Two-character state abbreviation. Required if CountryISO not specified.
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// True if entity exclusion applies in the state, otherwise false.
        /// </summary>
        [DataMember(Name="ExclusionOn", EmitDefaultValue=false)]
        public bool? ExclusionOn { get; set; }
  
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
