using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Transaction data required for processing tax calculations.
    /// </summary>
    [DataContract]
    public partial class Transaction
    {
        /// <summary>
        /// Origination address.
        /// </summary>
        [DataMember(Name="OriginationAddress", EmitDefaultValue=false)]
        public ZipAddress OriginationAddress { get; set; }

        /// <summary>
        /// Origination FIPS code.
        /// </summary>
        [DataMember(Name="OriginationFipsCode", EmitDefaultValue=false)]
        public string OriginationFipsCode { get; set; }

        /// <summary>
        /// Origination PCode.
        /// </summary>
        [DataMember(Name="OriginationPCode", EmitDefaultValue=false)]
        public int? OriginationPCode { get; set; }

        /// <summary>
        /// Origination NPANXX.
        /// </summary>
        [DataMember(Name="OriginationNpaNxx", EmitDefaultValue=false)]
        public int? OriginationNpaNxx { get; set; }

        /// <summary>
        /// Termination address.
        /// </summary>
        [DataMember(Name="TerminationAddress", EmitDefaultValue=false)]
        public ZipAddress TerminationAddress { get; set; }

        /// <summary>
        /// Termination FIPS code.
        /// </summary>
        [DataMember(Name="TerminationFipsCode", EmitDefaultValue=false)]
        public string TerminationFipsCode { get; set; }

        /// <summary>
        /// Termination PCode.
        /// </summary>
        [DataMember(Name="TerminationPCode", EmitDefaultValue=false)]
        public int? TerminationPCode { get; set; }

        /// <summary>
        /// Termination NPANXX.
        /// </summary>
        [DataMember(Name="TerminationNpaNxx", EmitDefaultValue=false)]
        public int? TerminationNpaNxx { get; set; }

        /// <summary>
        /// Bill-to address.
        /// </summary>
        [DataMember(Name="BillToAddress", EmitDefaultValue=false)]
        public ZipAddress BillToAddress { get; set; }

        /// <summary>
        /// Bill-to FIPS code.
        /// </summary>
        [DataMember(Name="BillToFipsCode", EmitDefaultValue=false)]
        public string BillToFipsCode { get; set; }

        /// <summary>
        /// Bill-to PCode.
        /// </summary>
        [DataMember(Name="BillToPCode", EmitDefaultValue=false)]
        public int? BillToPCode { get; set; }

        /// <summary>
        /// Bill-to NPANXX
        /// </summary>
        [DataMember(Name="BillToNpaNxx", EmitDefaultValue=false)]
        public int? BillToNpaNxx { get; set; }

        /// <summary>
        /// Indicates if the transaction is a private line transaction.
        /// </summary>
        [DataMember(Name="IsPrivateLine", EmitDefaultValue=false)]
        public bool? IsPrivateLine { get; set; }

        /// <summary>
        /// For private line transactions, this is the split between the ending points of a private line.
        /// The value indicates how much the portion of the charge belongs to the origin user.
        /// </summary>
        [DataMember(Name="PrivateLineSplit", EmitDefaultValue=false)]
        public double? PrivateLineSplit { get; set; }

        /// <summary>
        /// Customer type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid customer types.
        /// </summary>
        [DataMember(Name="CustomerType", EmitDefaultValue=false)]
        public int? CustomerType { get; set; }

        /// <summary>
        /// Business class. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid business classes.
        /// </summary>
        [DataMember(Name="BusinessClass", EmitDefaultValue=false)]
        public int? BusinessClass { get; set; }

        /// <summary>
        /// Indicates if this is a retail sale. Use false for resale/wholesale transactions.
        /// </summary>
        [DataMember(Name="Sale", EmitDefaultValue=false)]
        public bool? Sale { get; set; }

        /// <summary>
        /// Transaction type.
        /// </summary>
        [DataMember(Name="TransactionType", EmitDefaultValue=false)]
        public int? TransactionType { get; set; }

        /// <summary>
        /// Service type.
        /// </summary>
        [DataMember(Name="ServiceType", EmitDefaultValue=false)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// Service class. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid Service Classes
        /// </summary>
        [DataMember(Name="ServiceClass", EmitDefaultValue=false)]
        public int? ServiceClass { get; set; }

        /// <summary>
        /// Transaction date.  Field is provided to allow rating and taxing to occur on a date other than the billing date.
        /// </summary>>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Charge amount to customer for transaction
        /// </summary>
        [DataMember(Name="Charge", EmitDefaultValue=false)]
        public double? Charge { get; set; }

        /// <summary>
        /// True if this transaction is within an incorporated area of the local jurisdiction, otherwise False.
        /// </summary>
        [DataMember(Name="Incorporated", EmitDefaultValue=false)]
        public bool? Incorporated { get; set; }

        /// <summary>
        /// True if transaction is exempt from Federal Tax, otherwise false.
        /// </summary>
        [DataMember(Name="FederalExempt", EmitDefaultValue=false)]
        public bool? FederalExempt { get; set; }

        /// <summary>
        /// True if transaction is exempt from State Tax, otherwise false.
        /// </summary>
        [DataMember(Name="StateExempt", EmitDefaultValue=false)]
        public bool? StateExempt { get; set; }

        /// <summary>
        /// True if transaction is exempt from County Tax, otherwise false.
        /// </summary>
        [DataMember(Name="CountyExempt", EmitDefaultValue=false)]
        public bool? CountyExempt { get; set; }

        /// <summary>
        /// True if transaction is exempt from Local Tax, otherwise false.
        /// </summary>
        [DataMember(Name="LocalExempt", EmitDefaultValue=false)]
        public bool? LocalExempt { get; set; }

        /// <summary>
        /// Jurisdiction for Federal exemption.
        /// </summary>
        [DataMember(Name="FederalPCode", EmitDefaultValue=false)]
        public int? FederalPCode { get; set; }

        /// <summary>
        /// Jurisdiction for state exemption.
        /// </summary>
        [DataMember(Name="StatePCode", EmitDefaultValue=false)]
        public int? StatePCode { get; set; }

        /// <summary>
        /// Jurisdiction for county exemption.
        /// </summary>
        [DataMember(Name="CountyPCode", EmitDefaultValue=false)]
        public int? CountyPCode { get; set; }

        /// <summary>
        /// Jurisdiction for local exemption.
        /// </summary>
        [DataMember(Name="LocalPCode", EmitDefaultValue=false)]
        public int? LocalPCode { get; set; }

        /// <summary>
        /// List of tax exemptions.
        /// </summary>
        [DataMember(Name="Exemptions", EmitDefaultValue=false)]
        public List<TaxExemption> Exemptions { get; set; }

        /// <summary>
        /// Exemtion type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid exemption types.
        /// </summary>
        [DataMember(Name="ExemptionType", EmitDefaultValue=false)]
        public int? ExemptionType { get; set; }

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
        /// User-defined customer number.
        /// </summary>
        [DataMember(Name="CustomerNumber", EmitDefaultValue=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Company identifier. Use the 3-character company identifier provided by Avalara to your organization
        /// in order to include this transaction in the monthly compliance reports. Otherwise, leave empty.
        /// </summary>
        [DataMember(Name="CompanyIdentifier", EmitDefaultValue=false)]
        public string CompanyIdentifier { get; set; }

        /// <summary>
        /// Optional user-defined string value. 20-characters max.
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
        /// </summary>
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
        /// Adjustment method. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid adjustment methods.
        /// </summary>
        [DataMember(Name="AdjustmentMethod", EmitDefaultValue=false)]
        public int? AdjustmentMethod { get; set; }

        /// <summary>
        /// Number of lines sold to customer when applicable.
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public int? Lines { get; set; }

        /// <summary>
        /// Number of customer locations.
        /// </summary>
        [DataMember(Name="Locations", EmitDefaultValue=false)]
        public int? Locations { get; set; }

        /// <summary>
        /// Number of minutes for call when appropriate.
        /// </summary>
        [DataMember(Name="Minutes", EmitDefaultValue=false)]
        public double? Minutes { get; set; }

        /// <summary>
        /// Determines if this is a prepaid debit card transaction.
        /// </summary>
        [DataMember(Name="Debit", EmitDefaultValue=false)]
        public bool? Debit { get; set; }

        /// <summary>
        /// Discount type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid discount types.
        /// </summary>
        [DataMember(Name= "AdjustmentDiscount", EmitDefaultValue=false)]
        public int? AdjustmentDiscount { get; set; }

        /// <summary>
        /// Specifies if the carrier delivering the service has company owned facilities to provide the service.
        /// </summary>
        [DataMember(Name="FacilitiesBased", EmitDefaultValue=false)]
        public bool? FacilitiesBased { get; set; }

        /// <summary>
        /// Indicates if the company provides services sold pursuant to a franchise agreement between the carrier and jurisdiction.
        /// </summary>
        [DataMember(Name="Franchise", EmitDefaultValue=false)]
        public bool? Franchise { get; set; }

        /// <summary>
        /// Indicates if customer is a Lifeline participant.
        /// </summary>
        [DataMember(Name="Lifeline", EmitDefaultValue=false)]
        public bool? Lifeline { get; set; }

        /// <summary>
        /// True if regulated, otherwise false.
        /// </summary>
        [DataMember(Name="Regulated", EmitDefaultValue=false)]
        public bool? Regulated { get; set; }

        /// <summary>
        /// User-defined service level number.
        /// </summary>
        [DataMember(Name="ServiceLevelNumber", EmitDefaultValue=false)]
        public int? ServiceLevelNumber { get; set; }

        /// <summary>
        /// List of states for tax exclusions.
        /// </summary>
        [DataMember(Name="Exclusions", EmitDefaultValue=false)]
        public List<Exclusion> Exclusions { get; set; }

        /// <summary>
        /// List of tax category exemptions.
        /// </summary>
        [DataMember(Name="CategoryExemptions", EmitDefaultValue=false)]
        public List<CategoryExemption> CategoryExemptions { get; set; }

        /// <summary>
        /// User-defined list of optional alphanumeric fields.
        /// </summary>
        [DataMember(Name="OptionalFields", EmitDefaultValue=false)]
        public List<OptionalField> OptionalFields { get; set; }

        /// <summary>
        /// Indicates if the charge of this transaction is tax-inclusive (reverse tax calculation).
        /// </summary>
        [DataMember(Name="TaxInclusive", EmitDefaultValue=false)]
        public bool? TaxInclusive { get; set; }
  
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
