package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

/**
 * Transaction data required for processing tax calculations.
 */
public class Transaction {

    @SerializedName("OriginationAddress")
    private ZipAddress originationAddress = null;

    @SerializedName("OriginationFipsCode")
    private String originationFipsCode = null;

    @SerializedName("OriginationPCode")
    private Integer originationPCode = null;

    @SerializedName("OriginationNpaNxx")
    private Integer originationNpaNxx = null;

    @SerializedName("TerminationAddress")
    private ZipAddress terminationAddress = null;

    @SerializedName("TerminationFipsCode")
    private String terminationFipsCode = null;

    @SerializedName("TerminationPCode")
    private Integer terminationPCode = null;

    @SerializedName("TerminationNpaNxx")
    private Integer terminationNpaNxx = null;

    @SerializedName("BillToAddress")
    private ZipAddress billToAddress = null;

    @SerializedName("BillToFipsCode")
    private String billToFipsCode = null;

    @SerializedName("BillToPCode")
    private Integer billToPCode = null;

    @SerializedName("BillToNpaNxx")
    private Integer billToNpaNxx = null;

    @SerializedName("IsPrivateLine")
    private Boolean isPrivateLine = null;

    @SerializedName("PrivateLineSplit")
    private Double privateLineSplit = null;

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

    @SerializedName("AdjustmentDiscount")
    private Integer adjustmentDiscount = null;

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

    @SerializedName("TaxInclusive")
    private Boolean taxInclusive = null;

    /**
     * Sets the origination address.
     * @param originationAddress
     * @return 
     */
    public Transaction originationAddress(ZipAddress originationAddress) {
        this.originationAddress = originationAddress;
        return this;
    }

    /**
     * Origination address.
     * @return originationAddress
     */
    public ZipAddress getOriginationAddress() {
        return originationAddress;
    }

    /**
     * Sets the origination address.
     * @param originationAddress 
     */
    public void setOriginationAddress(ZipAddress originationAddress) {
        this.originationAddress = originationAddress;
    }

    /**
     * Sets the origination FIPS code.
     * @param originationFipsCode
     * @return 
     */
    public Transaction originationFipsCode(String originationFipsCode) {
        this.originationFipsCode = originationFipsCode;
        return this;
    }

    /**
     * Origination FIPS code.
     * @return originationFipsCode
     */
    public String getOriginationFipsCode() {
        return originationFipsCode;
    }

    /**
     * Sets the origination FIPS code.
     * @param originationFipsCode 
     */
    public void setOriginationFipsCode(String originationFipsCode) {
        this.originationFipsCode = originationFipsCode;
    }

    /**
     * Sets the origination PCode.
     * @param originationPCode
     * @return 
     */
    public Transaction originationPCode(Integer originationPCode) {
        this.originationPCode = originationPCode;
        return this;
    }

    /**
     * Origination PCode.
     * @return originationPCode
     */
    public Integer getOriginationPCode() {
        return originationPCode;
    }

    /**
     * Sets the origination PCode.
     * @param originationPCode 
     */
    public void setOriginationPCode(Integer originationPCode) {
        this.originationPCode = originationPCode;
    }

    /**
     * Sets the origination NPANXX.
     * @param originationNpaNxx
     * @return 
     */
    public Transaction originationNpaNxx(Integer originationNpaNxx) {
        this.originationNpaNxx = originationNpaNxx;
        return this;
    }

    /**
     * Origination NPANXX.
     * @return originationNpaNxx
     */
    public Integer getOriginationNpaNxx() {
        return originationNpaNxx;
    }

    /**
     * Sets the origination NPANXX.
     * @param originationNpaNxx 
     */
    public void setOriginationNpaNxx(Integer originationNpaNxx) {
        this.originationNpaNxx = originationNpaNxx;
    }

    /**
     * Sets the termination address.
     * @param terminationAddress
     * @return 
     */
    public Transaction terminationAddress(ZipAddress terminationAddress) {
        this.terminationAddress = terminationAddress;
        return this;
    }

