package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Tax information returned from tax calculation APIs.
 */
public class TaxData {

    @SerializedName("AdjustmentType")
    private Integer adjustmentType = null;

    @SerializedName("Billable")
    private Boolean billable = null;

    @SerializedName("CalculationType")
    private Integer calculationType = null;

    @SerializedName("CategoryDescription")
    private String categoryDescription = null;

    @SerializedName("CategoryID")
    private Integer categoryID = null;

    @SerializedName("CompanyIdentifier")
    private String companyIdentifier = null;

    @SerializedName("Compliance")
    private Boolean compliance = null;

    @SerializedName("CustomerNumber")
    private String customerNumber = null;

    @SerializedName("Description")
    private String description = null;

    @SerializedName("ExemptionType")
    private Integer exemptionType = null;

    @SerializedName("ExemptSaleAmount")
    private Double exemptSaleAmount = null;

    @SerializedName("InvoiceNumber")
    private Integer invoiceNumber = null;

    @SerializedName("Optional")
    private Integer optional = null;

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

    @SerializedName("PCode")
    private Integer pCode = null;

    @SerializedName("Rate")
    private Double rate = null;

    @SerializedName("RefundUncollect")
    private Double refundUncollect = null;

    @SerializedName("ServiceLevelNumber")
    private Integer serviceLevelNumber = null;

    @SerializedName("Surcharge")
    private Boolean surcharge = null;

    @SerializedName("TaxableMeasure")
    private Double taxableMeasure = null;

    @SerializedName("TaxAmount")
    private Double taxAmount = null;

    @SerializedName("TaxLevel")
    private Integer taxLevel = null;

    @SerializedName("TaxType")
    private Integer taxType = null;

    @SerializedName("Lines")
    private Integer lines = null;

    @SerializedName("Locations")
    private Integer locations = null;

    @SerializedName("Minutes")
    private Double minutes = null;

    @SerializedName("OptionalFields")
    private List<OptionalField> optionalFields = new ArrayList<>();

    @SerializedName("TransCharge")
    private Double transCharge = null;

    /**
     * Sets the adjustment type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment types.
     * @param adjustmentType
     * @return 
     */
    public TaxData adjustmentType(Integer adjustmentType) {
        this.adjustmentType = adjustmentType;
        return this;
    }

    /**
     * Adjustment type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid adjustment types.
     * @return adjustmentType
     */
    public Integer getAdjustmentType() {
        return adjustmentType;
    }

    /**
     * Sets the adjustment type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment types.
     * @param adjustmentType 
     */
    public void setAdjustmentType(Integer adjustmentType) {
        this.adjustmentType = adjustmentType;
    }

    /**
     * Sets a value indicating if the tax is billable to the customer.
     * @param billable
     * @return 
     */
    public TaxData billable(Boolean billable) {
        this.billable = billable;
        return this;
    }

    /**
     * Indicates if the tax is billable to the customer.
     * @return billable
     */
    public Boolean getBillable() {
        return billable;
    }

    /**
     * Sets a value indicating if the tax is billable to the customer.
     * @param billable 
     */
    public void setBillable(Boolean billable) {
        this.billable = billable;
    }

    /**
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid calculation types.
     * @param calculationType
     * @return 
     */
    public TaxData calculationType(Integer calculationType) {
        this.calculationType = calculationType;
        return this;
    }

    /**
     * Calculation type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid calculation types.
     * @return calculationType
     */
    public Integer getCalculationType() {
        return calculationType;
    }

    /**
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid calculation types.
     * @param calculationType 
     */
    public void setCalculationType(Integer calculationType) {
        this.calculationType = calculationType;
    }

    /**
     * Sets the tax Category Description.
     * @param categoryDescription
     * @return 
     */
    public TaxData categoryDescription(String categoryDescription) {
        this.categoryDescription = categoryDescription;
        return this;
    }

    /**
     * Tax Category Description.
     * @return categoryDescription
     */
    public String getCategoryDescription() {
        return categoryDescription;
    }

    /**
     * Sets the tax Category Description.
     * @param categoryDescription 
     */
    public void setCategoryDescription(String categoryDescription) {
        this.categoryDescription = categoryDescription;
    }

    /**
     * Sets the tax category ID.
     * @param categoryID
     * @return 
     */
    public TaxData categoryID(Integer categoryID) {
        this.categoryID = categoryID;
        return this;
    }

    /**
     * Tax category ID.
     * @return categoryID
     */
    public Integer getCategoryID() {
        return categoryID;
    }
    
    /**
     * Sets the tax category ID.
     * @param categoryID 
     */
    public void setCategoryID(Integer categoryID) {
        this.categoryID = categoryID;
    }

    /**
     * Sets the customer identifier.
     * @param companyIdentifier
     * @return 
     */
    public TaxData companyIdentifier(String companyIdentifier) {
        this.companyIdentifier = companyIdentifier;
        return this;
    }

