/**
 * Tax rate information for a tax.
 */

function TaxRateInfo() {

    this.TaxType = 0;
    this.TaxLevel = 0;
    this.RateHistory = [];

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
     * Sets the tax level for this tax. See the CommsPlatform.API.WrapperClasses 
     * User's Manual for a list of valid tax levels.
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
     * Sets the tax level for this tax. See the CommsPlatform.API.WrapperClasses 
     * User's Manual for a list of valid tax levels.
     * @param taxLevel Number 
     */
    this.setTaxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
    }

    /**
     * Sets the tax rate history.
     * @param rateHistory Array of TaxRateHistory
     * @return Reference to this object for method chaining. 
     */
    this.rateHistory = function (rateHistory) {
        this.RateHistory = rateHistory;
        return this;
    }

    /**
     * Adds a tax rate history record for this tax.
     * @param rateHistoryItem TaxRateHistory object.
     * @return Reference to this object for method chaining. 
     */
    this.addRateHistoryItem = function (rateHistoryItem) {
        this.RateHistory.push(rateHistoryItem);
        return this;
    }

    /**
     * Tax rate history.
     * @return Array of TaxRateHistory
     */
    this.getRateHistory = function () {
        return this.RateHistory;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax rate history.
     * @param rateHistory Array of TaxRateHistory 
     */
    this.setRateHistory = function (rateHistory) {
        this.RateHistory = rateHistory;
    }
}
