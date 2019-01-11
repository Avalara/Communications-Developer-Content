using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Contains location information for PCode conversion.
    /// </summary>
    [DataContract]
    public partial class RequestPCodeDetail
    {
        /// <summary>
        /// Fips code - leave null if other value is used.
        /// </summary>
        [DataMember(Name="FipsCode", EmitDefaultValue=false)]
        public string FipsCode { get; set; }

        /// <summary>
        /// NPANXX - leave null if other value is used.
        /// </summary>
        [DataMember(Name="NpaNxx", EmitDefaultValue=false)]
        public int? NpaNxx { get; set; }

        /// <summary>
        /// Zip Address - leave null if other value is used.
        /// </summary>
        [DataMember(Name="ZipAddress", EmitDefaultValue=false)]
        public ZipAddress ZipAddress { get; set; }
  
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
