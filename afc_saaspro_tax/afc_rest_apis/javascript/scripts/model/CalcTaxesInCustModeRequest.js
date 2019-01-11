/**
 * Parameter for CustMode/CalcTaxesInCustMode API.
 */

function CalcTaxesInCustModeRequest() {

    this.Transactions = [];
    this.Adjustments = [];
    this.Exclusions = [];
    this.ReturnDetail = false;

    /**
     * Sets the list of transactions to process.
     * @param transactions Array of Transaction
     * @return Reference to this object for method chaining. 
     */
    this.transactions = function (transactions) {
        this.Transactions = transactions;
        return this;
    }

    /**
     * Adds a transaction to this request for processing.
     * @param transactionsItem Transaction object.
     * @return Reference to this object for method chaining. 
     */
    this.addTransactionsItem = function (transactionsItem) {
        this.Transactions.push(transactionsItem);
        return this;
    }

    /**
     * List of transactions to process.
     * @return Array of Transaction
     */
    this.getTransactions = function () {
        return this.Transactions;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of transactions to process.
     * @param transactions Array of Transaction 
     */
    this.setTransactions = function (transactions) {
        this.Transactions = transactions;
    }

    /**
     * Sets the list of adjustments to process.
     * @param adjustments Array of Transaction
     * @return Reference to this object for method chaining. 
     */
    this.adjustments = function (adjustments) {
        this.Adjustments = adjustments;
        return this;
    }

    /**
     * Adds an adjustment to this request for processing.
     * @param adjustmentsItem Transaction object.
     * @return Reference to this object for method chaining. 
     */
    this.addAdjustmentsItem = function (adjustmentsItem) {
        this.Adjustments.push(adjustmentsItem);
        return this;
    }

    /**
     * List of adjustments to process.
     * @return Array of Transaction
     */
    this.getAdjustments = function () {
        return this.Adjustments;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of adjustments to process.
     * @param adjustments Array of Transaction 
     */
    this.setAdjustments = function (adjustments) {
        this.Adjustments = adjustments;
    }

    /**
     * Sets the list of states for tax exclusions.
     * @param exclusions Array of Exclusion
     * @return Reference to this object for method chaining. 
     */
    this.exclusions = function (exclusions) {
        this.Exclusions = exclusions;
        return this;
    }

    /**
     * Adds an exclusion to this request.
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
     * Sets the list of states for tax exclusions.
     * @param exclusions Array of Exclusion 
     */
    this.setExclusions = function (exclusions) {
        this.Exclusions = exclusions;
    }

    /**
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail Boolean
     * @return Reference to this object for method chaining. 
     */
    this.returnDetail = function (returnDetail) {
        this.ReturnDetail = returnDetail;
        return this;
    }

    /**
     * Indicates if the individual transaction taxes should be returned in the
     * response.
     * @return Boolean
     */
    this.getReturnDetail = function () {
        return this.ReturnDetail;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail Boolean 
     */
    this.setReturnDetail = function (returnDetail) {
        this.ReturnDetail = returnDetail;
    }
}
