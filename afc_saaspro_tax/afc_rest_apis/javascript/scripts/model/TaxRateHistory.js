/**
 * Historical tax rate information for a tax.
 */

function TaxRateHistory() {

    this.EffectiveDate = new Date(0);
    this.LevelExemptible = false;
    this.BracketInfo = [];

    /**
     * Sets the effective date for the tax rate.
     * @param effectiveDate Date
     * @return Reference to this object for method chaining. 
     */
    this.effectiveDate = function (effectiveDate) {
        this.EffectiveDate = effectiveDate;
        return this;
    }

    /**
     * Effective date for rate.
     * @return Date
     */
    this.getEffectiveDate = function () {
        return this.EffectiveDate;
    }

    /* Reference to this object for method chaining.*
     * Sets the effective date for the tax rate.
     * @param effectiveDate Date 
     */
    this.setEffectiveDate = function (effectiveDate) {
        this.EffectiveDate = effectiveDate;
    }

    /**
     * Sets a value indicating if the tax can be exempted using level exemptions.
     * @param levelExemptible Boolean
     * @return Reference to this object for method chaining. 
     */
    this.levelExemptible = function (levelExemptible) {
        this.LevelExemptible = levelExemptible;
        return this;
    }

    /**
     * Indicates if the tax can be exempted using level exemptions.
     * @return Boolean
     */
    this.getLevelExemptible = function () {
        return this.LevelExemptible;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the tax can be exempted using level exemptions.
     * @param levelExemptible Boolean 
     */
    this.setLevelExemptible = function (levelExemptible) {
        this.LevelExemptible = levelExemptible;
    }

    /**
     * Sets the list of tax rate or bracket information.
     * @param bracketInfo Array of TaxBracketInfo
     * @return Reference to this object for method chaining. 
     */
    this.bracketInfo = function (bracketInfo) {
        this.BracketInfo = bracketInfo;
        return this;
    }

    /**
     * Adds a bracket to this tax rate history record.
     * @param bracketInfoItem TaxBracketInfo object.
     * @return Reference to this object for method chaining. 
     */
    this.addBracketInfoItem = function (bracketInfoItem) {
        this.BracketInfo.push(bracketInfoItem);
        return this;
    }

    /**
     * Tax rate/bracket information.
     * @return Array of TaxBracketInfo
     */
    this.getBracketInfo = function () {
        return this.BracketInfo;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of tax rate or bracket information.
     * @param bracketInfo Array of TaxBracketInfo 
     */
    this.setBracketInfo = function (bracketInfo) {
        this.BracketInfo = bracketInfo;
    }
}
