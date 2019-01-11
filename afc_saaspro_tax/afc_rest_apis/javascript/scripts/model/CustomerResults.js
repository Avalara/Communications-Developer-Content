/**
 * Data structure returned when processing transactions in customer mode.
 */

function CustomerResults() {

    this.Taxes = [];
    this.SummarizedTaxes = [];

    /**
     * Sets the individual taxes for each transaction.
     * @param taxes Array of TaxData
     * @return Reference to this object for method chaining.
     */
    this.taxes = function (taxes) {
        this.Taxes = taxes;
        return this;
    }

    /**
     * Adds a tax to the individual transaction tax list.
     * @param taxesItem TaxData object.
     * @return Reference to this object for method chaining.
     */
    this.addTaxesItem = function (taxesItem) {
        this.Taxes.push(taxesItem);
        return this;
    }

    /**
     * Individual taxes for each transaction.
     * @return Array of TaxData
     */
    this.getTaxes = function () {
        return this.Taxes;
    }

    /* Reference to this object for method chaining.*
     * Sets the individual taxes for each transaction.
     * @param taxes Array of TaxData
     */
    this.setTaxes = function (taxes) {
        this.Taxes = taxes;
    }

    /**
     * Sets the summarized taxes for customer the batch.
     * @param summarizedTaxes Array of CustomerTaxData
     * @return Reference to this object for method chaining.
     */
    this.summarizedTaxes = function (summarizedTaxes) {
        this.SummarizedTaxes = summarizedTaxes;
        return this;
    }

    /**
     * Adds a tax to the summarized tax list for the customer batch.
     * @param summarizedTaxesItem CustomerTaxData object.
     * @return Reference to this object for method chaining.
     */
    this.addSummarizedTaxesItem = function (summarizedTaxesItem) {
        this.SummarizedTaxes.push(summarizedTaxesItem);
        return this;
    }

    /**
     * Summarized taxes for customer batch.
     * @return Array of CustomerTaxData
     */
    this.getSummarizedTaxes = function () {
        return this.SummarizedTaxes;
    }

    /* Reference to this object for method chaining.*
     * Sets the summarized taxes for the customer batch.
     * @param summarizedTaxes Array of CustomerTaxData
     */
    this.setSummarizedTaxes = function (summarizedTaxes) {
        this.SummarizedTaxes = summarizedTaxes;
    }
}
