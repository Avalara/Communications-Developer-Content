/**
 * Parameter for the CustMode/CalcTaxes and CustMode/CalcAdj APIs.
 */

function CustModeTransaction() {

    this.CustBatchID = 0;
    this.Transaction = null;

    /**
     * Sets the customer batch identifier.
     * @param custBatchID Number
     * @return Reference to this object for method chaining. 
     */
    this.custBatchID = function (custBatchID) {
        this.CustBatchID = custBatchID;
        return this;
    }

    /**
     * Customer batch identifier.
     * @return Number
     */
    this.getCustBatchID = function () {
        return this.CustBatchID;
    }

    /* Reference to this object for method chaining.*
     * Sets the customer batch identifier.
     * @param custBatchID Number 
     */
    this.setCustBatchID = function (custBatchID) {
        this.CustBatchID = custBatchID;
    }

    /**
     * Sets the transaction to include into the customer batch.
     * @param transaction Transaction object.
     * @return Reference to this object for method chaining. 
     */
    this.transaction = function (transaction) {
        this.Transaction = transaction;
        return this;
    }

    /**
     * Transaction to include into the customer batch.
     * @return Transaction object.
     */
    this.getTransaction = function () {
        return this.Transaction;
    }

    /* Reference to this object for method chaining.*
     * Sets the transaction to include into the customer batch.
     * @param transaction Transaction object. 
     */
    this.setTransaction = function (transaction) {
        this.Transaction = transaction;
    }
}
