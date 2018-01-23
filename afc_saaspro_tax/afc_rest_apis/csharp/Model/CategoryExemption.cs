using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Specifies tax exemptions based on the tax category.
    /// </summary>
    [DataContract]
    public partial class CategoryExemption
    {
        /// <summary>
        /// Three-character country ISO code. Required if State is not specified.
        /// </summary>
        [DataMember(Name="CountryISO", EmitDefaultValue=false)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Two-character state abbreviation. Required if CountryISO is not specified.
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// See the CommsPlatform.API.WrapperClasses User's Manual for valid tax categories.
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public int? TaxCategory { get; set; }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
