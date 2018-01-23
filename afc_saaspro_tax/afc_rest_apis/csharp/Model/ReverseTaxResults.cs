using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Structure returned when invoking the reverse tax calculation APIs.
    /// </summary>
    [DataContract]
    public partial class ReverseTaxResults
    {
        /// <summary>
        /// Base sale amount necessary to arrive at desired total tax.
        /// </summary>
        [DataMember(Name="BaseSaleAmount", EmitDefaultValue=false)]
        public double? BaseSaleAmount { get; set; }

        /// <summary>
        /// Taxes generated for the transaction.
        /// </summary>
        /// <value>Taxes generated for the transaction.</value>
        [DataMember(Name="Taxes", EmitDefaultValue=false)]
        public List<TaxData> Taxes { get; set; }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
