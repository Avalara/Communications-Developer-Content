package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Parameter for pro-rated tax calculation API.
 */
public class ProRatedTransaction {

    @SerializedName("ProRatedPercent")
    private Double proRatedPercent = null;

    @SerializedName("Transaction")
    private Transaction transaction = null;

    /**
     * Sets the percentage to prorate specified as a decimal.
     * @param proRatedPercent
     * @return 
     */
    public ProRatedTransaction proRatedPercent(Double proRatedPercent) {
        this.proRatedPercent = proRatedPercent;
        return this;
    }

    /**
     * Percentage to prorate specified as a decimal.
     * @return proRatedPercent
     */
    public Double getProRatedPercent() {
        return proRatedPercent;
    }

    /**
     * Sets the percentage to prorate specified as a decimal.
     * @param proRatedPercent 
     */
    public void setProRatedPercent(Double proRatedPercent) {
        this.proRatedPercent = proRatedPercent;
    }

    /**
     * Sets the transaction to be processed.
     * @param transaction
     * @return 
     */
    public ProRatedTransaction transaction(Transaction transaction) {
        this.transaction = transaction;
        return this;
    }

    /**
     * Transaction data.
     * @return transaction
     */
    public Transaction getTransaction() {
        return transaction;
    }

    /**
     * Sets the transaction to be processed.
     * @param transaction 
     */
    public void setTransaction(Transaction transaction) {
        this.transaction = transaction;
    }
}
