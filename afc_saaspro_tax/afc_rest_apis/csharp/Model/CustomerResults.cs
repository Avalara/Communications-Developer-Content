using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Data structure returned when processing transactions in customer mode.
    /// </summary>
    [DataContract]
    public partial class CustomerResults
    {
        /// <summar
        /// <summary>
        /// Individual taxes for each transaction.
        /// </summary>
        [DataMember(Name="Taxes", EmitDefaultValue=false)]
        public List<TaxData> Taxes { get; set; }

        /// <summary>
        /// Summarized taxes for customer batch.
        /// </summary>
        [DataMember(Name="SummarizedTaxes", EmitDefaultValue=false)]
        public List<CustomerTaxData> SummarizedTaxes { get; set; }
  
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
