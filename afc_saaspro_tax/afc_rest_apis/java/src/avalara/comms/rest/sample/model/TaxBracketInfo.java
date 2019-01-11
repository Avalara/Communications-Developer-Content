package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Contains tax rate information for a tax bracket.
 */
public class TaxBracketInfo {

    @SerializedName("Rate")
    private Double rate = null;

    @SerializedName("MaxBase")
    private Double maxBase = null;

    @SerializedName("CountyOverrideTax")
    private Double countyOverrideTax = null;

    @SerializedName("StateOverrideTax")
    private Double stateOverrideTax = null;

    @SerializedName("StateOverrideOn")
    private Boolean stateOverrideOn = null;

    @SerializedName("CountyOverrideOn")
    private Boolean countyOverrideOn = null;

    /**
     * Sets the tax rate. Value cannot be negative. For rated taxes, value must 
     * be from 0 to 1. Otherwise, value may be larger.
     * @param rate
     * @return 
     */
    public TaxBracketInfo rate(Double rate) {
        this.rate = rate;
        return this;
    }

    /**
     * Tax rate. Value cannot be negative. For rated taxes, value must be from 0
     * to 1. Otherwise, value may be larger.
     * @return rate
     */
    public Double getRate() {
        return rate;
    }

    /**
     * Sets the tax rate. Value cannot be negative. For rated taxes, value must 
     * be from 0 to 1. Otherwise, value may be larger.
     * @param rate 
     */
    public void setRate(Double rate) {
        this.rate = rate;
    }

    /**
     * Sets the maximum base that this rate applies to.
     * @param maxBase
     * @return 
     */
    public TaxBracketInfo maxBase(Double maxBase) {
        this.maxBase = maxBase;
        return this;
    }

    /**
     * Maximum base that this rate applies to.
     * @return maxBase
     */
    public Double getMaxBase() {
        return maxBase;
    }

    /**
     * Sets the maximum base that this rate applies to.
     * @param maxBase 
     */
    public void setMaxBase(Double maxBase) {
        this.maxBase = maxBase;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the county level.
     * @param countyOverrideTax
     * @return 
     */
    public TaxBracketInfo countyOverrideTax(Double countyOverrideTax) {
        this.countyOverrideTax = countyOverrideTax;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the county level.
     * @return countyOverrideTax
     */
    public Double getCountyOverrideTax() {
        return countyOverrideTax;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the county level.
     * @param countyOverrideTax 
     */
    public void setCountyOverrideTax(Double countyOverrideTax) {
        this.countyOverrideTax = countyOverrideTax;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the state level.
     * @param stateOverrideTax
     * @return 
     */
    public TaxBracketInfo stateOverrideTax(Double stateOverrideTax) {
        this.stateOverrideTax = stateOverrideTax;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the state level.
     * @return stateOverrideTax
     */
    public Double getStateOverrideTax() {
        return stateOverrideTax;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the state level.
     * @param stateOverrideTax 
     */
    public void setStateOverrideTax(Double stateOverrideTax) {
        this.stateOverrideTax = stateOverrideTax;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the state level.
     * @param stateOverrideOn
     * @return 
     */
    public TaxBracketInfo stateOverrideOn(Boolean stateOverrideOn) {
        this.stateOverrideOn = stateOverrideOn;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49) indicates that this tax
     * replaces the tax at the state level.
     * @return stateOverrideOn=
     */
    public Boolean getStateOverrideOn() {
        return stateOverrideOn;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the state level.
     * @param stateOverrideOn 
     */
    public void setStateOverrideOn(Boolean stateOverrideOn) {
        this.stateOverrideOn = stateOverrideOn;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the county level.
     * @param countyOverrideOn
     * @return 
     */
    public TaxBracketInfo countyOverrideOn(Boolean countyOverrideOn) {
        this.countyOverrideOn = countyOverrideOn;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), indicates that this
     * tax replaces the tax at the county level.
     * @return countyOverrideOn
     */
    public Boolean getCountyOverrideOn() {
        return countyOverrideOn;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the county level.
     * @param countyOverrideOn 
     */
    public void setCountyOverrideOn(Boolean countyOverrideOn) {
        this.countyOverrideOn = countyOverrideOn;
    }
}
