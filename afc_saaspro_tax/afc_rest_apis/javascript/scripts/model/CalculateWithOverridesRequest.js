/**
 * Parameter for the tax calculation with override APIs.
 */

function CalculateWithOverridesRequest() {

    this.Transaction = null;
    this.Overrides = [];

    /**
     * Sets the transaction data.
     * @param transaction Transaction object.
     * @return Reference to this object for method chaining. 
     */
    this.transaction = function (transaction) {
        this.Transaction = transaction;
        return this;
    }

    /**
     * Transaction data.
     * @return Transaction object.
     */
    this.getTransaction = function () {
        return this.Transaction;
    }

    /* Reference to this object for method chaining.*
     * Sets the transaction data.
     * @param transaction Transaction object. 
     */
    this.setTransaction = function (transaction) {
        this.Transaction = transaction;
    }

    /**
     * Sets the list of tax rate overrides to be applied in tax calculations.
     * @param overrides Array of TaxRateOverrideInfo
     * @return Reference to this object for method chaining. 
     */
    this.overrides = function (overrides) {
        this.Overrides = overrides;
        return this;
    }

    /**
     * Adds an tax rate override to this request.
     * @param overridesItem TaxRateOverrideInfo object.
     * @return Reference to this object for method chaining. 
     */
    this.addOverride = function (overridesItem) {
        this.Overrides.push(overridesItem);
        return this;
    }

    /**
     * List of tax rate overrides to be applied in tax calculations.
     * @return Array of TaxRateOverrideInfo
     */
    this.getOverrides = function () {
        return this.Overrides;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of tax rate overrides to be applied in tax calculations.
     * @param overrides Array of TaxRateOverrideInfo 
     */
    this.setOverrides = function (overrides) {
        this.Overrides = overrides;
    }
}