    /**
     * Termination address.
     * @return terminationAddress
     */
    public ZipAddress getTerminationAddress() {
        return terminationAddress;
    }

    /**
     * Sets the termination address.
     * @param terminationAddress 
     */
    public void setTerminationAddress(ZipAddress terminationAddress) {
        this.terminationAddress = terminationAddress;
    }

    /**
     * Sets the termination FIPS code.
     * @param terminationFipsCode
     * @return 
     */
    public Transaction terminationFipsCode(String terminationFipsCode) {
        this.terminationFipsCode = terminationFipsCode;
        return this;
    }

    /**
     * Termination FIPS code.
     * @return terminationFipsCode
     */
    public String getTerminationFipsCode() {
        return terminationFipsCode;
    }

    /**
     * Sets the termination FIPS code.
     * @param terminationFipsCode 
     */
    public void setTerminationFipsCode(String terminationFipsCode) {
        this.terminationFipsCode = terminationFipsCode;
    }

    /**
     * Sets the termination PCode.
     * @param terminationPCode
     * @return 
     */
    public Transaction terminationPCode(Integer terminationPCode) {
        this.terminationPCode = terminationPCode;
        return this;
    }

    /**
     * Termination PCode.
     * @return terminationPCode
     */
    public Integer getTerminationPCode() {
        return terminationPCode;
    }

    /**
     * Sets the termination PCode.
     * @param terminationPCode 
     */
    public void setTerminationPCode(Integer terminationPCode) {
        this.terminationPCode = terminationPCode;
    }

    /**
     * Sets the termination NPANXX.
     * @param terminationNpaNxx
     * @return 
     */
    public Transaction terminationNpaNxx(Integer terminationNpaNxx) {
        this.terminationNpaNxx = terminationNpaNxx;
        return this;
    }

    /**
     * Termination NPANXX.
     * @return terminationNpaNxx
     */
    public Integer getTerminationNpaNxx() {
        return terminationNpaNxx;
    }

    /**
     * Sets the termination NPANXX.
     * @param terminationNpaNxx 
     */
    public void setTerminationNpaNxx(Integer terminationNpaNxx) {
        this.terminationNpaNxx = terminationNpaNxx;
    }

    /**
     * Sets the bill-to address.
     * @param billToAddress
     * @return 
     */
    public Transaction billToAddress(ZipAddress billToAddress) {
        this.billToAddress = billToAddress;
        return this;
    }

    /**
     * Bill-to address.
     * @return billToAddress
     */
    public ZipAddress getBillToAddress() {
        return billToAddress;
    }

    /**
     * Sets the bill-to address.
     * @param billToAddress 
     */
    public void setBillToAddress(ZipAddress billToAddress) {
        this.billToAddress = billToAddress;
    }

    /**
     * Sets the bill-to FIPS code.
     * @param billToFipsCode
     * @return 
     */
    public Transaction billToFipsCode(String billToFipsCode) {
        this.billToFipsCode = billToFipsCode;
        return this;
    }

    /**
     * Bill-to FIPS code.
     * @return billToFipsCode
     */
    public String getBillToFipsCode() {
        return billToFipsCode;
    }

    /**
     * Sets the bill-to FIPS code.
     * @param billToFipsCode 
     */
    public void setBillToFipsCode(String billToFipsCode) {
        this.billToFipsCode = billToFipsCode;
    }

    /**
     * Sets the bill-to PCode.
     * @param billToPCode
     * @return 
     */
    public Transaction billToPCode(Integer billToPCode) {
        this.billToPCode = billToPCode;
        return this;
    }

    /**
     * Bill-to PCode.
     * @return billToPCode
     */
    public Integer getBillToPCode() {
        return billToPCode;
    }

    /**
     * Sets the bill-to PCode.
     * @param billToPCode 
     */
    public void setBillToPCode(Integer billToPCode) {
        this.billToPCode = billToPCode;
    }

