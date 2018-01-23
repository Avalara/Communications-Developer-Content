/**
 * Contains data required for performing tax calculations on bridge conference
 * transactions.
 */

function BridgeConferenceTransaction() {

    this.ProcessInvalidParticipant = false;
    this.ReturnParticipantTaxes = false;
    this.BillingPCode = null;
    this.BridgePCode = null;
    this.HostPCode = null;
    this.BillingNpaNxx = null;
    this.BridgeNpaNxx = null;
    this.HostNpaNxx = null;
    this.BillingAddress = null;
    this.BridgeAddress = null;
    this.HostAddress = null;
    this.Participants = [];
    this.CustomerType = 0;
    this.BusinessClass = 0;
    this.Sale = false;
    this.TransactionType = 0;
    this.ServiceType = 0;
    this.ServiceClass = 0;
    this.Date = new Date(0);
    this.Charge = 0;
    this.Incorporated = false;
    this.FederalExempt = false;
    this.StateExempt = false;
    this.CountyExempt = false;
    this.LocalExempt = false;
    this.FederalPCode = 0;
    this.StatePCode = 0;
    this.CountyPCode = 0;
    this.LocalPCode = 0;
    this.Exemptions = [];
    this.ExemptionType = 0;
    this.InvoiceNumber = 0;
    this.Optional = 0;
    this.CustomerNumber = "";
    this.CompanyIdentifier = "";
    this.OptionalAlpha1 = "";
    this.Optional4 = 0;
    this.Optional5 = 0;
    this.Optional6 = 0;
    this.Optional7 = 0;
    this.Optional8 = 0;
    this.Optional9 = 0;
    this.Optional10 = 0;
    this.AdjustmentMethod = 0;
    this.Lines = 0;
    this.Locations = 0;
    this.Minutes = 0;
    this.Debit = false;
    this.DiscountType = 0;
    this.FacilitiesBased = false;
    this.Franchise = false;
    this.Lifeline = false;
    this.Regulated = false;
    this.ServiceLevelNumber = 0;
    this.Exclusions = [];
    this.CategoryExemptions = [];
    this.OptionalFields = [];

    /**
     * Sets a value indicating whether invalid participant jurisdiction should 
     * cause the transaction to fail (false) or whether the participant should be
     * processed with greatest tax liability (true).
     * @param processInvalidParticipant Boolean
     * @return Reference to this object for method chaining. 
     */
    this.processInvalidParticipant = function (processInvalidParticipant) {
        this.ProcessInvalidParticipant = processInvalidParticipant;
        return this;
    }

    /**
     * Flag indicating whether invalid participant jurisdiction should cause the
     * transaction to fail (false) or whether the participant should be
     * processed with greatest tax liability (true).
     * @return Boolean
     */
    this.getProcessInvalidParticipant = function () {
        return this.ProcessInvalidParticipant;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating whether invalid participant jurisdiction should 
     * cause the transaction to fail (false) or whether the participant should be
     * processed with greatest tax liability (true).
     * @param processInvalidParticipant Boolean 
     */
    this.setProcessInvalidParticipant = function (processInvalidParticipant) {
        this.ProcessInvalidParticipant = processInvalidParticipant;
    }

    /**
     * Sets a value indicating whether individual participant taxes should be 
     * returned in the response.
     * @param returnParticipantTaxes Boolean
     * @return Reference to this object for method chaining. 
     */
    this.returnParticipantTaxes = function (returnParticipantTaxes) {
        this.ReturnParticipantTaxes = returnParticipantTaxes;
        return this;
    }

    /**
     * Indicates whether individual participant taxes should be returned in the
     * response.
     * @return Boolean
     */
    this.getReturnParticipantTaxes = function () {
        return this.ReturnParticipantTaxes;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating whether individual participant taxes should be 
     * returned in the response.
     * @param returnParticipantTaxes Boolean 
     */
    this.setReturnParticipantTaxes = function (returnParticipantTaxes) {
        this.ReturnParticipantTaxes = returnParticipantTaxes;
    }

    /**
     * Sets the PCode for billing.
     * @param billingPCode Number
     * @return Reference to this object for method chaining. 
     */
    this.billingPCode = function (billingPCode) {
        this.BillingPCode = billingPCode;
        return this;
    }

    /**
     * PCode for billing.
     * @return Number
     */
    this.getBillingPCode = function () {
        return this.BillingPCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode for billing.
     * @param billingPCode Number 
     */
    this.setBillingPCode = function (billingPCode) {
        this.BillingPCode = billingPCode;
    }

    /**
     * Sets the PCode for bridge.
     * @param bridgePCode Number
     * @return Reference to this object for method chaining. 
     */
    this.bridgePCode = function (bridgePCode) {
        this.BridgePCode = bridgePCode;
        return this;
    }

    /**
     * PCode for bridge.
     * @return Number
     */
    this.getBridgePCode = function () {
        return this.BridgePCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode for bridge.
     * @param bridgePCode Number 
     */
    this.setBridgePCode = function (bridgePCode) {
        this.BridgePCode = bridgePCode;
    }

    /**
     * Sets the PCode for host.
     * @param hostPCode Number
     * @return Reference to this object for method chaining. 
     */
    this.hostPCode = function (hostPCode) {
        this.HostPCode = hostPCode;
        return this;
    }

    /**
     * PCode for host.
     * @return Number
     */
    this.getHostPCode = function () {
        return this.HostPCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode for host.
     * @param hostPCode Number 
     */
    this.setHostPCode = function (hostPCode) {
        this.HostPCode = hostPCode;
    }

    /**
     * Sets the NPANXX for billing.
     * @param billingNpaNxx Number
     * @return Reference to this object for method chaining. 
     */
    this.billingNpaNxx = function (billingNpaNxx) {
        this.BillingNpaNxx = billingNpaNxx;
        return this;
    }

    /**
     * NPANXX for billing.
     * @return Number
     */
    this.getBillingNpaNxx = function () {
        return this.BillingNpaNxx;
    }

    /* Reference to this object for method chaining.*
     * Sets the NPANXX for billing.
     * @param billingNpaNxx Number 
     */
    this.setBillingNpaNxx = function (billingNpaNxx) {
        this.BillingNpaNxx = billingNpaNxx;
    }

    /**
     * Sets the NPANXX for bridge.
     * @param bridgeNpaNxx Number
     * @return Reference to this object for method chaining. 
     */
    this.bridgeNpaNxx = function (bridgeNpaNxx) {
        this.BridgeNpaNxx = bridgeNpaNxx;
        return this;
    }

    /**
     * NPANXX for bridge.
     * @return Number
     */
    this.getBridgeNpaNxx = function () {
        return this.BridgeNpaNxx;
    }

    /* Reference to this object for method chaining.*
     * Sets the NPANXX for bridge.
     * @param bridgeNpaNxx Number 
     */
    this.setBridgeNpaNxx = function (bridgeNpaNxx) {
        this.BridgeNpaNxx = bridgeNpaNxx;
    }

    /**
     * Sets the NPANXX for host.
     * @param hostNpaNxx Number
     * @return Reference to this object for method chaining. 
     */
    this.hostNpaNxx = function (hostNpaNxx) {
        this.HostNpaNxx = hostNpaNxx;
        return this;
    }

    /**
     * NPANXX for host.
     * @return Number
     */
    this.getHostNpaNxx = function () {
        return this.HostNpaNxx;
    }

    /* Reference to this object for method chaining.*
     * Sets the NPANXX for host.
     * @param hostNpaNxx Number 
     */
    this.setHostNpaNxx = function (hostNpaNxx) {
        this.HostNpaNxx = hostNpaNxx;
    }

    /**
     * Sets the billing address.
     * @param billingAddress ZipAddress object.
     * @return Reference to this object for method chaining. 
     */
    this.billingAddress = function (billingAddress) {
        this.BillingAddress = billingAddress;
        return this;
    }

    /**
     * Billing address.
     * @return ZipAddress object.
     */
    this.getBillingAddress = function () {
        return this.BillingAddress;
    }

    /* Reference to this object for method chaining.*
     * Sets the billing address.
     * @param billingAddress ZipAddress object. 
     */
    this.setBillingAddress = function (billingAddress) {
        this.BillingAddress = billingAddress;
    }

    /**
     * Sets the bridge address.
     * @param bridgeAddress ZipAddress object.
     * @return Reference to this object for method chaining. 
     */
    this.bridgeAddress = function (bridgeAddress) {
        this.BridgeAddress = bridgeAddress;
        return this;
    }

    /**
     * Bridge address.
     * @return ZipAddress object.
     */
    this.getBridgeAddress = function () {
        return this.BridgeAddress;
    }

    /* Reference to this object for method chaining.*
     * Sets the bridge address.
     * @param bridgeAddress ZipAddress object. 
     */
    this.setBridgeAddress = function (bridgeAddress) {
        this.BridgeAddress = bridgeAddress;
    }

    /**
     * Sets the host address.
     * @param hostAddress ZipAddress object.
     * @return Reference to this object for method chaining. 
     */
    this.hostAddress = function (hostAddress) {
        this.HostAddress = hostAddress;
        return this;
    }

    /**
     * Host address.
     * @return ZipAddress object.
     */
    this.getHostAddress = function () {
        return this.HostAddress;
    }

    /* Reference to this object for method chaining.*
     * Sets the host address.
     * @param hostAddress ZipAddress object. 
     */
    this.setHostAddress = function (hostAddress) {
        this.HostAddress = hostAddress;
    }

    /**
     * Sets the list of bridge conference participants.
     * @param participants Array of BridgeConferenceParticipant
     * @return Reference to this object for method chaining. 
     */
    this.participants = function (participants) {
        this.Participants = participants;
        return this;
    }

    /**
     * Adds a bridge conference participant to this transaction.
     * @param participantsItem BridgeConferenceParticipant object.
     * @return Reference to this object for method chaining. 
     */
    this.addParticipant = function (participantsItem) {
        this.Participants.push(participantsItem);
        return this;
    }

    /**
     * List of bridge conference participants.
     * @return Array of BridgeConferenceParticipant
     */
    this.getParticipants = function () {
        return this.Participants;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of bridge conference participants.
     * @param participants Array of BridgeConferenceParticipant 
     */
    this.setParticipants = function (participants) {
        this.Participants = participants;
    }

    /**
     * Sets the customer type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid customer types.
     * @param customerType Number
     * @return Reference to this object for method chaining. 
     */
    this.customerType = function (customerType) {
        this.CustomerType = customerType;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid customer
     * types.
     * @return Number
     */
    this.getCustomerType = function () {
        return this.CustomerType;
    }

    /* Reference to this object for method chaining.*
     * Sets the customer type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid customer types.
     * @param customerType Number 
     */
    this.setCustomerType = function (customerType) {
        this.CustomerType = customerType;
    }

    /**
     * Sets the business class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid business classes.
     * @param businessClass Number
     * @return Reference to this object for method chaining. 
     */
    this.businessClass = function (businessClass) {
        this.BusinessClass = businessClass;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid business
     * classes.
     * @return Number
     */
    this.getBusinessClass = function () {
        return this.BusinessClass;
    }

    /* Reference to this object for method chaining.*
     * Sets the business class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid business classes.
     * @param businessClass Number 
     */
    this.setBusinessClass = function (businessClass) {
        this.BusinessClass = businessClass;
    }

    /**
     * Sets a value indicating if this is a retail sale. Use false for 
     * resale/wholesale transactions.
     * @param sale Boolean
     * @return Reference to this object for method chaining. 
     */
    this.sale = function (sale) {
        this.Sale = sale;
        return this;
    }

    /**
     * Indicates if this is a retail sale. Use false for resale/wholesale
     * transactions.
     * @return Boolean
     */
    this.getSale = function () {
        return this.Sale;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if this is a retail sale. Use false for 
     * resale/wholesale transactions.
     * @param sale Boolean 
     */
    this.setSale = function (sale) {
        this.Sale = sale;
    }

    /**
     * Sets the transaction type.
     * @param transactionType Number
     * @return Reference to this object for method chaining. 
     */
    this.transactionType = function (transactionType) {
        this.TransactionType = transactionType;
        return this;
    }

    /**
     * Transaction type.
     * @return Number
     */
    this.getTransactionType = function () {
        return this.TransactionType;
    }

    /* Reference to this object for method chaining.*
     * Sets the transaction type.
     * @param transactionType Number 
     */
    this.setTransactionType = function (transactionType) {
        this.TransactionType = transactionType;
    }

    /**
     * Sets the service type.
     * @param serviceType Number
     * @return Reference to this object for method chaining. 
     */
    this.serviceType = function (serviceType) {
        this.ServiceType = serviceType;
        return this;
    }

    /**
     * Service type.
     * @return Number
     */
    this.getServiceType = function () {
        return this.ServiceType;
    }

    /* Reference to this object for method chaining.*
     * Sets the service type.
     * @param serviceType Number 
     */
    this.setServiceType = function (serviceType) {
        this.ServiceType = serviceType;
    }

    /**
     * Sets the service class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid service classes.
     * @param serviceClass Number
     * @return Reference to this object for method chaining. 
     */
    this.serviceClass = function (serviceClass) {
        this.ServiceClass = serviceClass;
        return this;
    }

    /**
     * Service class. See the CommsPlatform.API.WrapperClasses User's Manual for
     * a list of valid service classes.
     * @return Number
     */
    this.getServiceClass = function () {
        return this.ServiceClass;
    }

    /* Reference to this object for method chaining.*
     * Sets the service class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid service classes.
     * @param serviceClass Number 
     */
    this.setServiceClass = function (serviceClass) {
        this.ServiceClass = serviceClass;
    }

    /**
     * Sets the transaction date. Field is provided to allow rating and taxing 
     * to occur on a date other than the billing date.
     * @param date Date
     * @return Reference to this object for method chaining. 
     */
    this.date = function (date) {
        this.Date = date;
        return this;
    }

    /**
     * Transaction date. Field is provided to allow rating and taxing to occur
     * on a date other than the billing date.
     * @return Date
     */
    this.getDate = function () {
        return this.Date;
    }

    /* Reference to this object for method chaining.*
     * Sets the transaction date. Field is provided to allow rating and taxing 
     * to occur on a date other than the billing date.
     * @param date Date 
     */
    this.setDate = function (date) {
        this.Date = date;
    }

    /**
     * Sets the charge amount to customer for transaction.
     * @param charge Number
     * @return Reference to this object for method chaining. 
     */
    this.charge = function (charge) {
        this.Charge = charge;
        return this;
    }

    /**
     * Charge amount to customer for transaction.
     * @return Number
     */
    this.getCharge = function () {
        return this.Charge;
    }

    /* Reference to this object for method chaining.*
     * Sets the charge amount to customer for transaction.
     * @param charge Number 
     */
    this.setCharge = function (charge) {
        this.Charge = charge;
    }

    /**
     * Sets a value indicating if this transaction is within an incorporated 
     * area of the local jurisdiction, otherwise false.
     * @param incorporated Boolean
     * @return Reference to this object for method chaining. 
     */
    this.incorporated = function (incorporated) {
        this.Incorporated = incorporated;
        return this;
    }

    /**
     * True if this transaction is within an incorporated area of the local
     * jurisdiction, otherwise false.
     * @return Boolean
     */
    this.getIncorporated = function () {
        return this.Incorporated;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if this transaction is within an incorporated 
     * area of the local jurisdiction, otherwise false.
     * @param incorporated Boolean 
     */
    this.setIncorporated = function (incorporated) {
        this.Incorporated = incorporated;
    }

    /**
     * Sets a value indicating if transaction is exempt from Federal tax.
     * @param federalExempt Boolean
     * @return Reference to this object for method chaining. 
     */
    this.federalExempt = function (federalExempt) {
        this.FederalExempt = federalExempt;
        return this;
    }

    /**
     * True if transaction is exempt from Federal tax, otherwise false.
     * @return Boolean
     */
    this.getFederalExempt = function () {
        return this.FederalExempt;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if transaction is exempt from Federal tax.
     * @param federalExempt Boolean 
     */
    this.setFederalExempt = function (federalExempt) {
        this.FederalExempt = federalExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from state tax.
     * @param stateExempt Boolean
     * @return Reference to this object for method chaining. 
     */
    this.stateExempt = function (stateExempt) {
        this.StateExempt = stateExempt;
        return this;
    }

    /**
     * True if transaction is exempt from state tax, otherwise false.
     * @return Boolean
     */
    this.getStateExempt = function () {
        return this.StateExempt;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if transaction is exempt from state tax.
     * @param stateExempt Boolean 
     */
    this.setStateExempt = function (stateExempt) {
        this.StateExempt = stateExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from county tax.
     * @param countyExempt Boolean
     * @return Reference to this object for method chaining. 
     */
    this.countyExempt = function (countyExempt) {
        this.CountyExempt = countyExempt;
        return this;
    }

    /**
     * True if transaction is exempt from county tax, otherwise false.
     * @return Boolean
     */
    this.getCountyExempt = function () {
        return this.CountyExempt;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if transaction is exempt from county tax.
     * @param countyExempt Boolean
     */
    this.setCountyExempt = function (countyExempt) {
        this.CountyExempt = countyExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from local Tax.
     * @param localExempt Boolean
     * @return Reference to this object for method chaining. 
     */
    this.localExempt = function (localExempt) {
        this.LocalExempt = localExempt;
        return this;
    }

    /**
     * True if transaction is exempt from local tax, otherwise false.
     * @return Boolean
     */
    this.getLocalExempt = function () {
        return this.LocalExempt;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if transaction is exempt from local Tax.
     * @param localExempt Boolean 
     */
    this.setLocalExempt = function (localExempt) {
        this.LocalExempt = localExempt;
    }

    /**
     * Sets the jurisdiction for Federal exemption.
     * @param federalPCode Number
     * @return Reference to this object for method chaining. 
     */
    this.federalPCode = function (federalPCode) {
        this.FederalPCode = federalPCode;
        return this;
    }

    /**
     * Jurisdiction for Federal exemption.
     * @return Number
     */
    this.getFederalPCode = function () {
        return this.FederalPCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the jurisdiction for Federal exemption.
     * @param federalPCode Number 
     */
    this.setFederalPCode = function (federalPCode) {
        this.FederalPCode = federalPCode;
    }

    /**
     * Sets the jurisdiction for state exemption.
     * @param statePCode Number
     * @return Reference to this object for method chaining. 
     */
    this.statePCode = function (statePCode) {
        this.StatePCode = statePCode;
        return this;
    }

    /**
     * Jurisdiction for state exemption.
     * @return Number
     */
    this.getStatePCode = function () {
        return this.StatePCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the jurisdiction for state exemption.
     * @param statePCode Number 
     */
    this.setStatePCode = function (statePCode) {
        this.StatePCode = statePCode;
    }

    /**
     * Sets the jurisdiction for county exemption.
     * @param countyPCode Number
     * @return Reference to this object for method chaining. 
     */
    this.countyPCode = function (countyPCode) {
        this.CountyPCode = countyPCode;
        return this;
    }

    /**
     * Jurisdiction for county exemption.
     * @return Number
     */
    this.getCountyPCode = function () {
        return this.CountyPCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the jurisdiction for county exemption.
     * @param countyPCode Number 
     */
    this.setCountyPCode = function (countyPCode) {
        this.CountyPCode = countyPCode;
    }

    /**
     * Sets the jurisdiction for local exemption.
     * @param localPCode Number
     * @return Reference to this object for method chaining. 
     */
    this.localPCode = function (localPCode) {
        this.LocalPCode = localPCode;
        return this;
    }

    /**
     * Jurisdiction for local exemption.
     * @return Number
     */
    this.getLocalPCode = function () {
        return this.LocalPCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the jurisdiction for local exemption.
     * @param localPCode Number 
     */
    this.setLocalPCode = function (localPCode) {
        this.LocalPCode = localPCode;
    }

    /**
     * Sets the list of tax exemptions.
     * @param exemptions Array of TaxExemption
     * @return Reference to this object for method chaining. 
     */
    this.exemptions = function (exemptions) {
        this.Exemptions = exemptions;
        return this;
    }

    /**
     * Adds a tax exemption to this transaction.
     * @param exemptionsItem TaxExemption object.
     * @return Reference to this object for method chaining. 
     */
    this.addExemptionsItem = function (exemptionsItem) {
        this.Exemptions.push(exemptionsItem);
        return this;
    }

    /**
     * List of tax exemptions.
     * @return Array of TaxExemption
     */
    this.getExemptions = function () {
        return this.Exemptions;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of tax exemptions.
     * @param exemptions Array of TaxExemption 
     */
    this.setExemptions = function (exemptions) {
        this.Exemptions = exemptions;
    }

    /**
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType Number
     * @return Reference to this object for method chaining. 
     */
    this.exemptionType = function (exemptionType) {
        this.ExemptionType = exemptionType;
        return this;
    }

    /**
     * Exemption type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid exemption types.
     * @return Number
     */
    this.getExemptionType = function () {
        return this.ExemptionType;
    }

    /* Reference to this object for method chaining.*
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType Number 
     */
    this.setExemptionType = function (exemptionType) {
        this.ExemptionType = exemptionType;
    }

    /**
     * Sets a user-defined invoice number.
     * @param invoiceNumber Number
     * @return Reference to this object for method chaining. 
     */
    this.invoiceNumber = function (invoiceNumber) {
        this.InvoiceNumber = invoiceNumber;
        return this;
    }

    /**
     * User-defined invoice number.
     * @return Number
     */
    this.getInvoiceNumber = function () {
        return this.InvoiceNumber;
    }

    /* Reference to this object for method chaining.*
     * Sets a user-defined invoice number.
     * @param invoiceNumber Number 
     */
    this.setInvoiceNumber = function (invoiceNumber) {
        this.InvoiceNumber = invoiceNumber;
    }

    /**
     * Sets a user-defined optional value.
     * @param optional Number
     * @return Reference to this object for method chaining. 
     */
    this.optional = function (optional) {
        this.Optional = optional;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional = function () {
        return this.Optional;
    }

    /* Reference to this object for method chaining.*
     * Sets a user-defined optional value.
     * @param optional Number 
     */
    this.setOptional = function (optional) {
        this.Optional = optional;
    }

    /**
     * Sets a user-defined customer number.
     * @param customerNumber String
     * @return Reference to this object for method chaining. 
     */
    this.customerNumber = function (customerNumber) {
        this.CustomerNumber = customerNumber;
        return this;
    }

    /**
     * User-defined customer number.
     * @return String
     */
    this.getCustomerNumber = function () {
        return this.CustomerNumber;
    }

    /* Reference to this object for method chaining.*
     * Sets a user-defined customer number.
     * @param customerNumber String 
     */
    this.setCustomerNumber = function (customerNumber) {
        this.CustomerNumber = customerNumber;
    }

    /**
     * Sets the company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     * @param companyIdentifier String
     * @return Reference to this object for method chaining. 
     */
    this.companyIdentifier = function (companyIdentifier) {
        this.CompanyIdentifier = companyIdentifier;
        return this;
    }

    /**
     * Company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     * @return String
     */
    this.getCompanyIdentifier = function () {
        return this.CompanyIdentifier;
    }

    /* Reference to this object for method chaining.*
     * Sets the company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     * @param companyIdentifier String 
     */
    this.setCompanyIdentifier = function (companyIdentifier) {
        this.CompanyIdentifier = companyIdentifier;
    }

    /**
     * Sets an optional user-defined string value.
     * @param optionalAlpha1 String
     * @return Reference to this object for method chaining. 
     */
    this.optionalAlpha1 = function (optionalAlpha1) {
        this.OptionalAlpha1 = optionalAlpha1;
        return this;
    }

    /**
     * Optional user-defined string value.
     * @return String
     */
    this.getOptionalAlpha1 = function () {
        return this.OptionalAlpha1;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined string value.
     * @param optionalAlpha1 String 
     */
    this.setOptionalAlpha1 = function (optionalAlpha1) {
        this.OptionalAlpha1 = optionalAlpha1;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional4 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional4 = function (optional4) {
        this.Optional4 = optional4;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional4 = function () {
        return this.Optional4;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional4 Number 
     */
    this.setOptional4 = function (optional4) {
        this.Optional4 = optional4;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional5 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional5 = function (optional5) {
        this.Optional5 = optional5;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional5 = function () {
        return this.Optional5;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional5 Number 
     */
    this.setOptional5 = function (optional5) {
        this.Optional5 = optional5;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional6 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional6 = function (optional6) {
        this.Optional6 = optional6;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional6 = function () {
        return this.Optional6;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional6 Number 
     */
    this.setOptional6 = function (optional6) {
        this.Optional6 = optional6;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional7 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional7 = function (optional7) {
        this.Optional7 = optional7;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional7 = function () {
        return this.Optional7;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional7 Number 
     */
    this.setOptional7 = function (optional7) {
        this.Optional7 = optional7;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional8 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional8 = function (optional8) {
        this.Optional8 = optional8;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional8 = function () {
        return this.Optional8;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional8 Number 
     */
    this.setOptional8 = function (optional8) {
        this.Optional8 = optional8;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional9 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional9 = function (optional9) {
        this.Optional9 = optional9;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional9 = function () {
        return this.Optional9;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional9 Number 
     */
    this.setOptional9 = function (optional9) {
        this.Optional9 = optional9;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional10 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional10 = function (optional10) {
        this.Optional10 = optional10;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional10 = function () {
        return this.Optional10;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional10 Number 
     */
    this.setOptional10 = function (optional10) {
        this.Optional10 = optional10;
    }

    /**
     * Sets the adjustment method. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment methods.
     * @param adjustmentMethod Number
     * @return Reference to this object for method chaining. 
     */
    this.adjustmentMethod = function (adjustmentMethod) {
        this.AdjustmentMethod = adjustmentMethod;
        return this;
    }

    /**
     * Adjustment method. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid adjustment methods.
     * @return Number
     */
    this.getAdjustmentMethod = function () {
        return this.AdjustmentMethod;
    }

    /* Reference to this object for method chaining.*
     * Sets the adjustment method. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment methods.
     * @param adjustmentMethod Number 
     */
    this.setAdjustmentMethod = function (adjustmentMethod) {
        this.AdjustmentMethod = adjustmentMethod;
    }

    /**
     * Sets the number of lines sold to customer when applicable.
     * @param lines Number
     * @return Reference to this object for method chaining. 
     */
    this.lines = function (lines) {
        this.Lines = lines;
        return this;
    }

    /**
     * Number of lines sold to customer when applicable.
     * @return Number
     */
    this.getLines = function () {
        return this.Lines;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of lines sold to customer when applicable.
     * @param lines Number 
     */
    this.setLines = function (lines) {
        this.Lines = lines;
    }

    /**
     * Sets the number of customer locations.
     * @param locations Number
     * @return Reference to this object for method chaining. 
     */
    this.locations = function (locations) {
        this.Locations = locations;
        return this;
    }

    /**
     * Number of customer locations.
     * @return Number
     */
    this.getLocations = function () {
        return this.Locations;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of customer locations.
     * @param locations Number 
     */
    this.setLocations = function (locations) {
        this.Locations = locations;
    }

    /**
     * Sets the number of minutes for call.
     * @param minutes Number
     * @return Reference to this object for method chaining. 
     */
    this.minutes = function (minutes) {
        this.Minutes = minutes;
        return this;
    }

    /**
     * Number of minutes for call when appropriate.
     * @return Number
     */
    this.getMinutes = function () {
        return this.Minutes;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of minutes for call.
     * @param minutes Number 
     */
    this.setMinutes = function (minutes) {
        this.Minutes = minutes;
    }

    /**
     * Sets a value indicating if this is a prepaid debit card transaction.
     * @param debit Boolean
     * @return Reference to this object for method chaining. 
     */
    this.debit = function (debit) {
        this.Debit = debit;
        return this;
    }

    /**
     * Determines if this is a prepaid debit card transaction.
     * @return Boolean
     */
    this.getDebit = function () {
        return this.Debit;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if this is a prepaid debit card transaction.
     * @param debit Boolean 
     */
    this.setDebit = function (debit) {
        this.Debit = debit;
    }

    /**
     * Sets the discount type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid discount types.
     * @param discountType Number
     * @return Reference to this object for method chaining. 
     */
    this.discountType = function (discountType) {
        this.DiscountType = discountType;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid discount
     * types.
     * @return Number
     */
    this.getDiscountType = function () {
        return this.DiscountType;
    }

    /* Reference to this object for method chaining.*
     * Sets the discount type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid discount types.
     * @param discountType Number 
     */
    this.setDiscountType = function (discountType) {
        this.DiscountType = discountType;
    }

    /**
     * Sets a value indicating if the carrier delivering the service has company 
     * owned facilities to provide the service.
     * @param facilitiesBased Boolean
     * @return Reference to this object for method chaining. 
     */
    this.facilitiesBased = function (facilitiesBased) {
        this.FacilitiesBased = facilitiesBased;
        return this;
    }

    /**
     * Specifies if the carrier delivering the service has company owned
     * facilities to provide the service.
     * @return Boolean
     */
    this.getFacilitiesBased = function () {
        return this.FacilitiesBased;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the carrier delivering the service has company 
     * owned facilities to provide the service.
     * @param facilitiesBased Boolean 
     */
    this.setFacilitiesBased = function (facilitiesBased) {
        this.FacilitiesBased = facilitiesBased;
    }

    /**
     * Sets a value indicating if the company provides services sold pursuant to 
     * a franchise agreement between the carrier and jurisdiction.
     * @param franchise Boolean
     * @return Reference to this object for method chaining. 
     */
    this.franchise = function (franchise) {
        this.Franchise = franchise;
        return this;
    }

    /**
     * Indicates if the company provides services sold pursuant to a franchise
     * agreement between the carrier and jurisdiction.
     * @return Boolean
     */
    this.getFranchise = function () {
        return this.Franchise;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the company provides services sold pursuant to 
     * a franchise agreement between the carrier and jurisdiction.
     * @param franchise Boolean 
     */
    this.setFranchise = function (franchise) {
        this.Franchise = franchise;
    }

    /**
     * Sets a value indicating if customer is a Lifeline participant.
     * @param lifeline Boolean
     * @return Reference to this object for method chaining. 
     */
    this.lifeline = function (lifeline) {
        this.Lifeline = lifeline;
        return this;
    }

    /**
     * Indicates if customer is a Lifeline participant.
     * @return Boolean
     */
    this.getLifeline = function () {
        return this.Lifeline;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if customer is a Lifeline participant.
     * @param lifeline Boolean 
     */
    this.setLifeline = function (lifeline) {
        this.Lifeline = lifeline;
    }

    /**
     * Sets a value indicating if the company is regulated.
     * @param regulated Boolean
     * @return Reference to this object for method chaining. 
     */
    this.regulated = function (regulated) {
        this.Regulated = regulated;
        return this;
    }

    /**
     * True if regulated, otherwise false.
     * @return Boolean
     */
    this.getRegulated = function () {
        return this.Regulated;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the company is regulated.
     * @param regulated Boolean 
     */
    this.setRegulated = function (regulated) {
        this.Regulated = regulated;
    }

    /**
     * Sets a user-defined service level number.
     * @param serviceLevelNumber Number
     * @return Reference to this object for method chaining. 
     */
    this.serviceLevelNumber = function (serviceLevelNumber) {
        this.ServiceLevelNumber = serviceLevelNumber;
        return this;
    }

    /**
     * User-defined service level number.
     * @return Number
     */
    this.getServiceLevelNumber = function () {
        return this.ServiceLevelNumber;
    }

    /* Reference to this object for method chaining.*
     * Sets a user-defined service level number.
     * @param serviceLevelNumber Number 
     */
    this.setServiceLevelNumber = function (serviceLevelNumber) {
        this.ServiceLevelNumber = serviceLevelNumber;
    }

    /**
     * Sets a list of states for tax exclusions.
     * @param exclusions Array of Exclusion
     * @return Reference to this object for method chaining. 
     */
    this.exclusions = function (exclusions) {
        this.Exclusions = exclusions;
        return this;
    }

    /**
     * Adds an exclusion to this transaction.
     * @param exclusionsItem Exclusion object.
     * @return Reference to this object for method chaining. 
     */
    this.addExclusionsItem = function (exclusionsItem) {
        this.Exclusions.push(exclusionsItem);
        return this;
    }

    /**
     * List of states for tax exclusions.
     * @return Array of Exclusion
     */
    this.getExclusions = function () {
        return this.Exclusions;
    }

    /* Reference to this object for method chaining.*
     * Sets a list of states for tax exclusions.
     * @param exclusions Array of Exclusion 
     */
    this.setExclusions = function (exclusions) {
        this.Exclusions = exclusions;
    }

    /**
     * Sets the list of tax category exemptions.
     * @param categoryExemptions Array of CategoryExemption
     * @return Reference to this object for method chaining. 
     */
    this.categoryExemptions = function (categoryExemptions) {
        this.CategoryExemptions = categoryExemptions;
        return this;
    }

    /**
     * Adds a category exemption to this transaction.
     * @param categoryExemptionsItem CategoryExemption object.
     * @return Reference to this object for method chaining. 
     */
    this.addCategoryExemptionsItem = function (categoryExemptionsItem) {
        this.CategoryExemptions.push(categoryExemptionsItem);
        return this;
    }

    /**
     * List of tax category exemptions.
     * @return Array of CategoryExemption
     */
    this.getCategoryExemptions = function () {
        return this.CategoryExemptions;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of tax category exemptions.
     * @param categoryExemptions Array of CategoryExemption 
     */
    this.setCategoryExemptions = function (categoryExemptions) {
        this.CategoryExemptions = categoryExemptions;
    }

    /**
     * Sets a user-defined list of optional alphanumeric fields.
     * @param optionalFields Array of OptionalField
     * @return Reference to this object for method chaining. 
     */
    this.optionalFields = function (optionalFields) {
        this.OptionalFields = optionalFields;
        return this;
    }

    /**
     * Adds a user-defined optional alphanumeric field to this transaction.
     * @param optionalFieldsItem OptionalField object.
     * @return Reference to this object for method chaining. 
     */
    this.addOptionalFieldsItem = function (optionalFieldsItem) {
        this.OptionalFields.push(optionalFieldsItem);
        return this;
    }

    /**
     * User-defined list of optional alphanumeric fields.
     * @return Array of OptionalField
     */
    this.getOptionalFields = function () {
        return this.OptionalFields;
    }

    /* Reference to this object for method chaining.*
     * Sets a user-defined list of optional alphanumeric fields.
     * @param optionalFields Array of OptionalField 
     */
    this.setOptionalFields = function (optionalFields) {
        this.OptionalFields = optionalFields;
    }
}
