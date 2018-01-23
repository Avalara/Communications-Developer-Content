using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Paremeter for the tax calculation with override APIs.
    /// </summary>
    [DataContract]
    public partial class CalculateWithOverridesRequest
    {
        /// <summary>
        /// Transaction data.
        /// </summary>
        [DataMember(Name="Transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// List of tax rate overrides to be applied in tax calculations.
        /// </summary>
        [DataMember(Name="Overrides", EmitDefaultValue=false)]
        public List<TaxRateOverrideInfo> Overrides { get; set; }

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
