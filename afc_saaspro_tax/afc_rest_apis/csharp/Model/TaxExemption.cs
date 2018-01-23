using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Contains information for exemption a single tax.
    /// </summary>
    [DataContract]
    public partial class TaxExemption
    {
        /// <summary>
        /// PCode for jurisdiction to exempt.
        /// </summary>
        [DataMember(Name="PCode", EmitDefaultValue=false)]
        public int? PCode { get; set; }

        /// <summary>
        /// Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
        /// </summary>
        [DataMember(Name="TaxLevel", EmitDefaultValue=false)]
        public int? TaxLevel { get; set; }

        /// <summary>
        /// Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public int? TaxType { get; set; }
  
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
