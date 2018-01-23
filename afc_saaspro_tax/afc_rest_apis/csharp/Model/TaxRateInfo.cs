using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Tax rate information for a tax.
    /// </summary>
    [DataContract]
    public partial class TaxRateInfo
    {
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
        /// Tax rate history.
        /// </summary>
        [DataMember(Name="RateHistory", EmitDefaultValue=false)]
        public List<TaxRateHistory> RateHistory { get; set; }
  
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
