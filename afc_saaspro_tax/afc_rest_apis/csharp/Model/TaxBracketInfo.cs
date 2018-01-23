using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Tax rate information for a tax bracket.
    /// </summary>
    [DataContract]
    public partial class TaxBracketInfo
    {
        /// <summary>
        /// Tax rate. Value cannot be negative. For rated taxes, value must be from 0 to 1. Otherwise, value may be larger.
        /// </summary>
        [DataMember(Name="Rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }

        /// <summary>
        /// Maximum base that this rate applies to.
        /// </summary>
        /// <value>Maximum base that this rate applies to.</value>
        [DataMember(Name="MaxBase", EmitDefaultValue=false)]
        public double? MaxBase { get; set; }

        /// <summary>
        /// For sales and use taxes only (tax types 1 and 49), overrides the rate for the tax at the county level.
        /// </summary>
        [DataMember(Name="CountyOverrideTax", EmitDefaultValue=false)]
        public double? CountyOverrideTax { get; set; }

        /// <summary>
        /// For sales and use taxes only (tax types 1 and 49), overrides the rate for the tax at the state level.
        /// </summary>
        [DataMember(Name="StateOverrideTax", EmitDefaultValue=false)]
        public double? StateOverrideTax { get; set; }

        /// <summary>
        /// For sales and use taxes only (tax types 1 and 49) indicates that this tax replaces the tax at the state level.
        /// </summary>
        [DataMember(Name="StateOverrideOn", EmitDefaultValue=false)]
        public bool? StateOverrideOn { get; set; }

        /// <summary>
        /// For sales and use taxes only (tax types 1 and 49), indicates that this tax replaces the tax at the county level.
        /// </summary>
        [DataMember(Name="CountyOverrideOn", EmitDefaultValue=false)]
        public bool? CountyOverrideOn { get; set; }
  
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
