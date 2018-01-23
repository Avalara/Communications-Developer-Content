package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Tax rate information for a tax.
 */
public class TaxRateInfo {

    @SerializedName("TaxType")
    private Integer taxType = null;

    @SerializedName("TaxLevel")
    private Integer taxLevel = null;

    @SerializedName("RateHistory")
    private List<TaxRateHistory> rateHistory = new ArrayList<>();

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType
     * @return 
     */
    public TaxRateInfo taxType(Integer taxType) {
        this.taxType = taxType;
        return this;
    }

    /**
     * Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax types.
     * @return taxType
     */
    public Integer getTaxType() {
        return taxType;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType 
     */
    public void setTaxType(Integer taxType) {
        this.taxType = taxType;
    }

    /**
     * Sets the tax level for this tax. See the CommsPlatform.API.WrapperClasses 
     * User's Manual for a list of valid tax levels.
     * @param taxLevel
     * @return 
     */
    public TaxRateInfo taxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax levels.
     * @return taxLevel
     */
    public Integer getTaxLevel() {
        return taxLevel;
    }

    /**
     * Sets the tax level for this tax. See the CommsPlatform.API.WrapperClasses 
     * User's Manual for a list of valid tax levels.
     * @param taxLevel 
     */
    public void setTaxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
    }

    /**
     * Sets the tax rate history.
     * @param rateHistory
     * @return 
     */
    public TaxRateInfo rateHistory(List<TaxRateHistory> rateHistory) {
        this.rateHistory = rateHistory;
        return this;
    }

    /**
     * Adds a tax rate history record for this tax.
     * @param rateHistoryItem
     * @return 
     */
    public TaxRateInfo addRateHistoryItem(TaxRateHistory rateHistoryItem) {
        this.rateHistory.add(rateHistoryItem);
        return this;
    }

    /**
     * Tax rate history.
     * @return rateHistory
     */
    public List<TaxRateHistory> getRateHistory() {
        return rateHistory;
    }

    /**
     * Sets the tax rate history.
     * @param rateHistory 
     */
    public void setRateHistory(List<TaxRateHistory> rateHistory) {
        this.rateHistory = rateHistory;
    }
}
