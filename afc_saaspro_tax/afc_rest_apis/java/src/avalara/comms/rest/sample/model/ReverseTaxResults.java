package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Structure returned when invoking the reverse tax calculation APIs.
 */
public class ReverseTaxResults {

    @SerializedName("BaseSaleAmount")
    private Double baseSaleAmount = null;

    @SerializedName("Taxes")
    private List<TaxData> taxes = new ArrayList<>();

    /**
     * Sets the base sale amount necessary to arrive at desired total tax.
     * @param baseSaleAmount
     * @return 
     */
    public ReverseTaxResults baseSaleAmount(Double baseSaleAmount) {
        this.baseSaleAmount = baseSaleAmount;
        return this;
    }

    /**
     * Base sale amount necessary to arrive at desired total tax.
     * @return baseSaleAmount
     */
    public Double getBaseSaleAmount() {
        return baseSaleAmount;
    }

    /**
     * Sets the base sale amount necessary to arrive at desired total tax.
     * @param baseSaleAmount 
     */
    public void setBaseSaleAmount(Double baseSaleAmount) {
        this.baseSaleAmount = baseSaleAmount;
    }

    /**
     * Sets the taxes generated for the transaction.
     * @param taxes
     * @return 
     */
    public ReverseTaxResults taxes(List<TaxData> taxes) {
        this.taxes = taxes;
        return this;
    }

    /**
     * Adds a TaxData item to this results object.
     * @param taxesItem
     * @return 
     */
    public ReverseTaxResults addTaxesItem(TaxData taxesItem) {
        this.taxes.add(taxesItem);
        return this;
    }

    /**
     * Taxes generated for the transaction.
     * @return taxes
     */
    public List<TaxData> getTaxes() {
        return taxes;
    }

    /**
     * Sets the taxes generated for the transaction.
     * @param taxes 
     */
    public void setTaxes(List<TaxData> taxes) {
        this.taxes = taxes;
    }
}
