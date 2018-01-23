/**
 * Contains tax rate information for a tax bracket.
 */

function TaxBracketInfo() {

    this.Rate = 0;
    this.MaxBase = 0;
    this.CountyOverrideTax = 0;
    this.StateOverrideTax = 0;
    this.StateOverrideOn = false;
    this.CountyOverrideOn = false;

    /**
     * Sets the tax rate. Value cannot be negative. For rated taxes, value must 
     * be from 0 to 1. Otherwise, value may be larger.
     * @param rate Number
     * @return Reference to this object for method chaining. 
     */
    this.rate = function (rate) {
        this.Rate = rate;
        return this;
    }

    /**
     * Tax rate. Value cannot be negative. For rated taxes, value must be from 0
     * to 1. Otherwise, value may be larger.
     * @return Number
     */
    this.getRate = function () {
        return this.Rate;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax rate. Value cannot be negative. For rated taxes, value must 
     * be from 0 to 1. Otherwise, value may be larger.
     * @param rate Number 
     */
    this.setRate = function (rate) {
        this.Rate = rate;
    }

    /**
     * Sets the maximum base that this rate applies to.
     * @param maxBase Number
     * @return Reference to this object for method chaining. 
     */
    this.maxBase = function (maxBase) {
        this.MaxBase = maxBase;
        return this;
    }

    /**
     * Maximum base that this rate applies to.
     * @return Number
     */
    this.getMaxBase = function () {
        return this.MaxBase;
    }

    /* Reference to this object for method chaining.*
     * Sets the maximum base that this rate applies to.
     * @param maxBase Number 
     */
    this.setMaxBase = function (maxBase) {
        this.MaxBase = maxBase;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the county level.
     * @param countyOverrideTax Number
     * @return Reference to this object for method chaining. 
     */
    this.countyOverrideTax = function (countyOverrideTax) {
        this.CountyOverrideTax = countyOverrideTax;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the county level.
     * @return Number
     */
    this.getCountyOverrideTax = function () {
        return this.CountyOverrideTax;
    }

    /* Reference to this object for method chaining.*
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the county level.
     * @param countyOverrideTax Number 
     */
    this.setCountyOverrideTax = function (countyOverrideTax) {
        this.CountyOverrideTax = countyOverrideTax;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the state level.
     * @param stateOverrideTax Number
     * @return Reference to this object for method chaining. 
     */
    this.stateOverrideTax = function (stateOverrideTax) {
        this.StateOverrideTax = stateOverrideTax;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the state level.
     * @return Number
     */
    this.getStateOverrideTax = function () {
        return this.StateOverrideTax;
    }

    /* Reference to this object for method chaining.*
     * For sales and use taxes only (tax types 1 and 49), overrides the rate for
     * the tax at the state level.
     * @param stateOverrideTax Number 
     */
    this.setStateOverrideTax = function (stateOverrideTax) {
        this.StateOverrideTax = stateOverrideTax;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the state level.
     * @param stateOverrideOn Boolean
     * @return Reference to this object for method chaining. 
     */
    this.stateOverrideOn = function (stateOverrideOn) {
        this.StateOverrideOn = stateOverrideOn;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49) indicates that this tax
     * replaces the tax at the state level.
     * @return Boolean
     */
    this.getStateOverrideOn = function () {
        return this.StateOverrideOn;
    }

    /* Reference to this object for method chaining.*
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the state level.
     * @param stateOverrideOn Boolean 
     */
    this.setStateOverrideOn = function (stateOverrideOn) {
        this.StateOverrideOn = stateOverrideOn;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the county level.
     * @param countyOverrideOn Boolean
     * @return Reference to this object for method chaining. 
     */
    this.countyOverrideOn = function (countyOverrideOn) {
        this.CountyOverrideOn = countyOverrideOn;
        return this;
    }

    /**
     * For sales and use taxes only (tax types 1 and 49), indicates that this
     * tax replaces the tax at the county level.
     * @return Boolean
     */
    this.getCountyOverrideOn = function () {
        return this.CountyOverrideOn;
    }

    /* Reference to this object for method chaining.*
     * For sales and use taxes only (tax types 1 and 49), sets a value indicating 
     * that this tax replaces the tax at the county level.
     * @param countyOverrideOn Boolean 
     */
    this.setCountyOverrideOn = function (countyOverrideOn) {
        this.CountyOverrideOn = countyOverrideOn;
    }
}
