package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

/**
 * Contains data required for performing tax calculations on bridge conference
 * transactions.
 */
public class BridgeConferenceTransaction {

    @SerializedName("ProcessInvalidParticipant")
    private Boolean processInvalidParticipant = null;

    @SerializedName("ReturnParticipantTaxes")
    private Boolean returnParticipantTaxes = null;

    @SerializedName("BillingPCode")
    private Integer billingPCode = null;

    @SerializedName("BridgePCode")
    private Integer bridgePCode = null;

    @SerializedName("HostPCode")
    private Integer hostPCode = null;

    @SerializedName("BillingNpaNxx")
    private Integer billingNpaNxx = null;

    @SerializedName("BridgeNpaNxx")
    private Integer bridgeNpaNxx = null;

    @SerializedName("HostNpaNxx")
    private Integer hostNpaNxx = null;

    @SerializedName("BillingAddress")
    private ZipAddress billingAddress = null;

    @SerializedName("BridgeAddress")
    private ZipAddress bridgeAddress = null;

    @SerializedName("HostAddress")
    private ZipAddress hostAddress = null;

    @SerializedName("Participants")
    private List<BridgeConferenceParticipant> participants = new ArrayList<>();

    @SerializedName("CustomerType")
    private Integer customerType = null;

    @SerializedName("BusinessClass")
    private Integer businessClass = null;

    @SerializedName("Sale")
    private Boolean sale = null;

    @SerializedName("TransactionType")
    private Integer transactionType = null;

    @SerializedName("ServiceType")
    private Integer serviceType = null;

    @SerializedName("ServiceClass")
    private Integer serviceClass = null;

    @SerializedName("Date")
    private LocalDateTime date = null;

    @SerializedName("Charge")
    private Double charge = null;

    @SerializedName("Incorporated")
    private Boolean incorporated = null;

    @SerializedName("FederalExempt")
    private Boolean federalExempt = null;

    @SerializedName("StateExempt")
    private Boolean stateExempt = null;

    @SerializedName("CountyExempt")
    private Boolean countyExempt = null;

    @SerializedName("LocalExempt")
    private Boolean localExempt = null;

    @SerializedName("FederalPCode")
    private Integer federalPCode = null;

    @SerializedName("StatePCode")
    private Integer statePCode = null;

    @SerializedName("CountyPCode")
    private Integer countyPCode = null;

    @SerializedName("LocalPCode")
    private Integer localPCode = null;

    @SerializedName("Exemptions")
    private List<TaxExemption> exemptions = new ArrayList<>();

    @SerializedName("ExemptionType")
    private Integer exemptionType = null;

    @SerializedName("InvoiceNumber")
    private Integer invoiceNumber = null;

    @SerializedName("Optional")
    private Integer optional = null;

    @SerializedName("CustomerNumber")
    private String customerNumber = null;

    @SerializedName("CompanyIdentifier")
    private String companyIdentifier = null;

    @SerializedName("OptionalAlpha1")
    private String optionalAlpha1 = null;

    @SerializedName("Optional4")
    private Integer optional4 = null;

    @SerializedName("Optional5")
    private Integer optional5 = null;

    @SerializedName("Optional6")
    private Integer optional6 = null;

    @SerializedName("Optional7")
    private Integer optional7 = null;

    @SerializedName("Optional8")
    private Integer optional8 = null;

    @SerializedName("Optional9")
    private Integer optional9 = null;

    @SerializedName("Optional10")
    private Integer optional10 = null;

    @SerializedName("AdjustmentMethod")
    private Integer adjustmentMethod = null;

    @SerializedName("Lines")
    private Integer lines = null;

    @SerializedName("Locations")
    private Integer locations = null;

    @SerializedName("Minutes")
    private Double minutes = null;

    @SerializedName("Debit")
    private Boolean debit = null;

    @SerializedName("DiscountType")
    private Integer discountType = null;

    @SerializedName("FacilitiesBased")
    private Boolean facilitiesBased = null;

    @SerializedName("Franchise")
    private Boolean franchise = null;

    @SerializedName("Lifeline")
    private Boolean lifeline = null;

    @SerializedName("Regulated")
    private Boolean regulated = null;

    @SerializedName("ServiceLevelNumber")
    private Integer serviceLevelNumber = null;

    @SerializedName("Exclusions")
    private List<Exclusion> exclusions = new ArrayList<>();

    @SerializedName("CategoryExemptions")
    private List<CategoryExemption> categoryExemptions = new ArrayList<>();

    @SerializedName("OptionalFields")
    private List<OptionalField> optionalFields = new ArrayList<>();

