using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Contains data required for performing tax calculations on bridge conference transactions.
    /// </summary>
    [DataContract]
    public partial class BridgeConferenceTransaction
    {
        /// <summary>
        /// Flag indicating whether invalid participant jurisdiction should cause the transaction to fail (false)
        /// or whether the participant should be processed with greatest tax liability (true).
        /// </summary>
        [DataMember(Name="ProcessInvalidParticipant", EmitDefaultValue=false)]
        public bool? ProcessInvalidParticipant { get; set; }

        /// <summary>
        /// Indicates whether individual participant taxes should be returned in the response.
        /// </summary>
        [DataMember(Name="ReturnParticipantTaxes", EmitDefaultValue=false)]
        public bool? ReturnParticipantTaxes { get; set; }

        /// <summary>
        /// PCode for billing.
        /// </summary>
        [DataMember(Name="BillingPCode", EmitDefaultValue=false)]
        public int? BillingPCode { get; set; }

        /// <summary>
        /// PCode for bridge.
        /// </summary>
        [DataMember(Name="BridgePCode", EmitDefaultValue=false)]
        public int? BridgePCode { get; set; }

        /// <summary>
        /// PCode for host.
        /// </summary>
        [DataMember(Name="HostPCode", EmitDefaultValue=false)]
        public int? HostPCode { get; set; }

        /// <summary>
        /// NPANXX for billing.
        /// </summary>
        [DataMember(Name="BillingNpaNxx", EmitDefaultValue=false)]
        public int? BillingNpaNxx { get; set; }

        /// <summary>
        /// NPANXX for bridge.
        /// </summary>
        [DataMember(Name="BridgeNpaNxx", EmitDefaultValue=false)]
        public int? BridgeNpaNxx { get; set; }

        /// <summary>
        /// NPANXX for host.
        /// </summary>
        [DataMember(Name="HostNpaNxx", EmitDefaultValue=false)]
        public int? HostNpaNxx { get; set; }

        /// <summary>
        /// Billing address.
        /// </summary>
        [DataMember(Name="BillingAddress", EmitDefaultValue=false)]
        public ZipAddress BillingAddress { get; set; }

        /// <summary>
        /// Bridge address.
        /// </summary>
        [DataMember(Name="BridgeAddress", EmitDefaultValue=false)]
        public ZipAddress BridgeAddress { get; set; }

        /// <summary>
        /// Host address.
        /// </summary>
        [DataMember(Name="HostAddress", EmitDefaultValue=false)]
        public ZipAddress HostAddress { get; set; }

        /// <summary>
        /// List of bridge conference participants.
        /// </summary>
        [DataMember(Name="Participants", EmitDefaultValue=false)]
        public List<BridgeConferenceParticipant> Participants { get; set; }

        /// <summary>
        /// See the CommsPlatform.API.WrapperClasses User's Manual for valid customer types.
        /// </summary>
        [DataMember(Name="CustomerType", EmitDefaultValue=false)]
        public int? CustomerType { get; set; }

        /// <summary>
        /// See the CommsPlatform.API.WrapperClasses User's Manual for valid business classes.
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
        /// Service class. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid service classes.
        /// </summary>
        [DataMember(Name="ServiceClass", EmitDefaultValue=false)]
        public int? ServiceClass { get; set; }

        /// <summary>
        /// Transaction date. Field is provided to allow rating and taxing to occur on a date other than the billing date.
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Charge amount to customer for transaction.
        /// </summary>
        [DataMember(Name="Charge", EmitDefaultValue=false)]
        public double? Charge { get; set; }

        /// <summary>
        /// True if this transaction is within an incorporated area of the local jurisdiction, otherwise false.
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
        /// Exemption type. See the CommsPlatform.API.WrapperClasses User's Manual for a list of valid exemption types.
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
        /// See the CommsPlatform.API.WrapperClasses User's Manual for valid discount types.
        /// </summary>
        [DataMember(Name="DiscountType", EmitDefaultValue=false)]
        public int? DiscountType { get; set; }

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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
