using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Parameter for the CustMode/CalcTaxes and CustMode/CalcAdj APIs.
    /// </summary>
    [DataContract]
    public partial class CustModeTransaction
    {
        /// <summary>
        /// Customer batch identifier.
        /// </summary>
        [DataMember(Name="CustBatchID", EmitDefaultValue=false)]
        public long? CustBatchID { get; set; }

        /// <summary>
        /// Transaction to include into the customer batch.
        /// </summary>
        [DataMember(Name="Transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }
        
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
