package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Data structure returned when processing transactions in customer mode.
 */
public class CustomerResults {

    @SerializedName("Taxes")
    private List<TaxData> taxes = new ArrayList<>();

    @SerializedName("SummarizedTaxes")
    private List<CustomerTaxData> summarizedTaxes = new ArrayList<>();

    /**
     * Sets the individual taxes for each transaction.
     * @param taxes
     * @return
     */
    public CustomerResults taxes(List<TaxData> taxes) {
        this.taxes = taxes;
        return this;
    }

    /**
     * Adds a tax to the individual transaction tax list.
     * @param taxesItem
     * @return
     */
    public CustomerResults addTaxesItem(TaxData taxesItem) {
        this.taxes.add(taxesItem);
        return this;
    }

    /**
     * Individual taxes for each transaction.
     * @return taxes
     */
    public List<TaxData> getTaxes() {
        return taxes;
    }

    /**
     * Sets the individual taxes for each transaction.
     * @param taxes
     */
    public void setTaxes(List<TaxData> taxes) {
        this.taxes = taxes;
    }

    /**
     * Sets the summarized taxes for customer the batch.
     * @param summarizedTaxes
     * @return
     */
    public CustomerResults summarizedTaxes(List<CustomerTaxData> summarizedTaxes) {
        this.summarizedTaxes = summarizedTaxes;
        return this;
    }

    /**
     * Adds a tax to the summarized tax list for the customer batch.
     * @param summarizedTaxesItem
     * @return
     */
    public CustomerResults addSummarizedTaxesItem(CustomerTaxData summarizedTaxesItem) {
        this.summarizedTaxes.add(summarizedTaxesItem);
        return this;
    }

    /**
     * Summarized taxes for customer batch.
     * @return summarizedTaxes
     */
    public List<CustomerTaxData> getSummarizedTaxes() {
        return summarizedTaxes;
    }

    /**
     * Sets the summarized taxes for the customer batch.
     * @param summarizedTaxes
     */
    public void setSummarizedTaxes(List<CustomerTaxData> summarizedTaxes) {
        this.summarizedTaxes = summarizedTaxes;
    }
}
