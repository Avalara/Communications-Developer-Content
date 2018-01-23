using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Contains location and zip code range information for a jurisdiction.
    /// </summary>
    [DataContract]
    public partial class AddressData
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
        /// Tax level ID.
        /// </summary>
        [DataMember(Name="TaxLevel", EmitDefaultValue=false)]
        public int? TaxLevel { get; set; }

        /// <summary>
        /// Begin of Zip code range.
        /// </summary>
        [DataMember(Name="ZipBegin", EmitDefaultValue=false)]
        public string ZipBegin { get; set; }

        /// <summary>
        /// End of Zip code range.
        /// </summary>
        [DataMember(Name="ZipEnd", EmitDefaultValue=false)]
        public string ZipEnd { get; set; }

        /// <summary>
        /// Begin of Zip+4 code range.
        /// </summary>
        [DataMember(Name="ZipP4Begin", EmitDefaultValue=false)]
        public string ZipP4Begin { get; set; }

        /// <summary>
        /// End of Zip+4 code range.
        /// </summary>
        [DataMember(Name="ZipP4End", EmitDefaultValue=false)]
        public string ZipP4End { get; set; }
  
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