    /**
     * Sets the bill-to NPANXX.
     * @param billToNpaNxx
     * @return 
     */
    public Transaction billToNpaNxx(Integer billToNpaNxx) {
        this.billToNpaNxx = billToNpaNxx;
        return this;
    }

    /**
     * Bill-to NPANXX
     * @return billToNpaNxx
     */
    public Integer getBillToNpaNxx() {
        return billToNpaNxx;
    }

    /**
     * Sets the bill-to NPANXX.
     * @param billToNpaNxx 
     */
    public void setBillToNpaNxx(Integer billToNpaNxx) {
        this.billToNpaNxx = billToNpaNxx;
    }

    /**
     * Sets a value indicating if the transaction is a private line transaction.
     * @param isPrivateLine
     * @return 
     */
    public Transaction isPrivateLine(Boolean isPrivateLine) {
        this.isPrivateLine = isPrivateLine;
        return this;
    }

    /**
     * Indicates if the transaction is a private line transaction.
     * @return isPrivateLine
     */
    public Boolean getIsPrivateLine() {
        return isPrivateLine;
    }

    /**
     * Sets a value indicating if the transaction is a private line transaction.
     * @param isPrivateLine 
     */
    public void setIsPrivateLine(Boolean isPrivateLine) {
        this.isPrivateLine = isPrivateLine;
    }

    /**
     * Sets the split between the ending points of a private line. The value 
     * indicates how much the portion of the charge belongs to the origin user.
     * @param privateLineSplit
     * @return 
     */
    public Transaction privateLineSplit(Double privateLineSplit) {
        this.privateLineSplit = privateLineSplit;
        return this;
    }

    /**
     * For private line transactions, this is the split between the ending
     * points of a private line. The value indicates how much the portion of the
     * charge belongs to the origin user.
     *
     * @return privateLineSplit
  *
     */
    public Double getPrivateLineSplit() {
        return privateLineSplit;
    }

    /**
     * Sets the split between the ending points of a private line. The value 
     * indicates how much the portion of the charge belongs to the origin user.
     * @param privateLineSplit 
     */
    public void setPrivateLineSplit(Double privateLineSplit) {
        this.privateLineSplit = privateLineSplit;
    }

    /**
     * Sets the customer type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid customer types.
     * @param customerType
     * @return 
     */
    public Transaction customerType(Integer customerType) {
        this.customerType = customerType;
        return this;
    }

    /**
     * Customer type. See the CommsPlatform.API.WrapperClasses User's Manual for
     * a list of valid customer types.
     *
     * @return customerType
  *
     */
    public Integer getCustomerType() {
        return customerType;
    }

    /**
     * Sets the customer type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid customer types.
     * @param customerType 
     */
    public void setCustomerType(Integer customerType) {
        this.customerType = customerType;
    }

    /**
     * Sets the business class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid business classes.
     * @param businessClass
     * @return 
     */
    public Transaction businessClass(Integer businessClass) {
        this.businessClass = businessClass;
        return this;
    }

    /**
     * Business class. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid business classes.
     * @return businessClass
     */
    public Integer getBusinessClass() {
        return businessClass;
    }