    /**
     * Sets a value indicating whether invalid participant jurisdiction should 
     * cause the transaction to fail (false) or whether the participant should be
     * processed with greatest tax liability (true).
     * @param processInvalidParticipant
     * @return 
     */
    public BridgeConferenceTransaction processInvalidParticipant(Boolean processInvalidParticipant) {
        this.processInvalidParticipant = processInvalidParticipant;
        return this;
    }

    /**
     * Flag indicating whether invalid participant jurisdiction should cause the
     * transaction to fail (false) or whether the participant should be
     * processed with greatest tax liability (true).
     * @return processInvalidParticipant
     */
    public Boolean getProcessInvalidParticipant() {
        return processInvalidParticipant;
    }

    /**
     * Sets a value indicating whether invalid participant jurisdiction should 
     * cause the transaction to fail (false) or whether the participant should be
     * processed with greatest tax liability (true).
     * @param processInvalidParticipant 
     */
    public void setProcessInvalidParticipant(Boolean processInvalidParticipant) {
        this.processInvalidParticipant = processInvalidParticipant;
    }

    /**
     * Sets a value indicating whether individual participant taxes should be 
     * returned in the response.
     * @param returnParticipantTaxes
     * @return 
     */
    public BridgeConferenceTransaction returnParticipantTaxes(Boolean returnParticipantTaxes) {
        this.returnParticipantTaxes = returnParticipantTaxes;
        return this;
    }

    /**
     * Indicates whether individual participant taxes should be returned in the
     * response.
     * @return returnParticipantTaxes
     */
    public Boolean getReturnParticipantTaxes() {
        return returnParticipantTaxes;
    }

    /**
     * Sets a value indicating whether individual participant taxes should be 
     * returned in the response.
     * @param returnParticipantTaxes 
     */
    public void setReturnParticipantTaxes(Boolean returnParticipantTaxes) {
        this.returnParticipantTaxes = returnParticipantTaxes;
    }

    /**
     * Sets the PCode for billing.
     * @param billingPCode
     * @return 
     */
    public BridgeConferenceTransaction billingPCode(Integer billingPCode) {
        this.billingPCode = billingPCode;
        return this;
    }

    /**
     * PCode for billing.
     * @return billingPCode
     */
    public Integer getBillingPCode() {
        return billingPCode;
    }

    /**
     * Sets the PCode for billing.
     * @param billingPCode 
     */
    public void setBillingPCode(Integer billingPCode) {
        this.billingPCode = billingPCode;
    }

    /**
     * Sets the PCode for bridge.
     * @param bridgePCode
     * @return 
     */
    public BridgeConferenceTransaction bridgePCode(Integer bridgePCode) {
        this.bridgePCode = bridgePCode;
        return this;
    }

    /**
     * PCode for bridge.
     * @return bridgePCode
     */
    public Integer getBridgePCode() {
        return bridgePCode;
    }

    /**
     * Sets the PCode for bridge.
     * @param bridgePCode 
     */
    public void setBridgePCode(Integer bridgePCode) {
        this.bridgePCode = bridgePCode;
    }

    /**
     * Sets the PCode for host.
     * @param hostPCode
     * @return 
     */
    public BridgeConferenceTransaction hostPCode(Integer hostPCode) {
        this.hostPCode = hostPCode;
        return this;
    }

    /**
     * PCode for host.
     * @return hostPCode
     */
    public Integer getHostPCode() {
        return hostPCode;
    }

    /**
     * Sets the PCode for host.
     * @param hostPCode 
     */
    public void setHostPCode(Integer hostPCode) {
        this.hostPCode = hostPCode;
    }

    /**
     * Sets the NPANXX for billing.
     * @param billingNpaNxx
     * @return 
     */
    public BridgeConferenceTransaction billingNpaNxx(Integer billingNpaNxx) {
        this.billingNpaNxx = billingNpaNxx;
        return this;
    }

    /**
     * NPANXX for billing.
     * @return billingNpaNxx
     */
    public Integer getBillingNpaNxx() {
        return billingNpaNxx;
    }

    /**
     * Sets the NPANXX for billing.
     * @param billingNpaNxx 
     */
    public void setBillingNpaNxx(Integer billingNpaNxx) {
        this.billingNpaNxx = billingNpaNxx;
    }

    /**
     * Sets the NPANXX for bridge.
     * @param bridgeNpaNxx
     * @return 
     */
    public BridgeConferenceTransaction bridgeNpaNxx(Integer bridgeNpaNxx) {
        this.bridgeNpaNxx = bridgeNpaNxx;
        return this;
    }

    /**
     * NPANXX for bridge.
     * @return bridgeNpaNxx
     */
    public Integer getBridgeNpaNxx() {
        return bridgeNpaNxx;
    }

