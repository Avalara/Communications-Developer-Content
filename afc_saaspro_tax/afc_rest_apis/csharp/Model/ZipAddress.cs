using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Information used for looking up jurisidictions using location names and/or zip codes.
    /// </summary>
    [DataContract]
    public partial class ZipAddress
    {
        /// <summary>
        /// Three-character country ISO code.
        /// </summary>
        [DataMember(Name="CountryISO", EmitDefaultValue=false)]
        public string CountryIso { get; set; }

        /// <summary>
        /// County name.
        /// </summary>
        [DataMember(Name="County", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Locality name.
        /// </summary>
        [DataMember(Name="Locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Two-character state abbreviation.
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Zip code for location.
        /// </summary>
        [DataMember(Name="ZipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Zip + 4 for location.
        /// </summary>
        [DataMember(Name="ZipP4", EmitDefaultValue=false)]
        public string ZipP4 { get; set; }
  
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
