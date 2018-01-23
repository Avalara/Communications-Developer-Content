package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Summarized tax data for a customer returned when using the customer mode API.
 */
public class CustomerTaxData {

    @SerializedName("PCode")
    private Integer pCode = null;

    @SerializedName("TaxType")
    private Integer taxType = null;

    @SerializedName("TaxLevel")
    private Integer taxLevel = null;

    @SerializedName("CalculationType")
    private Integer calculationType = null;

    @SerializedName("Rate")
    private Double rate = null;

    @SerializedName("TaxAmount")
    private Double taxAmount = null;

    @SerializedName("ExemptSaleAmount")
    private Double exemptSaleAmount = null;

    @SerializedName("Description")
    private String description = null;

    @SerializedName("Surcharge")
    private Integer surcharge = null;

    @SerializedName("MaxBase")
    private Double maxBase = null;

    @SerializedName("MinBase")
    private Double minBase = null;

    @SerializedName("ExcessTax")
    private Double excessTax = null;

    @SerializedName("TotalCharge")
    private Double totalCharge = null;

    @SerializedName("CategoryID")
    private Integer categoryID = null;

    @SerializedName("CategoryDescription")
    private String categoryDescription = null;

    @SerializedName("Lines")
    private Integer lines = null;

    @SerializedName("Locations")
    private Integer locations = null;

    @SerializedName("Minutes")
    private Double minutes = null;

    /**
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode
     * @return
     */
    public CustomerTaxData pCode(Integer pCode) {
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
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid tax types.
     * @param taxType
     * @return
     */
    public CustomerTaxData taxType(Integer taxType) {
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
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's
     * Manual for a list of valid tax levels.
     * @param taxLevel
     * @return
     */
    public CustomerTaxData taxLevel(Integer taxLevel) {
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
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses
     * User's Manual for a list of valid calculation types.
     * @param calculationType
     * @return
     */
    public CustomerTaxData calculationType(Integer calculationType) {
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
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses
     * User's Manual for a list of valid calculation types.
     * @param calculationType
     */
    public void setCalculationType(Integer calculationType) {
        this.calculationType = calculationType;
    }

    /**
     * Sets the tax rate.
     * @param rate
     * @return
     */
    public CustomerTaxData rate(Double rate) {
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
     * Sets the tax amount.
     * @param taxAmount
     * @return
     */
    public CustomerTaxData taxAmount(Double taxAmount) {
        this.taxAmount = taxAmount;
        return this;
    }

    /**
     * Tax amount.
     * @return taxAmount
     */
    public Double getTaxAmount() {
        return taxAmount;
    }

    /**
     * Sets the tax amount.
     * @param taxAmount
     */
    public void setTaxAmount(Double taxAmount) {
        this.taxAmount = taxAmount;
    }

    /**
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount
     * @return
     */
    public CustomerTaxData exemptSaleAmount(Double exemptSaleAmount) {
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
     * Sets the tax description.
     * @param description
     * @return
     */
    public CustomerTaxData description(String description) {
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
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge
     * @return
     */
    public CustomerTaxData surcharge(Integer surcharge) {
        this.surcharge = surcharge;
        return this;
    }

    /**
     * Indicates if tax is considered a surcharge.
     * @return surcharge
     */
    public Integer getSurcharge() {
        return surcharge;
    }

    /**
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge
     */
    public void setSurcharge(Integer surcharge) {
        this.surcharge = surcharge;
    }

    /**
     * Sets the max amount to which tax is applied.
     * @param maxBase
     * @return
     */
    public CustomerTaxData maxBase(Double maxBase) {
        this.maxBase = maxBase;
        return this;
    }

    /**
     * Max amount to which tax is applied.
     * @return maxBase
     */
    public Double getMaxBase() {
        return maxBase;
    }

    /**
     * Sets the max amount to which tax is applied.
     * @param maxBase
     */
    public void setMaxBase(Double maxBase) {
        this.maxBase = maxBase;
    }

    /**
     * Sets the min amount to which tax is applied.
     * @param minBase
     * @return
     */
    public CustomerTaxData minBase(Double minBase) {
        this.minBase = minBase;
        return this;
    }

    /**
     * Min amount to which tax is applied.
     * @return minBase
     */
    public Double getMinBase() {
        return minBase;
    }

    /**
     * Sets the min amount to which tax is applied.
     * @param minBase
     */
    public void setMinBase(Double minBase) {
        this.minBase = minBase;
    }

    /**
     * Sets the rate for amount above max base.
     * @param excessTax
     * @return
     */
    public CustomerTaxData excessTax(Double excessTax) {
        this.excessTax = excessTax;
        return this;
    }

    /**
     * Rate for amount above max base.
     * @return excessTax
     */
    public Double getExcessTax() {
        return excessTax;
    }

    /**
     * Sets the rate for amount above max base.
     * @param excessTax
     */
    public void setExcessTax(Double excessTax) {
        this.excessTax = excessTax;
    }

    /**
     * Sets the total charge for this tax.
     * @param totalCharge
     * @return
     */
    public CustomerTaxData totalCharge(Double totalCharge) {
        this.totalCharge = totalCharge;
        return this;
    }

    /**
     * Sum of charges for this customer.
     * @return totalCharge
     */
    public Double getTotalCharge() {
        return totalCharge;
    }

    /**
     * Sets the total charge for this tax.
     * @param totalCharge
     */
    public void setTotalCharge(Double totalCharge) {
        this.totalCharge = totalCharge;
    }

    /**
     * Sets the tax category ID.
     * @param categoryID
     * @return
     */
    public CustomerTaxData categoryID(Integer categoryID) {
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
     * Sets the tax category description.
     * @param categoryDescription
     * @return
     */
    public CustomerTaxData categoryDescription(String categoryDescription) {
        this.categoryDescription = categoryDescription;
        return this;
    }

    /**
     * Tax category description.
     * @return categoryDescription
     */
    public String getCategoryDescription() {
        return categoryDescription;
    }

    /**
     * Sets the tax category description.
     * @param categoryDescription
     */
    public void setCategoryDescription(String categoryDescription) {
        this.categoryDescription = categoryDescription;
    }

    /**
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines
     * @return
     */
    public CustomerTaxData lines(Integer lines) {
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
    public CustomerTaxData locations(Integer locations) {
        this.locations = locations;
        return this;
    }

    /**
     * Sum of locations from customer input.
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
    public CustomerTaxData minutes(Double minutes) {
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
}