    /**
     * Sets the NPANXX for bridge.
     * @param bridgeNpaNxx 
     */
    public void setBridgeNpaNxx(Integer bridgeNpaNxx) {
        this.bridgeNpaNxx = bridgeNpaNxx;
    }

    /**
     * Sets the NPANXX for host.
     * @param hostNpaNxx
     * @return 
     */
    public BridgeConferenceTransaction hostNpaNxx(Integer hostNpaNxx) {
        this.hostNpaNxx = hostNpaNxx;
        return this;
    }

    /**
     * NPANXX for host.
     * @return hostNpaNxx
     */
    public Integer getHostNpaNxx() {
        return hostNpaNxx;
    }

    /**
     * Sets the NPANXX for host.
     * @param hostNpaNxx 
     */
    public void setHostNpaNxx(Integer hostNpaNxx) {
        this.hostNpaNxx = hostNpaNxx;
    }

    /**
     * Sets the billing address.
     * @param billingAddress
     * @return 
     */
    public BridgeConferenceTransaction billingAddress(ZipAddress billingAddress) {
        this.billingAddress = billingAddress;
        return this;
    }

    /**
     * Billing address.
     * @return billingAddress
     */
    public ZipAddress getBillingAddress() {
        return billingAddress;
    }

    /**
     * Sets the billing address.
     * @param billingAddress 
     */
    public void setBillingAddress(ZipAddress billingAddress) {
        this.billingAddress = billingAddress;
    }

    /**
     * Sets the bridge address.
     * @param bridgeAddress
     * @return 
     */
    public BridgeConferenceTransaction bridgeAddress(ZipAddress bridgeAddress) {
        this.bridgeAddress = bridgeAddress;
        return this;
    }

    /**
     * Bridge address.
     * @return bridgeAddress
     */
    public ZipAddress getBridgeAddress() {
        return bridgeAddress;
    }

    /**
     * Sets the bridge address.
     * @param bridgeAddress 
     */
    public void setBridgeAddress(ZipAddress bridgeAddress) {
        this.bridgeAddress = bridgeAddress;
    }

    /**
     * Sets the host address.
     * @param hostAddress
     * @return 
     */
    public BridgeConferenceTransaction hostAddress(ZipAddress hostAddress) {
        this.hostAddress = hostAddress;
        return this;
    }

    /**
     * Host address.
     * @return hostAddress
     */
    public ZipAddress getHostAddress() {
        return hostAddress;
    }

    /**
     * Sets the host address.
     * @param hostAddress 
     */
    public void setHostAddress(ZipAddress hostAddress) {
        this.hostAddress = hostAddress;
    }

    /**
     * Sets the list of bridge conference participants.
     * @param participants
     * @return 
     */
    public BridgeConferenceTransaction participants(List<BridgeConferenceParticipant> participants) {
        this.participants = participants;
        return this;
    }

    /**
     * Adds a bridge conference participant to this transaction.
     * @param participantsItem
     * @return 
     */
    public BridgeConferenceTransaction addParticipant(BridgeConferenceParticipant participantsItem) {
        this.participants.add(participantsItem);
        return this;
    }

    /**
     * List of bridge conference participants.
     * @return participants
     */
    public List<BridgeConferenceParticipant> getParticipants() {
        return participants;
    }

    /**
     * Sets the list of bridge conference participants.
     * @param participants 
     */
    public void setParticipants(List<BridgeConferenceParticipant> participants) {
        this.participants = participants;
    }