    /**
     * Customer identifier from transaction input.
     * @return companyIdentifier
     */
    public String getCompanyIdentifier() {
        return companyIdentifier;
    }

    /**
     * Sets the customer identifier.
     * @param companyIdentifier 
     */
    public void setCompanyIdentifier(String companyIdentifier) {
        this.companyIdentifier = companyIdentifier;
    }

    /**
     * Sets a value indicating if the tax is reportable to the jurisdiction.
     * @param compliance
     * @return 
     */
    public TaxData compliance(Boolean compliance) {
        this.compliance = compliance;
        return this;
    }

    /**
     * Indicates if the tax is reportable to the jurisdiction.
     * @return compliance
     */
    public Boolean getCompliance() {
        return compliance;
    }

    /**
     * Sets a value indicating if the tax is reportable to the jurisdiction.
     * @param compliance 
     */
    public void setCompliance(Boolean compliance) {
        this.compliance = compliance;
    }

    /**
     * Sets the user-defined customer number.
     * @param customerNumber
     * @return 
     */
    public TaxData customerNumber(String customerNumber) {
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
     * Sets the user-defined customer number.
     * @param customerNumber 
     */
    public void setCustomerNumber(String customerNumber) {
        this.customerNumber = customerNumber;
    }

    /**
     * Sets the tax description.
     * @param description
     * @return 
     */
    public TaxData description(String description) {
        this.description = description;
        return this;
    }

    /**
     * Tax description.
     * @return description
     */
    public String getDescription() {
        return description;
    }

    /**
     * Sets the tax description.
     * @param description 
     */
    public void setDescription(String description) {
        this.description = description;
    }

    /**
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType
     * @return 
     */
    public TaxData exemptionType(Integer exemptionType) {
        this.exemptionType = exemptionType;
        return this;
    }

    /**
     * Exemption type from transaction input. See the
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid
     * exemption types.
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
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount
     * @return 
     */
    public TaxData exemptSaleAmount(Double exemptSaleAmount) {
        this.exemptSaleAmount = exemptSaleAmount;
        return this;
    }

    /**
     * Amount of the charge exempt from taxes.
     * @return exemptSaleAmount
     */
    public Double getExemptSaleAmount() {
        return exemptSaleAmount;
    }

    /**
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount 
     */
    public void setExemptSaleAmount(Double exemptSaleAmount) {
        this.exemptSaleAmount = exemptSaleAmount;
    }

    /**
     * Sets the user-defined invoice number.
     * @param invoiceNumber
     * @return 
     */
    public TaxData invoiceNumber(Integer invoiceNumber) {
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
     * Sets the user-defined invoice number.
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
    public TaxData optional(Integer optional) {
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
     * Sets an optional user-defined string value.
     * @param optionalAlpha1
     * @return 
     */
    public TaxData optionalAlpha1(String optionalAlpha1) {
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
    public TaxData optional4(Integer optional4) {
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
    public TaxData optional5(Integer optional5) {
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
    public TaxData optional6(Integer optional6) {
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
    public TaxData optional7(Integer optional7) {
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
    public TaxData optional8(Integer optional8) {
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
    public TaxData optional9(Integer optional9) {
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
    public TaxData optional10(Integer optional10) {
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
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode
     * @return 
     */
    public TaxData pCode(Integer pCode) {
        this.pCode = pCode;
        return this;
    }

    /**
     * PCode for the reporting jurisdiction.
     * @return pCode
     */
    public Integer getPCode() {
        return pCode;
    }

    /**
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode 
     */
    public void setPCode(Integer pCode) {
        this.pCode = pCode;
    }

    /**
     * Sets the tax rate.
     * @param rate
     * @return 
     */
    public TaxData rate(Double rate) {
        this.rate = rate;
        return this;
    }

    /**
     * Tax rate.
     * @return rate
     */
    public Double getRate() {
        return rate;
    }

    /**
     * Sets the tax rate.
     * @param rate 
     */
    public void setRate(Double rate) {
        this.rate = rate;
    }

    /**
     * Sets the refund uncollect value.
     * @param refundUncollect
     * @return 
     */
    public TaxData refundUncollect(Double refundUncollect) {
        this.refundUncollect = refundUncollect;
        return this;
    }

    /**
     * Taxable measure if tax is smaller than 0 (tax adjustments).
     * @return refundUncollect
     */
    public Double getRefundUncollect() {
        return refundUncollect;
    }

    /**
     * Sets the refund uncollect value.
     * @param refundUncollect 
     */
    public void setRefundUncollect(Double refundUncollect) {
        this.refundUncollect = refundUncollect;
    }

    /**
     * Sets the user-defined service level number.
     * @param serviceLevelNumber
     * @return 
     */
    public TaxData serviceLevelNumber(Integer serviceLevelNumber) {
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
     * Sets the user-defined service level number.
     * @param serviceLevelNumber 
     */
    public void setServiceLevelNumber(Integer serviceLevelNumber) {
        this.serviceLevelNumber = serviceLevelNumber;
    }

    /**
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge
     * @return 
     */
    public TaxData surcharge(Boolean surcharge) {
        this.surcharge = surcharge;
        return this;
    }

    /**
     * Indicates if tax is considered a surcharge.
     * @return surcharge
     */
    public Boolean getSurcharge() {
        return surcharge;
    }

    /**
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge 
     */
    public void setSurcharge(Boolean surcharge) {
        this.surcharge = surcharge;
    }

    /**
     * Sets the amount of sale subject to tax plus any taxed taxes.
     * @param taxableMeasure
     * @return 
     */
    public TaxData taxableMeasure(Double taxableMeasure) {
        this.taxableMeasure = taxableMeasure;
        return this;
    }

    /**
     * Amount of sale subject to tax plus any taxed taxes.
     * @return taxableMeasure
     */
    public Double getTaxableMeasure() {
        return taxableMeasure;
    }

    /**
     * Sets the amount of sale subject to tax plus any taxed taxes.
     * @param taxableMeasure 
     */
    public void setTaxableMeasure(Double taxableMeasure) {
        this.taxableMeasure = taxableMeasure;
    }

    /**
     * Sets the calculated tax amount.
     * @param taxAmount
     * @return 
     */
    public TaxData taxAmount(Double taxAmount) {
        this.taxAmount = taxAmount;
        return this;
    }

    /**
     * Calculated tax amount.
     * @return taxAmount
     */
    public Double getTaxAmount() {
        return taxAmount;
    }

    /**
     * Sets the calculated tax amount.
     * @param taxAmount 
     */
    public void setTaxAmount(Double taxAmount) {
        this.taxAmount = taxAmount;
    }

    /**
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid tax levels.
     * @param taxLevel
     * @return 
     */
    public TaxData taxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax levels.
     * @return taxLevel
     */
    public Integer getTaxLevel() {
        return taxLevel;
    }

    /**
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid tax levels.
     * @param taxLevel 
     */
    public void setTaxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType
     * @return 
     */
    public TaxData taxType(Integer taxType) {
        this.taxType = taxType;
        return this;
    }

    /**
     * Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax types.
     * @return taxType
     */
    public Integer getTaxType() {
        return taxType;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType 
     */
    public void setTaxType(Integer taxType) {
        this.taxType = taxType;
    }

    /**
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines
     * @return 
     */
    public TaxData lines(Integer lines) {
        this.lines = lines;
        return this;
    }

    /**
     * Number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @return lines
     */
    public Integer getLines() {
        return lines;
    }

    /**
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines 
     */
    public void setLines(Integer lines) {
        this.lines = lines;
    }

    /**
     * Sets the number of locations.
     * @param locations
     * @return 
     */
    public TaxData locations(Integer locations) {
        this.locations = locations;
        return this;
    }

    /**
     * Number of locations from transaction input.
     * @return locations
     */
    public Integer getLocations() {
        return locations;
    }

    /**
     * Sets the number of locations.
     * @param locations 
     */
    public void setLocations(Integer locations) {
        this.locations = locations;
    }

    /**
     * Sets the number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @param minutes
     * @return 
     */
    public TaxData minutes(Double minutes) {
        this.minutes = minutes;
        return this;
    }

    /**
     * Number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @return minutes
     */
    public Double getMinutes() {
        return minutes;
    }

    /**
     * Sets the number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @param minutes 
     */
    public void setMinutes(Double minutes) {
        this.minutes = minutes;
    }

    /**
     * Sets the user-defined list of optional alphanumeric fields.
     * @param optionalFields
     * @return 
     */
    public TaxData optionalFields(List<OptionalField> optionalFields) {
        this.optionalFields = optionalFields;
        return this;
    }

    /**
     * Sets the user-defined list of optional alphanumeric fields.
     * @param optionalFieldsItem
     * @return 
     */
    public TaxData addOptionalFieldsItem(OptionalField optionalFieldsItem) {
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
     * Sets the user-defined list of optional alphanumeric fields.
     * @param optionalFields 
     */
    public void setOptionalFields(List<OptionalField> optionalFields) {
        this.optionalFields = optionalFields;
    }

    /**
     * Sets the transaction charge amount.
     * @param transCharge
     * @return 
     */
    public TaxData transCharge(Double transCharge) {
        this.transCharge = transCharge;
        return this;
    }

    /**
     * Transaction charge amount.
     * @return transCharge
     */
    public Double getTransCharge() {
        return transCharge;
    }

    /**
     * Sets the transaction charge amount.
     * @param transCharge 
     */
    public void setTransCharge(Double transCharge) {
        this.transCharge = transCharge;
    }
}
