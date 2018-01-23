package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Parameter for CustMode/CalcTaxesInCustMode API.
 */
public class CalcTaxesInCustModeRequest {

    @SerializedName("Transactions")
    private List<Transaction> transactions = new ArrayList<>();

    @SerializedName("Adjustments")
    private List<Transaction> adjustments = new ArrayList<>();

    @SerializedName("Exclusions")
    private List<Exclusion> exclusions = new ArrayList<>();

    @SerializedName("ReturnDetail")
    private Boolean returnDetail = null;

    /**
     * Sets the list of transactions to process.
     * @param transactions
     * @return 
     */
    public CalcTaxesInCustModeRequest transactions(List<Transaction> transactions) {
        this.transactions = transactions;
        return this;
    }

    /**
     * Adds a transaction to this request for processing.
     * @param transactionsItem
     * @return 
     */
    public CalcTaxesInCustModeRequest addTransactionsItem(Transaction transactionsItem) {
        this.transactions.add(transactionsItem);
        return this;
    }

    /**
     * List of transactions to process.
     * @return transactions
     */
    public List<Transaction> getTransactions() {
        return transactions;
    }

    /**
     * Sets the list of transactions to process.
     * @param transactions 
     */
    public void setTransactions(List<Transaction> transactions) {
        this.transactions = transactions;
    }

    /**
     * Sets the list of adjustments to process.
     * @param adjustments
     * @return 
     */
    public CalcTaxesInCustModeRequest adjustments(List<Transaction> adjustments) {
        this.adjustments = adjustments;
        return this;
    }

    /**
     * Adds an adjustment to this request for processing.
     * @param adjustmentsItem
     * @return 
     */
    public CalcTaxesInCustModeRequest addAdjustmentsItem(Transaction adjustmentsItem) {
        this.adjustments.add(adjustmentsItem);
        return this;
    }

    /**
     * List of adjustments to process.
     * @return adjustments
     */
    public List<Transaction> getAdjustments() {
        return adjustments;
    }

    /**
     * Sets the list of adjustments to process.
     * @param adjustments 
     */
    public void setAdjustments(List<Transaction> adjustments) {
        this.adjustments = adjustments;
    }

    /**
     * Sets the list of states for tax exclusions.
     * @param exclusions
     * @return 
     */
    public CalcTaxesInCustModeRequest exclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
        return this;
    }

    /**
     * Adds an exclusion to this request.
     * @param exclusionsItem
     * @return 
     */
    public CalcTaxesInCustModeRequest addExclusionsItem(Exclusion exclusionsItem) {
        this.exclusions.add(exclusionsItem);
        return this;
    }

    /**
     * List of states for tax exclusions.
     * @return exclusions
     */
    public List<Exclusion> getExclusions() {
        return exclusions;
    }

    /**
     * Sets the list of states for tax exclusions.
     * @param exclusions 
     */
    public void setExclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
    }

    /**
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail
     * @return 
     */
    public CalcTaxesInCustModeRequest returnDetail(Boolean returnDetail) {
        this.returnDetail = returnDetail;
        return this;
    }

    /**
     * Indicates if the individual transaction taxes should be returned in the
     * response.
     * @return returnDetail
     */
    public Boolean getReturnDetail() {
        return returnDetail;
    }

    /**
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail 
     */
    public void setReturnDetail(Boolean returnDetail) {
        this.returnDetail = returnDetail;
    }
}
