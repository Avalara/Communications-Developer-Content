using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Parameter for CustMode/ProcessBatch API.
    /// </summary>
    [DataContract]
    public partial class ProcessBatchRequest
    {
        /// <summary>
        /// Identifier for customer batch to process.
        /// </summary>
        [DataMember(Name="CustBatchId", EmitDefaultValue=false)]
        public long? CustBatchId { get; set; }

        /// <summary>
        /// List of states for tax exclusions.
        /// </summary>
        [DataMember(Name="Exclusions", EmitDefaultValue=false)]
        public List<Exclusion> Exclusions { get; set; }

        /// <summary>
        /// Indicates if the individual transaction taxes should be returned in the response.
        /// </summary>
        [DataMember(Name="ReturnDetail", EmitDefaultValue=false)]
        public bool? ReturnDetail { get; set; }
  
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
