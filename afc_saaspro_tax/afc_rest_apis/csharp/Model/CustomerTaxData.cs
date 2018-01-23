using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Summarized tax data for a customer returned when using the customer mode API.
    /// </summary>
    [DataContract]
    public partial class CustomerTaxData
    {
        /// <summary>
        /// PCode for the reporting jurisdiction.
        /// </summary>
        [DataMember(Name="PCode", EmitDefaultValue=false)]
        public int? PCode { get; set; }

        /// <summary>
        /// Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public int? TaxType { get; set; }

        /// <summary>
        /// Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
        /// </summary>
        [DataMember(Name="TaxLevel", EmitDefaultValue=false)]
        public int? TaxLevel { get; set; }

        /// <summary>
        /// Calculation type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid calculation types.
        /// </summary>
        [DataMember(Name="CalculationType", EmitDefaultValue=false)]
        public int? CalculationType { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        [DataMember(Name="Rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }

        /// <summary>
        /// Tax amount.
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// Amount of the charge exempt from taxes.
        /// </summary>
        [DataMember(Name="ExemptSaleAmount", EmitDefaultValue=false)]
        public double? ExemptSaleAmount { get; set; }

        /// <summary>
        /// Tax description.
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if tax is considered a surcharge.
        /// </summary>
        [DataMember(Name="Surcharge", EmitDefaultValue=false)]
        public int? Surcharge { get; set; }

        /// <summary>
        /// Max amount to which tax is applied.
        /// </summary>
        [DataMember(Name="MaxBase", EmitDefaultValue=false)]
        public double? MaxBase { get; set; }

        /// <summary>
        /// Min amount to which tax is applied.
        /// </summary>
        [DataMember(Name="MinBase", EmitDefaultValue=false)]
        public double? MinBase { get; set; }

        /// <summary>
        /// Rate for amount above max base.
        /// </summary>
        [DataMember(Name="ExcessTax", EmitDefaultValue=false)]
        public double? ExcessTax { get; set; }

        /// <summary>
        /// Sum of charges for this customer.
        /// </summary>
        [DataMember(Name="TotalCharge", EmitDefaultValue=false)]
        public double? TotalCharge { get; set; }

        /// <summary>
        /// Tax category ID.
        /// </summary>
        [DataMember(Name="CategoryID", EmitDefaultValue=false)]
        public int? CategoryID { get; set; }

        /// <summary>
        /// Tax category description.
        /// </summary>
        [DataMember(Name="CategoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Number of lines used to calculate the tax (for per-line tax calculations).
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public int? Lines { get; set; }

        /// <summary>
        /// Sum of locations from customer input.
        /// </summary>
        [DataMember(Name="Locations", EmitDefaultValue=false)]
        public int? Locations { get; set; }

        /// <summary>
        /// Number of minutes used to calculate the tax (for per-minute tax calculations).
        /// </summary>
        [DataMember(Name="Minutes", EmitDefaultValue=false)]
        public double? Minutes { get; set; }
  
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
