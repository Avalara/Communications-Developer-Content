using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Historical tax rate information for a tax.
    /// </summary>
    [DataContract]
    public partial class TaxRateHistory
    {
        /// <summary>
        /// Effective date for rate.
        /// </summary>
        [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }

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
