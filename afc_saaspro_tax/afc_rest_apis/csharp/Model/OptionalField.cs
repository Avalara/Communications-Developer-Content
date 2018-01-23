using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Data structure used to provide optional alphanumeric data for transactions.
    /// </summary>
    [DataContract]
    public partial class OptionalField
    {
        /// <summary>
        /// Key number (1 to 10) for optional field.
        /// </summary>
        [DataMember(Name="OptionalKeyNo", EmitDefaultValue=false)]
        public int? OptionalKeyNo { get; set; }

        /// <summary>
        /// Optional field value.
        /// </summary>
        [DataMember(Name="OptionalValue", EmitDefaultValue=false)]
        public string OptionalValue { get; set; }
  
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
