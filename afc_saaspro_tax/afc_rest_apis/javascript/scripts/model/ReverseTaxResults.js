/**
 * Structure returned when invoking the reverse tax calculation APIs.
 */

function ReverseTaxResults() {

    this.BaseSaleAmount = 0;
    this.Taxes = [];

    /**
     * Sets the base sale amount necessary to arrive at desired total tax.
     * @param baseSaleAmount Number
     * @return Reference to this object for method chaining. 
     */
    this.baseSaleAmount = function (baseSaleAmount) {
        this.BaseSaleAmount = baseSaleAmount;
        return this;
    }

    /**
     * Base sale amount necessary to arrive at desired total tax.
     * @return Number
     */
    this.getBaseSaleAmount = function () {
        return this.BaseSaleAmount;
    }

    /* Reference to this object for method chaining.*
     * Sets the base sale amount necessary to arrive at desired total tax.
     * @param baseSaleAmount Number 
     */
    this.setBaseSaleAmount = function (baseSaleAmount) {
        this.BaseSaleAmount = baseSaleAmount;
    }

    /**
     * Sets the taxes generated for the transaction.
     * @param taxes Array of TaxData
     * @return Reference to this object for method chaining. 
     */
    this.taxes = function (taxes) {
        this.Taxes = taxes;
        return this;
    }

    /**
     * Adds a TaxData item to this results object.
     * @param taxesItem TaxData object.
     * @return Reference to this object for method chaining. 
     */
    this.addTaxesItem = function (taxesItem) {
        this.Taxes.push(taxesItem);
        return this;
    }

    /**
     * Taxes generated for the transaction.
     * @return Array of TaxData
     */
    this.getTaxes = function () {
        return this.Taxes;
    }

    /* Reference to this object for method chaining.*
     * Sets the taxes generated for the transaction.
     * @param taxes Array of TaxData 
     */
    this.setTaxes = function (taxes) {
        this.Taxes = taxes;
    }
}
