package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Parameter for the CustMode/CalcTaxes and CustMode/CalcAdj APIs.
 */
public class CustModeTransaction {

    @SerializedName("CustBatchID")
    private Long custBatchID = null;

    @SerializedName("Transaction")
    private Transaction transaction = null;

    /**
     * Sets the customer batch identifier.
     * @param custBatchID
     * @return 
     */
    public CustModeTransaction custBatchID(Long custBatchID) {
        this.custBatchID = custBatchID;
        return this;
    }

    /**
     * Customer batch identifier.
     * @return custBatchID
     */
    public Long getCustBatchID() {
        return custBatchID;
    }

    /**
     * Sets the customer batch identifier.
     * @param custBatchID 
     */
    public void setCustBatchID(Long custBatchID) {
        this.custBatchID = custBatchID;
    }

    /**
     * Sets the transaction to include into the customer batch.
     * @param transaction
     * @return 
     */
    public CustModeTransaction transaction(Transaction transaction) {
        this.transaction = transaction;
        return this;
    }

    /**
     * Transaction to include into the customer batch.
     * @return transaction
     */
    public Transaction getTransaction() {
        return transaction;
    }

    /**
     * Sets the transaction to include into the customer batch.
     * @param transaction 
     */
    public void setTransaction(Transaction transaction) {
        this.transaction = transaction;
    }
}
