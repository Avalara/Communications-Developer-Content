/**
 * Parameter for pro-rated tax calculation API.
 */

function ProRatedTransaction() {

    this.ProRatedPercent = 0;
    this.Transaction = null;

    /**
     * Sets the percentage to prorate specified as a decimal.
     * @param proRatedPercent Number
     * @return Reference to this object for method chaining. 
     */
    this.proRatedPercent = function (proRatedPercent) {
        this.ProRatedPercent = proRatedPercent;
        return this;
    }

    /**
     * Percentage to prorate specified as a decimal.
     * @return Number
     */
    this.getProRatedPercent = function () {
        return this.ProRatedPercent;
    }

    /* Reference to this object for method chaining.*
     * Sets the percentage to prorate specified as a decimal.
     * @param proRatedPercent Number 
     */
    this.setProRatedPercent = function (proRatedPercent) {
        this.ProRatedPercent = proRatedPercent;
    }

    /**
     * Sets the transaction to be processed.
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
     * Sets the transaction to be processed.
     * @param transaction Transaction object. 
     */
    this.setTransaction = function (transaction) {
        this.Transaction = transaction;
    }
}
