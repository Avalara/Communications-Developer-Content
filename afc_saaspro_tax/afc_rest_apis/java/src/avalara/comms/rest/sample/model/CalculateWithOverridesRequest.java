package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Parameter for the tax calculation with override APIs.
 */
public class CalculateWithOverridesRequest {

    @SerializedName("Transaction")
    private Transaction transaction = null;

    @SerializedName("Overrides")
    private List<TaxRateOverrideInfo> overrides = new ArrayList<>();

    /**
     * Sets the transaction data.
     * @param transaction
     * @return 
     */
    public CalculateWithOverridesRequest transaction(Transaction transaction) {
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
     * Sets the transaction data.
     * @param transaction 
     */
    public void setTransaction(Transaction transaction) {
        this.transaction = transaction;
    }

    /**
     * Sets the list of tax rate overrides to be applied in tax calculations.
     * @param overrides
     * @return 
     */
    public CalculateWithOverridesRequest overrides(List<TaxRateOverrideInfo> overrides) {
        this.overrides = overrides;
        return this;
    }

    /**
     * Adds an tax rate override to this request.
     * @param overridesItem
     * @return 
     */
    public CalculateWithOverridesRequest addOverride(TaxRateOverrideInfo overridesItem) {
        this.overrides.add(overridesItem);
        return this;
    }

    /**
     * List of tax rate overrides to be applied in tax calculations.
     * @return overrides
     */
    public List<TaxRateOverrideInfo> getOverrides() {
        return overrides;
    }

    /**
     * Sets the list of tax rate overrides to be applied in tax calculations.
     * @param overrides 
     */
    public void setOverrides(List<TaxRateOverrideInfo> overrides) {
        this.overrides = overrides;
    }
}