    /**
     * Sets the customer type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid customer types.
     * @param customerType
     * @return 
     */
    public BridgeConferenceTransaction customerType(Integer customerType) {
        this.customerType = customerType;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid customer
     * types.
     * @return customerType
     */
    public Integer getCustomerType() {
        return customerType;
    }

    /**
     * Sets the customer type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid customer types.
     * @param customerType 
     */
    public void setCustomerType(Integer customerType) {
        this.customerType = customerType;
    }

    /**
     * Sets the business class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid business classes.
     * @param businessClass
     * @return 
     */
    public BridgeConferenceTransaction businessClass(Integer businessClass) {
        this.businessClass = businessClass;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid business
     * classes.
     * @return businessClass
     */
    public Integer getBusinessClass() {
        return businessClass;
    }

    /**
     * Sets the business class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid business classes.
     * @param businessClass 
     */
    public void setBusinessClass(Integer businessClass) {
        this.businessClass = businessClass;
    }

    /**
     * Sets a value indicating if this is a retail sale. Use false for 
     * resale/wholesale transactions.
     * @param sale
     * @return 
     */
    public BridgeConferenceTransaction sale(Boolean sale) {
        this.sale = sale;
        return this;
    }

    /**
     * Indicates if this is a retail sale. Use false for resale/wholesale
     * transactions.
     * @return sale
     */
    public Boolean getSale() {
        return sale;
    }

    /**
     * Sets a value indicating if this is a retail sale. Use false for 
     * resale/wholesale transactions.
     * @param sale 
     */
    public void setSale(Boolean sale) {
        this.sale = sale;
    }

    /**
     * Sets the transaction type.
     * @param transactionType
     * @return 
     */
    public BridgeConferenceTransaction transactionType(Integer transactionType) {
        this.transactionType = transactionType;
        return this;
    }

    /**
     * Transaction type.
     * @return transactionType
     */
    public Integer getTransactionType() {
        return transactionType;
    }

    /**
     * Sets the transaction type.
     * @param transactionType 
     */
    public void setTransactionType(Integer transactionType) {
        this.transactionType = transactionType;
    }

    /**
     * Sets the service type.
     * @param serviceType
     * @return 
     */
    public BridgeConferenceTransaction serviceType(Integer serviceType) {
        this.serviceType = serviceType;
        return this;
    }

    /**
     * Service type.
     * @return serviceType
     */
    public Integer getServiceType() {
        return serviceType;
    }

    /**
     * Sets the service type.
     * @param serviceType 
     */
    public void setServiceType(Integer serviceType) {
        this.serviceType = serviceType;
    }

    /**
     * Sets the service class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid service classes.
     * @param serviceClass
     * @return 
     */
    public BridgeConferenceTransaction serviceClass(Integer serviceClass) {
        this.serviceClass = serviceClass;
        return this;
    }

    /**
     * Service class. See the CommsPlatform.API.WrapperClasses User's Manual for
     * a list of valid service classes.
     * @return serviceClass
     */
    public Integer getServiceClass() {
        return serviceClass;
    }

    /**
     * Sets the service class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid service classes.
     * @param serviceClass 
     */
    public void setServiceClass(Integer serviceClass) {
        this.serviceClass = serviceClass;
    }

    /**
     * Sets the transaction date. Field is provided to allow rating and taxing 
     * to occur on a date other than the billing date.
     * @param date
     * @return 
     */
    public BridgeConferenceTransaction date(LocalDateTime date) {
        this.date = date;
        return this;
    }

    /**
     * Transaction date. Field is provided to allow rating and taxing to occur
     * on a date other than the billing date.
     * @return date
     */
    public LocalDateTime getDate() {
        return date;
    }

    /**
     * Sets the transaction date. Field is provided to allow rating and taxing 
     * to occur on a date other than the billing date.
     * @param date 
     */
    public void setDate(LocalDateTime date) {
        this.date = date;
    }

    /**
     * Sets the charge amount to customer for transaction.
     * @param charge
     * @return 
     */
    public BridgeConferenceTransaction charge(Double charge) {
        this.charge = charge;
        return this;
    }

    /**
     * Charge amount to customer for transaction.
     * @return charge
     */
    public Double getCharge() {
        return charge;
    }

    /**
     * Sets the charge amount to customer for transaction.
     * @param charge 
     */
    public void setCharge(Double charge) {
        this.charge = charge;
    }

    /**
     * Sets a value indicating if this transaction is within an incorporated 
     * area of the local jurisdiction, otherwise false.
     * @param incorporated
     * @return 
     */
    public BridgeConferenceTransaction incorporated(Boolean incorporated) {
        this.incorporated = incorporated;
        return this;
    }

    /**
     * True if this transaction is within an incorporated area of the local
     * jurisdiction, otherwise false.
     * @return incorporated
     */
    public Boolean getIncorporated() {
        return incorporated;
    }

    /**
     * Sets a value indicating if this transaction is within an incorporated 
     * area of the local jurisdiction, otherwise false.
     * @param incorporated 
     */
    public void setIncorporated(Boolean incorporated) {
        this.incorporated = incorporated;
    }

    /**
     * Sets a value indicating if transaction is exempt from Federal tax.
     * @param federalExempt
     * @return 
     */
    public BridgeConferenceTransaction federalExempt(Boolean federalExempt) {
        this.federalExempt = federalExempt;
        return this;
    }

    /**
     * True if transaction is exempt from Federal tax, otherwise false.
     * @return federalExempt
     */
    public Boolean getFederalExempt() {
        return federalExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from Federal tax.
     * @param federalExempt 
     */
    public void setFederalExempt(Boolean federalExempt) {
        this.federalExempt = federalExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from state tax.
     * @param stateExempt
     * @return 
     */
    public BridgeConferenceTransaction stateExempt(Boolean stateExempt) {
        this.stateExempt = stateExempt;
        return this;
    }

    /**
     * True if transaction is exempt from state tax, otherwise false.
     * @return stateExempt
     */
    public Boolean getStateExempt() {
        return stateExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from state tax.
     * @param stateExempt 
     */
    public void setStateExempt(Boolean stateExempt) {
        this.stateExempt = stateExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from county tax.
     * @param countyExempt
     * @return 
     */
    public BridgeConferenceTransaction countyExempt(Boolean countyExempt) {
        this.countyExempt = countyExempt;
        return this;
    }

    /**
     * True if transaction is exempt from county tax, otherwise false.
     * @return countyExempt
     */
    public Boolean getCountyExempt() {
        return countyExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from county tax.
     * @param countyExempt
     */
    public void setCountyExempt(Boolean countyExempt) {
        this.countyExempt = countyExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from local Tax.
     * @param localExempt
     * @return 
     */
    public BridgeConferenceTransaction localExempt(Boolean localExempt) {
        this.localExempt = localExempt;
        return this;
    }

    /**
     * True if transaction is exempt from local tax, otherwise false.
     * @return localExempt
     */
    public Boolean getLocalExempt() {
        return localExempt;
    }

    /**
     * Sets a value indicating if transaction is exempt from local Tax.
     * @param localExempt 
     */
    public void setLocalExempt(Boolean localExempt) {
        this.localExempt = localExempt;
    }

    /**
     * Sets the jurisdiction for Federal exemption.
     * @param federalPCode
     * @return 
     */
    public BridgeConferenceTransaction federalPCode(Integer federalPCode) {
        this.federalPCode = federalPCode;
        return this;
    }

    /**
     * Jurisdiction for Federal exemption.
     * @return federalPCode
     */
    public Integer getFederalPCode() {
        return federalPCode;
    }

    /**
     * Sets the jurisdiction for Federal exemption.
     * @param federalPCode 
     */
    public void setFederalPCode(Integer federalPCode) {
        this.federalPCode = federalPCode;
    }

    /**
     * Sets the jurisdiction for state exemption.
     * @param statePCode
     * @return 
     */
    public BridgeConferenceTransaction statePCode(Integer statePCode) {
        this.statePCode = statePCode;
        return this;
    }

    /**
     * Jurisdiction for state exemption.
     * @return statePCode
     */
    public Integer getStatePCode() {
        return statePCode;
    }

    /**
     * Sets the jurisdiction for state exemption.
     * @param statePCode 
     */
    public void setStatePCode(Integer statePCode) {
        this.statePCode = statePCode;
    }

    /**
     * Sets the jurisdiction for county exemption.
     * @param countyPCode
     * @return 
     */
    public BridgeConferenceTransaction countyPCode(Integer countyPCode) {
        this.countyPCode = countyPCode;
        return this;
    }

    /**
     * Jurisdiction for county exemption.
     * @return countyPCode
     */
    public Integer getCountyPCode() {
        return countyPCode;
    }

    /**
     * Sets the jurisdiction for county exemption.
     * @param countyPCode 
     */
    public void setCountyPCode(Integer countyPCode) {
        this.countyPCode = countyPCode;
    }

    /**
     * Sets the jurisdiction for local exemption.
     * @param localPCode
     * @return 
     */
    public BridgeConferenceTransaction localPCode(Integer localPCode) {
        this.localPCode = localPCode;
        return this;
    }

    /**
     * Jurisdiction for local exemption.
     * @return localPCode
     */
    public Integer getLocalPCode() {
        return localPCode;
    }

    /**
     * Sets the jurisdiction for local exemption.
     * @param localPCode 
     */
    public void setLocalPCode(Integer localPCode) {
        this.localPCode = localPCode;
    }

    /**
     * Sets the list of tax exemptions.
     * @param exemptions
     * @return 
     */
    public BridgeConferenceTransaction exemptions(List<TaxExemption> exemptions) {
        this.exemptions = exemptions;
        return this;
    }

    /**
     * Adds a tax exemption to this transaction.
     * @param exemptionsItem
     * @return 
     */
    public BridgeConferenceTransaction addExemptionsItem(TaxExemption exemptionsItem) {
        this.exemptions.add(exemptionsItem);
        return this;
    }

    /**
     * List of tax exemptions.
     * @return exemptions
     */
    public List<TaxExemption> getExemptions() {
        return exemptions;
    }

    /**
     * Sets the list of tax exemptions.
     * @param exemptions 
     */
    public void setExemptions(List<TaxExemption> exemptions) {
        this.exemptions = exemptions;
    }

    /**
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType
     * @return 
     */
    public BridgeConferenceTransaction exemptionType(Integer exemptionType) {
        this.exemptionType = exemptionType;
        return this;
    }

    /**
     * Exemption type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid exemption types.
     * @return exemptionType
     */
    public Integer getExemptionType() {
        return exemptionType;
    }

    /**
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType 
     */
    public void setExemptionType(Integer exemptionType) {
        this.exemptionType = exemptionType;
    }

    /**
     * Sets a user-defined invoice number.
     * @param invoiceNumber
     * @return 
     */
    public BridgeConferenceTransaction invoiceNumber(Integer invoiceNumber) {
        this.invoiceNumber = invoiceNumber;
        return this;
    }

    /**
     * User-defined invoice number.
     * @return invoiceNumber
     */
    public Integer getInvoiceNumber() {
        return invoiceNumber;
    }

    /**
     * Sets a user-defined invoice number.
     * @param invoiceNumber 
     */
    public void setInvoiceNumber(Integer invoiceNumber) {
        this.invoiceNumber = invoiceNumber;
    }

    /**
     * Sets a user-defined optional value.
     * @param optional
     * @return 
     */
    public BridgeConferenceTransaction optional(Integer optional) {
        this.optional = optional;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional
     */
    public Integer getOptional() {
        return optional;
    }

    /**
     * Sets a user-defined optional value.
     * @param optional 
     */
    public void setOptional(Integer optional) {
        this.optional = optional;
    }

    /**
     * Sets a user-defined customer number.
     * @param customerNumber
     * @return 
     */
    public BridgeConferenceTransaction customerNumber(String customerNumber) {
        this.customerNumber = customerNumber;
        return this;
    }

    /**
     * User-defined customer number.
     * @return customerNumber
     */
    public String getCustomerNumber() {
        return customerNumber;
    }

    /**
     * Sets a user-defined customer number.
     * @param customerNumber 
     */
    public void setCustomerNumber(String customerNumber) {
        this.customerNumber = customerNumber;
    }

    /**
     * Sets the company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     * @param companyIdentifier
     * @return 
     */
    public BridgeConferenceTransaction companyIdentifier(String companyIdentifier) {
        this.companyIdentifier = companyIdentifier;
        return this;
    }

    /**
     * Company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     * @return companyIdentifier
     */
    public String getCompanyIdentifier() {
        return companyIdentifier;
    }

    /**
     * Sets the company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     * @param companyIdentifier 
     */
    public void setCompanyIdentifier(String companyIdentifier) {
        this.companyIdentifier = companyIdentifier;
    }

    /**
     * Sets an optional user-defined string value.
     * @param optionalAlpha1
     * @return 
     */
    public BridgeConferenceTransaction optionalAlpha1(String optionalAlpha1) {
        this.optionalAlpha1 = optionalAlpha1;
        return this;
    }

    /**
     * Optional user-defined string value.
     * @return optionalAlpha1
     */
    public String getOptionalAlpha1() {
        return optionalAlpha1;
    }

    /**
     * Sets an optional user-defined string value.
     * @param optionalAlpha1 
     */
    public void setOptionalAlpha1(String optionalAlpha1) {
        this.optionalAlpha1 = optionalAlpha1;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional4
     * @return 
     */
    public BridgeConferenceTransaction optional4(Integer optional4) {
        this.optional4 = optional4;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional4
     */
    public Integer getOptional4() {
        return optional4;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional4 
     */
    public void setOptional4(Integer optional4) {
        this.optional4 = optional4;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional5
     * @return 
     */
    public BridgeConferenceTransaction optional5(Integer optional5) {
        this.optional5 = optional5;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional5
     */
    public Integer getOptional5() {
        return optional5;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional5 
     */
    public void setOptional5(Integer optional5) {
        this.optional5 = optional5;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional6
     * @return 
     */
    public BridgeConferenceTransaction optional6(Integer optional6) {
        this.optional6 = optional6;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional6
     */
    public Integer getOptional6() {
        return optional6;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional6 
     */
    public void setOptional6(Integer optional6) {
        this.optional6 = optional6;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional7
     * @return 
     */
    public BridgeConferenceTransaction optional7(Integer optional7) {
        this.optional7 = optional7;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional7
     */
    public Integer getOptional7() {
        return optional7;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional7 
     */
    public void setOptional7(Integer optional7) {
        this.optional7 = optional7;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional8
     * @return 
     */
    public BridgeConferenceTransaction optional8(Integer optional8) {
        this.optional8 = optional8;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional8
     */
    public Integer getOptional8() {
        return optional8;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional8 
     */
    public void setOptional8(Integer optional8) {
        this.optional8 = optional8;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional9
     * @return 
     */
    public BridgeConferenceTransaction optional9(Integer optional9) {
        this.optional9 = optional9;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional9
     */
    public Integer getOptional9() {
        return optional9;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional9 
     */
    public void setOptional9(Integer optional9) {
        this.optional9 = optional9;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional10
     * @return 
     */
    public BridgeConferenceTransaction optional10(Integer optional10) {
        this.optional10 = optional10;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return optional10
     */
    public Integer getOptional10() {
        return optional10;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional10 
     */
    public void setOptional10(Integer optional10) {
        this.optional10 = optional10;
    }

    /**
     * Sets the adjustment method. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment methods.
     * @param adjustmentMethod
     * @return 
     */
    public BridgeConferenceTransaction adjustmentMethod(Integer adjustmentMethod) {
        this.adjustmentMethod = adjustmentMethod;
        return this;
    }

    /**
     * Adjustment method. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid adjustment methods.
     * @return adjustmentMethod
     */
    public Integer getAdjustmentMethod() {
        return adjustmentMethod;
    }

    /**
     * Sets the adjustment method. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment methods.
     * @param adjustmentMethod 
     */
    public void setAdjustmentMethod(Integer adjustmentMethod) {
        this.adjustmentMethod = adjustmentMethod;
    }

    /**
     * Sets the number of lines sold to customer when applicable.
     * @param lines
     * @return 
     */
    public BridgeConferenceTransaction lines(Integer lines) {
        this.lines = lines;
        return this;
    }

    /**
     * Number of lines sold to customer when applicable.
     * @return lines
     */
    public Integer getLines() {
        return lines;
    }

    /**
     * Sets the number of lines sold to customer when applicable.
     * @param lines 
     */
    public void setLines(Integer lines) {
        this.lines = lines;
    }

    /**
     * Sets the number of customer locations.
     * @param locations
     * @return 
     */
    public BridgeConferenceTransaction locations(Integer locations) {
        this.locations = locations;
        return this;
    }

    /**
     * Number of customer locations.
     * @return locations
     */
    public Integer getLocations() {
        return locations;
    }

    /**
     * Sets the number of customer locations.
     * @param locations 
     */
    public void setLocations(Integer locations) {
        this.locations = locations;
    }

    /**
     * Sets the number of minutes for call.
     * @param minutes
     * @return 
     */
    public BridgeConferenceTransaction minutes(Double minutes) {
        this.minutes = minutes;
        return this;
    }

    /**
     * Number of minutes for call when appropriate.
     * @return minutes
     */
    public Double getMinutes() {
        return minutes;
    }

    /**
     * Sets the number of minutes for call.
     * @param minutes 
     */
    public void setMinutes(Double minutes) {
        this.minutes = minutes;
    }

    /**
     * Sets a value indicating if this is a prepaid debit card transaction.
     * @param debit
     * @return 
     */
    public BridgeConferenceTransaction debit(Boolean debit) {
        this.debit = debit;
        return this;
    }

    /**
     * Determines if this is a prepaid debit card transaction.
     * @return debit
     */
    public Boolean getDebit() {
        return debit;
    }

    /**
     * Sets a value indicating if this is a prepaid debit card transaction.
     * @param debit 
     */
    public void setDebit(Boolean debit) {
        this.debit = debit;
    }

    /**
     * Sets the discount type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid discount types.
     * @param discountType
     * @return 
     */
    public BridgeConferenceTransaction discountType(Integer discountType) {
        this.discountType = discountType;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid discount
     * types.
     * @return discountType
     */
    public Integer getDiscountType() {
        return discountType;
    }

    /**
     * Sets the discount type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid discount types.
     * @param discountType 
     */
    public void setDiscountType(Integer discountType) {
        this.discountType = discountType;
    }

    /**
     * Sets a value indicating if the carrier delivering the service has company 
     * owned facilities to provide the service.
     * @param facilitiesBased
     * @return 
     */
    public BridgeConferenceTransaction facilitiesBased(Boolean facilitiesBased) {
        this.facilitiesBased = facilitiesBased;
        return this;
    }

    /**
     * Specifies if the carrier delivering the service has company owned
     * facilities to provide the service.
     * @return facilitiesBased
     */
    public Boolean getFacilitiesBased() {
        return facilitiesBased;
    }

    /**
     * Sets a value indicating if the carrier delivering the service has company 
     * owned facilities to provide the service.
     * @param facilitiesBased 
     */
    public void setFacilitiesBased(Boolean facilitiesBased) {
        this.facilitiesBased = facilitiesBased;
    }

    /**
     * Sets a value indicating if the company provides services sold pursuant to 
     * a franchise agreement between the carrier and jurisdiction.
     * @param franchise
     * @return 
     */
    public BridgeConferenceTransaction franchise(Boolean franchise) {
        this.franchise = franchise;
        return this;
    }

    /**
     * Indicates if the company provides services sold pursuant to a franchise
     * agreement between the carrier and jurisdiction.
     * @return franchise
     */
    public Boolean getFranchise() {
        return franchise;
    }

    /**
     * Sets a value indicating if the company provides services sold pursuant to 
     * a franchise agreement between the carrier and jurisdiction.
     * @param franchise 
     */
    public void setFranchise(Boolean franchise) {
        this.franchise = franchise;
    }

    /**
     * Sets a value indicating if customer is a Lifeline participant.
     * @param lifeline
     * @return 
     */
    public BridgeConferenceTransaction lifeline(Boolean lifeline) {
        this.lifeline = lifeline;
        return this;
    }

    /**
     * Indicates if customer is a Lifeline participant.
     * @return lifeline
     */
    public Boolean getLifeline() {
        return lifeline;
    }

    /**
     * Sets a value indicating if customer is a Lifeline participant.
     * @param lifeline 
     */
    public void setLifeline(Boolean lifeline) {
        this.lifeline = lifeline;
    }

    /**
     * Sets a value indicating if the company is regulated.
     * @param regulated
     * @return 
     */
    public BridgeConferenceTransaction regulated(Boolean regulated) {
        this.regulated = regulated;
        return this;
    }

    /**
     * True if regulated, otherwise false.
     * @return regulated
     */
    public Boolean getRegulated() {
        return regulated;
    }

    /**
     * Sets a value indicating if the company is regulated.
     * @param regulated 
     */
    public void setRegulated(Boolean regulated) {
        this.regulated = regulated;
    }

    /**
     * Sets a user-defined service level number.
     * @param serviceLevelNumber
     * @return 
     */
    public BridgeConferenceTransaction serviceLevelNumber(Integer serviceLevelNumber) {
        this.serviceLevelNumber = serviceLevelNumber;
        return this;
    }

    /**
     * User-defined service level number.
     * @return serviceLevelNumber
     */
    public Integer getServiceLevelNumber() {
        return serviceLevelNumber;
    }

    /**
     * Sets a user-defined service level number.
     * @param serviceLevelNumber 
     */
    public void setServiceLevelNumber(Integer serviceLevelNumber) {
        this.serviceLevelNumber = serviceLevelNumber;
    }

    /**
     * Sets a list of states for tax exclusions.
     * @param exclusions
     * @return 
     */
    public BridgeConferenceTransaction exclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
        return this;
    }

    /**
     * Adds an exclusion to this transaction.
     * @param exclusionsItem
     * @return 
     */
    public BridgeConferenceTransaction addExclusionsItem(Exclusion exclusionsItem) {
        this.exclusions.add(exclusionsItem);
        return this;
    }

    /**
     * List of states for tax exclusions.
     * @return exclusions
     */
    public List<Exclusion> getExclusions() {
        return exclusions;
    }

    /**
     * Sets a list of states for tax exclusions.
     * @param exclusions 
     */
    public void setExclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
    }

    /**
     * Sets the list of tax category exemptions.
     * @param categoryExemptions
     * @return 
     */
    public BridgeConferenceTransaction categoryExemptions(List<CategoryExemption> categoryExemptions) {
        this.categoryExemptions = categoryExemptions;
        return this;
    }

    /**
     * Adds a category exemption to this transaction.
     * @param categoryExemptionsItem
     * @return 
     */
    public BridgeConferenceTransaction addCategoryExemptionsItem(CategoryExemption categoryExemptionsItem) {
        this.categoryExemptions.add(categoryExemptionsItem);
        return this;
    }

    /**
     * List of tax category exemptions.
     * @return categoryExemptions
     */
    public List<CategoryExemption> getCategoryExemptions() {
        return categoryExemptions;
    }

    /**
     * Sets the list of tax category exemptions.
     * @param categoryExemptions 
     */
    public void setCategoryExemptions(List<CategoryExemption> categoryExemptions) {
        this.categoryExemptions = categoryExemptions;
    }

    /**
     * Sets a user-defined list of optional alphanumeric fields.
     * @param optionalFields
     * @return 
     */
    public BridgeConferenceTransaction optionalFields(List<OptionalField> optionalFields) {
        this.optionalFields = optionalFields;
        return this;
    }

    /**
     * Adds a user-defined optional alphanumeric field to this transaction.
     * @param optionalFieldsItem
     * @return 
     */
    public BridgeConferenceTransaction addOptionalFieldsItem(OptionalField optionalFieldsItem) {
        this.optionalFields.add(optionalFieldsItem);
        return this;
    }

    /**
     * User-defined list of optional alphanumeric fields.
     * @return optionalFields
     */
    public List<OptionalField> getOptionalFields() {
        return optionalFields;
    }

    /**
     * Sets a user-defined list of optional alphanumeric fields.
     * @param optionalFields 
     */
    public void setOptionalFields(List<OptionalField> optionalFields) {
        this.optionalFields = optionalFields;
    }
}
