using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Tax information returned from tax calculation APIs.
    /// </summary>
    [DataContract]
    public partial class TaxData
    {
        /// <summary>
        /// Adjustmnet type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid adjustment types.
        /// </summary>
        [DataMember(Name="AdjustmentType", EmitDefaultValue=false)]
        public int? AdjustmentType { get; set; }

        /// <summary>
        /// Indicates if the tax is billable to the customer.
        /// </summary>
        /// <value>Indicates if the tax is billable to the customer.</value>
        [DataMember(Name="Billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Calculation type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid calculation types.
        /// </summary>
        [DataMember(Name="CalculationType", EmitDefaultValue=false)]
        public int? CalculationType { get; set; }

        /// <summary>
        /// Tax Category Description.
        /// </summary>
        [DataMember(Name="CategoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Tax category ID.
        /// </summary>
        [DataMember(Name="CategoryID", EmitDefaultValue=false)]
        public int? CategoryID { get; set; }

        /// <summary>
        /// Customer identifier from transaction input.
        /// </summary>
        [DataMember(Name="CompanyIdentifier", EmitDefaultValue=false)]
        public string CompanyIdentifier { get; set; }

        /// <summary>
        /// Indicates if the tax is reportable to the jurisdiction.
        /// </summary>
        [DataMember(Name="Compliance", EmitDefaultValue=false)]
        public bool? Compliance { get; set; }

        /// <summary>
        /// User-defined customer number.
        /// </summary>
        [DataMember(Name="CustomerNumber", EmitDefaultValue=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Tax description.
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Exemption type from transaction input. See the CommsPlatform.API.WrapperClasses 
        /// User's Manual for a list of valid exemption types.
        /// </summary>
        [DataMember(Name="ExemptionType", EmitDefaultValue=false)]
        public int? ExemptionType { get; set; }

        /// <summary>
        /// Amount of the charge exempt from taxes.
        /// </summary>
        [DataMember(Name="ExemptSaleAmount", EmitDefaultValue=false)]
        public double? ExemptSaleAmount { get; set; }

        /// <summary>
        /// User-defined invoice number.
        /// </summary>
        [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
        public int? InvoiceNumber { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional", EmitDefaultValue=false)]
        public int? Optional { get; set; }

        /// <summary>
        /// Optional user-defined string value.
        /// </summary>
        [DataMember(Name="OptionalAlpha1", EmitDefaultValue=false)]
        public string OptionalAlpha1 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional4", EmitDefaultValue=false)]
        public int? Optional4 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional5", EmitDefaultValue=false)]
        public int? Optional5 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional6", EmitDefaultValue=false)]
        public int? Optional6 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary
        [DataMember(Name="Optional7", EmitDefaultValue=false)]
        public int? Optional7 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional8", EmitDefaultValue=false)]
        public int? Optional8 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional9", EmitDefaultValue=false)]
        public int? Optional9 { get; set; }

        /// <summary>
        /// Optional user-defined value.
        /// </summary>
        [DataMember(Name="Optional10", EmitDefaultValue=false)]
        public int? Optional10 { get; set; }

        /// <summary>
        /// PCode for the reporting jurisdiction.
        /// </summary>
        [DataMember(Name="PCode", EmitDefaultValue=false)]
        public int? PCode { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        [DataMember(Name="Rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }

        /// <summary>
        /// Taxable measure if tax is smaller than 0 (tax adjustments).
        /// </summary>
        [DataMember(Name="RefundUncollect", EmitDefaultValue=false)]
        public double? RefundUncollect { get; set; }

        /// <summary>
        /// User-defined service level number.
        /// </summary>
        [DataMember(Name="ServiceLevelNumber", EmitDefaultValue=false)]
        public int? ServiceLevelNumber { get; set; }

        /// <summary>
        /// Indicates if tax is considered a surcharge.
        /// </summary>
        [DataMember(Name="Surcharge", EmitDefaultValue=false)]
        public bool? Surcharge { get; set; }

        /// <summary>
        /// Amount of sale subject to tax plus any taxed taxes.
        /// </summary>
        [DataMember(Name="TaxableMeasure", EmitDefaultValue=false)]
        public double? TaxableMeasure { get; set; }

        /// <summary>
        /// Calculated tax amount.
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
        /// </summary>
        [DataMember(Name="TaxLevel", EmitDefaultValue=false)]
        public int? TaxLevel { get; set; }

        /// <summary>
        /// Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public int? TaxType { get; set; }

        /// <summary>
        /// Number of lines used to calculate the tax (for per-line tax calculations).
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public int? Lines { get; set; }

        /// <summary>
        /// Number of locations from transaction input.
        /// </summary>
        [DataMember(Name="Locations", EmitDefaultValue=false)]
        public int? Locations { get; set; }

        /// <summary>
        /// Number of minutes used to calculate the tax (for per-minute tax calculations).
        /// </summary>
        [DataMember(Name="Minutes", EmitDefaultValue=false)]
        public double? Minutes { get; set; }

        /// <summary>
        /// User-defined list of optional alphanumeric fields.
        /// </summary>
        [DataMember(Name="OptionalFields", EmitDefaultValue=false)]
        public List<OptionalField> OptionalFields { get; set; }

        /// <summary>
        /// Transaction charge amount.
        /// </summary>
        [DataMember(Name="TransCharge", EmitDefaultValue=false)]
        public double? TransCharge { get; set; }
  
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
