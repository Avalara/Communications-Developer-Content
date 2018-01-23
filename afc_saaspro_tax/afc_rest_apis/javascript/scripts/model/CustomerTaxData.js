/**
 * Summarized tax data for a customer returned when using the customer mode API.
 */

function CustomerTaxData() {

    this.PCode = 0;
    this.TaxType = 0;
    this.TaxLevel = 0;
    this.CalculationType = 0;
    this.Rate = 0;
    this.TaxAmount = 0;
    this.ExemptSaleAmount = 0;
    this.Description = "";
    this.Surcharge = 0;
    this.MaxBase = 0;
    this.MinBase = 0;
    this.ExcessTax = 0;
    this.TotalCharge = 0;
    this.CategoryID = 0;
    this.CategoryDescription = "";
    this.Lines = 0;
    this.Locations = 0;
    this.Minutes = 0;

    /**
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode Number
     * @return Reference to this object for method chaining.
     */
    this.pCode = function (pCode) {
        this.PCode = pCode;
        return this;
    }

    /**
     * PCode for the reporting jurisdiction.
     * @return Number
     */
    this.getPCode = function () {
        return this.PCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode Number
     */
    this.setPCode = function (pCode) {
        this.PCode = pCode;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid tax types.
     * @param taxType Number
     * @return Reference to this object for method chaining.
     */
    this.taxType = function (taxType) {
        this.TaxType = taxType;
        return this;
    }

    /**
     * Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax types.
     * @return Number
     */
    this.getTaxType = function () {
        return this.TaxType;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid tax types.
     * @param taxType Number
     */
    this.setTaxType = function (taxType) {
        this.TaxType = taxType;
    }

    /**
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's
     * Manual for a list of valid tax levels.
     * @param taxLevel Number
     * @return Reference to this object for method chaining.
     */
    this.taxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax levels.
     * @return Number
     */
    this.getTaxLevel = function () {
        return this.TaxLevel;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's
     * Manual for a list of valid tax levels.
     * @param taxLevel Number
     */
    this.setTaxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
    }

    /**
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses
     * User's Manual for a list of valid calculation types.
     * @param calculationType Number
     * @return Reference to this object for method chaining.
     */
    this.calculationType = function (calculationType) {
        this.CalculationType = calculationType;
        return this;
    }

    /**
     * Calculation type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid calculation types.
     * @return Number
     */
    this.getCalculationType = function () {
        return this.CalculationType;
    }

    /* Reference to this object for method chaining.*
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses
     * User's Manual for a list of valid calculation types.
     * @param calculationType Number
     */
    this.setCalculationType = function (calculationType) {
        this.CalculationType = calculationType;
    }

    /**
     * Sets the tax rate.
     * @param rate Number
     * @return Reference to this object for method chaining.
     */
    this.rate = function (rate) {
        this.Rate = rate;
        return this;
    }

    /**
     * Tax rate.
     * @return Number
     */
    this.getRate = function () {
        return this.Rate;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax rate.
     * @param rate Number
     */
    this.setRate = function (rate) {
        this.Rate = rate;
    }

    /**
     * Sets the tax amount.
     * @param taxAmount Number
     * @return Reference to this object for method chaining.
     */
    this.taxAmount = function (taxAmount) {
        this.TaxAmount = taxAmount;
        return this;
    }

    /**
     * Tax amount.
     * @return Number
     */
    this.getTaxAmount = function () {
        return this.TaxAmount;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax amount.
     * @param taxAmount Number
     */
    this.setTaxAmount = function (taxAmount) {
        this.TaxAmount = taxAmount;
    }

    /**
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount Number
     * @return Reference to this object for method chaining.
     */
    this.exemptSaleAmount = function (exemptSaleAmount) {
        this.ExemptSaleAmount = exemptSaleAmount;
        return this;
    }

    /**
     * Amount of the charge exempt from taxes.
     * @return Number
     */
    this.getExemptSaleAmount = function () {
        return this.ExemptSaleAmount;
    }

    /* Reference to this object for method chaining.*
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount Number
     */
    this.setExemptSaleAmount = function (exemptSaleAmount) {
        this.ExemptSaleAmount = exemptSaleAmount;
    }

    /**
     * Sets the tax description.
     * @param description String
     * @return Reference to this object for method chaining.
     */
    this.description = function (description) {
        this.Description = description;
        return this;
    }

    /**
     * Tax description.
     * @return String
     */
    this.getDescription = function () {
        return this.Description;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax description.
     * @param description String
     */
    this.setDescription = function (description) {
        this.Description = description;
    }

    /**
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge Number
     * @return Reference to this object for method chaining.
     */
    this.surcharge = function (surcharge) {
        this.Surcharge = surcharge;
        return this;
    }

    /**
     * Indicates if tax is considered a surcharge.
     * @return Number
     */
    this.getSurcharge = function () {
        return this.Surcharge;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge Number
     */
    this.setSurcharge = function (surcharge) {
        this.Surcharge = surcharge;
    }

    /**
     * Sets the max amount to which tax is applied.
     * @param maxBase Number
     * @return Reference to this object for method chaining.
     */
    this.maxBase = function (maxBase) {
        this.MaxBase = maxBase;
        return this;
    }

    /**
     * Max amount to which tax is applied.
     * @return Number
     */
    this.getMaxBase = function () {
        return this.MaxBase;
    }

    /* Reference to this object for method chaining.*
     * Sets the max amount to which tax is applied.
     * @param maxBase Number
     */
    this.setMaxBase = function (maxBase) {
        this.MaxBase = maxBase;
    }

    /**
     * Sets the min amount to which tax is applied.
     * @param minBase Number
     * @return Reference to this object for method chaining.
     */
    this.minBase = function (minBase) {
        this.MinBase = minBase;
        return this;
    }

    /**
     * Min amount to which tax is applied.
     * @return Number
     */
    this.getMinBase = function () {
        return this.MinBase;
    }

    /* Reference to this object for method chaining.*
     * Sets the min amount to which tax is applied.
     * @param minBase Number
     */
    this.setMinBase = function (minBase) {
        this.MinBase = minBase;
    }

    /**
     * Sets the rate for amount above max base.
     * @param excessTax Number
     * @return Reference to this object for method chaining.
     */
    this.excessTax = function (excessTax) {
        this.ExcessTax = excessTax;
        return this;
    }

    /**
     * Rate for amount above max base.
     * @return Number
     */
    this.getExcessTax = function () {
        return this.ExcessTax;
    }

    /* Reference to this object for method chaining.*
     * Sets the rate for amount above max base.
     * @param excessTax Number
     */
    this.setExcessTax = function (excessTax) {
        this.ExcessTax = excessTax;
    }

    /**
     * Sets the total charge for this tax.
     * @param totalCharge Number
     * @return Reference to this object for method chaining.
     */
    this.totalCharge = function (totalCharge) {
        this.TotalCharge = totalCharge;
        return this;
    }

    /**
     * Sum of charges for this customer.
     * @return Number
     */
    this.getTotalCharge = function () {
        return this.TotalCharge;
    }

    /* Reference to this object for method chaining.*
     * Sets the total charge for this tax.
     * @param totalCharge Number
     */
    this.setTotalCharge = function (totalCharge) {
        this.TotalCharge = totalCharge;
    }

    /**
     * Sets the tax category ID.
     * @param categoryID Number
     * @return Reference to this object for method chaining.
     */
    this.categoryID = function (categoryID) {
        this.CategoryID = categoryID;
        return this;
    }

    /**
     * Tax category ID.
     * @return Number
     */
    this.getCategoryID = function () {
        return this.CategoryID;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax category ID.
     * @param categoryID Number
     */
    this.setCategoryID = function (categoryID) {
        this.CategoryID = categoryID;
    }

    /**
     * Sets the tax category description.
     * @param categoryDescription String
     * @return Reference to this object for method chaining.
     */
    this.categoryDescription = function (categoryDescription) {
        this.CategoryDescription = categoryDescription;
        return this;
    }

    /**
     * Tax category description.
     * @return String
     */
    this.getCategoryDescription = function () {
        return this.CategoryDescription;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax category description.
     * @param categoryDescription String
     */
    this.setCategoryDescription = function (categoryDescription) {
        this.CategoryDescription = categoryDescription;
    }

    /**
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines Number
     * @return Reference to this object for method chaining.
     */
    this.lines = function (lines) {
        this.Lines = lines;
        return this;
    }

    /**
     * Number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @return Number
     */
    this.getLines = function () {
        return this.Lines;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines Number
     */
    this.setLines = function (lines) {
        this.Lines = lines;
    }

    /**
     * Sets the number of locations.
     * @param locations Number
     * @return Reference to this object for method chaining.
     */
    this.locations = function (locations) {
        this.Locations = locations;
        return this;
    }

    /**
     * Sum of locations from customer input.
     * @return Number
     */
    this.getLocations = function () {
        return this.Locations;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of locations.
     * @param locations Number
     */
    this.setLocations = function (locations) {
        this.Locations = locations;
    }

    /**
     * Sets the number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @param minutes Number
     * @return Reference to this object for method chaining.
     */
    this.minutes = function (minutes) {
        this.Minutes = minutes;
        return this;
    }

    /**
     * Number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @return Number
     */
    this.getMinutes = function () {
        return this.Minutes;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @param minutes Number
     */
    this.setMinutes = function (minutes) {
        this.Minutes = minutes;
    }
}
