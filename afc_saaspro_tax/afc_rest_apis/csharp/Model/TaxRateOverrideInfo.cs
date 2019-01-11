using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Contains information required to override a tax rate.
    /// </summary>
    [DataContract]
    public partial class TaxRateOverrideInfo
    {
        /// <summary>
        /// Jurisdiction PCode for this tax rate override.
        /// </summary>
        [DataMember(Name="Pcode", EmitDefaultValue=false)]
        public int? Pcode { get; set; }

        /// <summary>
        /// Scope for override. See tax levels in the CommsPlatform.API.WrapperClasses User's Manual for valid values.
        /// </summary>
        [DataMember(Name="Scope", EmitDefaultValue=false)]
        public int? Scope { get; set; }

        /// <summary>
        /// Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public int? TaxType { get; set; }

        /// <summary>
        /// Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
        /// </summary>
        [DataMember(Name="TaxLevel", EmitDefaultValue=false)]
        public int? TaxLevel { get; set; }

        /// <summary>
        /// Indicates if the tax can be exempted using level exemptions.
        /// </summary>
        [DataMember(Name="LevelExemptible", EmitDefaultValue=false)]
        public bool? LevelExemptible { get; set; }

        /// <summary>
        /// Tax rate/bracket information.
        /// </summary>
        [DataMember(Name="BracketInfo", EmitDefaultValue=false)]
        public List<TaxBracketInfo> BracketInfo { get; set; }
  
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