    /**
     * Sets the business class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid business classes.
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
    public Transaction sale(Boolean sale) {
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
     * Sets the transaction type for this transaction.
     * @param transactionType
     * @return 
     */
    public Transaction transactionType(Integer transactionType) {
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
     * Sets the transaction type for this transaction.
     * @param transactionType 
     */
    public void setTransactionType(Integer transactionType) {
        this.transactionType = transactionType;
    }

    /**
     * Sets the service type for this transaction.
     * @param serviceType
     * @return 
     */
    public Transaction serviceType(Integer serviceType) {
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
     * Sets the service type for this transaction.
     * @param serviceType 
     */
    public void setServiceType(Integer serviceType) {
        this.serviceType = serviceType;
    }

    /**
     * Sets the service class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid Service Classes
     * @param serviceClass
     * @return 
     */
    public Transaction serviceClass(Integer serviceClass) {
        this.serviceClass = serviceClass;
        return this;
    }

    /**
     * Service class. See the CommsPlatform.API.WrapperClasses User's Manual for
     * a list of valid Service Classes.
     * @return serviceClass
     */
    public Integer getServiceClass() {
        return serviceClass;
    }

    /**
     * Sets the service class. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid Service Classes
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
    public Transaction date(LocalDateTime date) {
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
     * Sets the charge amount to customer for this transaction.
     * @param charge
     * @return 
     */
    public Transaction charge(Double charge) {
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
     * Sets the charge amount to customer for this transaction.
     * @param charge 
     */
    public void setCharge(Double charge) {
        this.charge = charge;
    }

    /**
     * Sets a value indicating if this transaction is within an incorporated area 
     * of the local jurisdiction.
     * @param incorporated
     * @return 
     */
    public Transaction incorporated(Boolean incorporated) {
        this.incorporated = incorporated;
        return this;
    }

    /**
     * True if this transaction is within an incorporated area of the local
     * jurisdiction, otherwise False.
     * @return incorporated
     */
    public Boolean getIncorporated() {
        return incorporated;
    }

    /**
     * Sets a value indicating if this transaction is within an incorporated area 
     * of the local jurisdiction.
     * @param incorporated 
     */
    public void setIncorporated(Boolean incorporated) {
        this.incorporated = incorporated;
    }

    /**
     * Sets a value indicating if the transaction is exempt from Federal tax.
     * @param federalExempt
     * @return 
     */
    public Transaction federalExempt(Boolean federalExempt) {
        this.federalExempt = federalExempt;
        return this;
    }

    /**
     * True if transaction is exempt from Federal Tax, otherwise false.
     * @return federalExempt
     */
    public Boolean getFederalExempt() {
        return federalExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from Federal tax.
     * @param federalExempt 
     */
    public void setFederalExempt(Boolean federalExempt) {
        this.federalExempt = federalExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from State tax.
     * @param stateExempt
     * @return 
     */
    public Transaction stateExempt(Boolean stateExempt) {
        this.stateExempt = stateExempt;
        return this;
    }

    /**
     * True if transaction is exempt from State Tax, otherwise false.
     * @return stateExempt
     */
    public Boolean getStateExempt() {
        return stateExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from State tax.
     * @param stateExempt 
     */
    public void setStateExempt(Boolean stateExempt) {
        this.stateExempt = stateExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from County tax.
     * @param countyExempt
     * @return 
     */
    public Transaction countyExempt(Boolean countyExempt) {
        this.countyExempt = countyExempt;
        return this;
    }

    /**
     * True if transaction is exempt from County Tax, otherwise false.
     * @return countyExempt
     */
    public Boolean getCountyExempt() {
        return countyExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from County tax.
     * @param countyExempt 
     */
    public void setCountyExempt(Boolean countyExempt) {
        this.countyExempt = countyExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from Local tax.
     * @param localExempt
     * @return 
     */
    public Transaction localExempt(Boolean localExempt) {
        this.localExempt = localExempt;
        return this;
    }

    /**
     * True if transaction is exempt from Local Tax, otherwise false.
     * @return localExempt
     */
    public Boolean getLocalExempt() {
        return localExempt;
    }

    /**
     * Sets a value indicating if the transaction is exempt from Local tax.
     * @param localExempt 
     */
    public void setLocalExempt(Boolean localExempt) {
        this.localExempt = localExempt;
    }

    /**
     * 
     * Sets the jurisdiction for Federal exemption.
     * @param federalPCode
     * @return 
     */
    public Transaction federalPCode(Integer federalPCode) {
        this.federalPCode = federalPCode;
        return this;
    }

    /**
     * Jurisdiction for Federal exemption.
     *
     * @return federalPCode
  *
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
    public Transaction statePCode(Integer statePCode) {
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
    public Transaction countyPCode(Integer countyPCode) {
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
    public Transaction localPCode(Integer localPCode) {
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
     * Sets the list of tax exemptions for this transaction.
     * @param exemptions
     * @return 
     */
    public Transaction exemptions(List<TaxExemption> exemptions) {
        this.exemptions = exemptions;
        return this;
    }

    /**
     * Adds an exemption to this transaction.
     * @param exemptionsItem TaxExemption object
     * @return 
     */
    public Transaction addExemptionsItem(TaxExemption exemptionsItem) {
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
     * Sets the list of tax exemptions for this transaction.
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
    public Transaction exemptionType(Integer exemptionType) {
        this.exemptionType = exemptionType;
        return this;
    }

    /**
     * Exemption type. See the CommsPlatform.API.WrapperClasses User's Manual for
     * a list of valid exemption types.
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
     * Sets the invoice number (user-defined).
     * @param invoiceNumber
     * @return 
     */
    public Transaction invoiceNumber(Integer invoiceNumber) {
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
     * Sets the invoice number (user-defined).
     * @param invoiceNumber 
     */
    public void setInvoiceNumber(Integer invoiceNumber) {
        this.invoiceNumber = invoiceNumber;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional
     * @return 
     */
    public Transaction optional(Integer optional) {
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
     * Sets an optional user-defined value.
     * @param optional 
     */
    public void setOptional(Integer optional) {
        this.optional = optional;
    }

    /**
     * Sets the customer number (user-defined).
     * @param customerNumber
     * @return 
     */
    public Transaction customerNumber(String customerNumber) {
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
     * Sets the customer number (user-defined).
     * @param customerNumber 
     */
    public void setCustomerNumber(String customerNumber) {
        this.customerNumber = customerNumber;
    }

    /**
     * Sets the company identifier. Use the 3-character company identifier 
     * provided by Avalara to your organization in order to include this 
     * transaction in the monthly compliance reports. Otherwise, leave empty.
     * @param companyIdentifier
     * @return 
     */
    public Transaction companyIdentifier(String companyIdentifier) {
        this.companyIdentifier = companyIdentifier;
        return this;
    }

    /**
     * Company identifier. Use the 3-character company identifier provided by
     * Avalara to your organization in order to include this transaction in the
     * monthly compliance reports. Otherwise, leave empty.
     *
     * @return companyIdentifier
  *
     */
    public String getCompanyIdentifier() {
        return companyIdentifier;
    }

    /**
     * Sets the company identifier. Use the 3-character company identifier 
     * provided by Avalara to your organization in order to include this 
     * transaction in the monthly compliance reports. Otherwise, leave empty.
     * @param companyIdentifier 
     */
    public void setCompanyIdentifier(String companyIdentifier) {
        this.companyIdentifier = companyIdentifier;
    }

    /**
     * Sets an optional user-defined alphanumeric value.
     * @param optionalAlpha1
     * @return 
     */
    public Transaction optionalAlpha1(String optionalAlpha1) {
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
     * Sets an optional user-defined alphanumeric value.
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
    public Transaction optional4(Integer optional4) {
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
    public Transaction optional5(Integer optional5) {
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
    public Transaction optional6(Integer optional6) {
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
    public Transaction optional7(Integer optional7) {
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
    public Transaction optional8(Integer optional8) {
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
    public Transaction optional9(Integer optional9) {
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
    public Transaction optional10(Integer optional10) {
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
     * Sets the Adjustment method. See the CommsPlatform.API.WrapperClasses 
     * User's Manual for a list of valid adjustment methods.
     * @param adjustmentMethod
     * @return 
     */
    public Transaction adjustmentMethod(Integer adjustmentMethod) {
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
     * Sets the Adjustment method. See the CommsPlatform.API.WrapperClasses 
     * User's Manual for a list of valid adjustment methods.
     * @param adjustmentMethod 
     */
    public void setAdjustmentMethod(Integer adjustmentMethod) {
        this.adjustmentMethod = adjustmentMethod;
    }

    /**
     * Sets the number of lines sold to customer.
     * @param lines
     * @return 
     */
    public Transaction lines(Integer lines) {
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
     * Sets the number of lines sold to customer.
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
    public Transaction locations(Integer locations) {
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
     * Sets the number of minutes for a call
     * @param minutes
     * @return 
     */
    public Transaction minutes(Double minutes) {
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
     * Sets the number of minutes for a call.
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
    public Transaction debit(Boolean debit) {
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
     * Sets the discount type for an adjustment. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid discount types.
     * @param adjustmentDiscount
     * @return 
     */
    public Transaction adjustmentDiscount(Integer adjustmentDiscount) {
        this.adjustmentDiscount = adjustmentDiscount;
        return this;
    }

    /**
     * Adjustment discount type. See the CommsPlatform.API.WrapperClasses User's
     * Manual for a list of valid discount types.
     * @return adjustmentDiscount
     */
    public Integer getAdjustmentDiscount() {
        return adjustmentDiscount;
    }

    /**
     * Sets the discount type for an adjustment. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid discount types.
     * @param adjustmentDiscount 
     */
    public void setAdjustmentDiscount(Integer adjustmentDiscount) {
        this.adjustmentDiscount = adjustmentDiscount;
    }

    /**
     * Sets a value indicating if the carrier delivering the service has company 
     * owned facilities to provide the service.
     * @param facilitiesBased
     * @return 
     */
    public Transaction facilitiesBased(Boolean facilitiesBased) {
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
    public Transaction franchise(Boolean franchise) {
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
    public Transaction lifeline(Boolean lifeline) {
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
     * Sets a value indicating if the company is regulated or not.
     * @param regulated
     * @return 
     */
    public Transaction regulated(Boolean regulated) {
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
     * Sets a value indicating if the company is regulated or not.
     * @param regulated 
     */
    public void setRegulated(Boolean regulated) {
        this.regulated = regulated;
    }

    /**
     * Sets the service level number (user-defined).
     * @param serviceLevelNumber
     * @return 
     */
    public Transaction serviceLevelNumber(Integer serviceLevelNumber) {
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
     * Sets the service level number (user-defined).
     * @param serviceLevelNumber 
     */
    public void setServiceLevelNumber(Integer serviceLevelNumber) {
        this.serviceLevelNumber = serviceLevelNumber;
    }

    /**
     * Sets the list of states for tax exclusions.
     * @param exclusions
     * @return 
     */
    public Transaction exclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
        return this;
    }

    /**
     * Adds an Exclusion to this transaction.
     * @param exclusionsItem Exclusion object.
     * @return 
     */
    public Transaction addExclusionsItem(Exclusion exclusionsItem) {
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
     * Sets the list of states for tax exclusions.
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
    public Transaction categoryExemptions(List<CategoryExemption> categoryExemptions) {
        this.categoryExemptions = categoryExemptions;
        return this;
    }

    /**
     * Adds a category exemption to this transaction.
     * @param categoryExemptionsItem CategoryExemption object.
     * @return 
     */
    public Transaction addCategoryExemptionsItem(CategoryExemption categoryExemptionsItem) {
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
    public Transaction optionalFields(List<OptionalField> optionalFields) {
        this.optionalFields = optionalFields;
        return this;
    }

    /**
     * Adds an OptionalField to the transaction.
     * @param optionalFieldsItem OptionalField object to add.
     * @return 
     */
    public Transaction addOptionalFieldsItem(OptionalField optionalFieldsItem) {
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

    /**
     * Sets value indicating if the charge of this transaction is tax-inclusive 
     * (reverse tax calculation).
     * @param taxInclusive
     * @return 
     */
    public Transaction taxInclusive(Boolean taxInclusive) {
        this.taxInclusive = taxInclusive;
        return this;
    }

    /**
     * Indicates if the charge of this transaction is tax-inclusive (reverse tax
     * calculation).
     * @return taxInclusive
     */
    public Boolean getTaxInclusive() {
        return taxInclusive;
    }

    /**
     * Sets value indicating if the charge of this transaction is tax-inclusive 
     * (reverse tax calculation).
     * @param taxInclusive 
     */
    public void setTaxInclusive(Boolean taxInclusive) {
        this.taxInclusive = taxInclusive;
    }
}
