/**
 * Contains information required to override a tax rate.
 */

function TaxRateOverrideInfo() {

    this.Pcode = 0;
    this.Scope = 0;
    this.TaxType = 0;
    this.TaxLevel = 0;
    this.LevelExemptible = false;
    this.BracketInfo = [];

    /**
     * Sets the jurisdiction PCode for this tax rate override.
     * @param pcode Number
     * @return Reference to this object for method chaining. 
     */
    this.pcode = function (pcode) {
        this.Pcode = pcode;
        return this;
    }

    /**
     * Jurisdiction PCode for this tax rate override.
     * @return Number
     */
    this.getPcode = function () {
        return this.Pcode;
    }

    /* Reference to this object for method chaining.*
     * Sets the jurisdiction PCode for this tax rate override.
     * @param pcode Number 
     */
    this.setPcode = function (pcode) {
        this.Pcode = pcode;
    }

    /**
     * Sets the scope for the override. See tax levels in the
     * CommsPlatform.API.WrapperClasses User's Manual for valid values.
     * @param scope Number
     * @return Reference to this object for method chaining. 
     */
    this.scope = function (scope) {
        this.Scope = scope;
        return this;
    }

    /**
     * Scope for override. See tax levels in the
     * CommsPlatform.API.WrapperClasses User's Manual for valid values.
     * @return Number
     */
    this.getScope = function () {
        return this.Scope;
    }

    /* Reference to this object for method chaining.*
     * Sets the scope for the override. See tax levels in the
     * CommsPlatform.API.WrapperClasses User's Manual for valid values.
     * @param scope Number 
     */
    this.setScope = function (scope) {
        this.Scope = scope;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType Number
     * @return Reference to this object for method chaining. 
     */
    this.taxType = function (taxType) {
        this.TaxType = taxType;
        return this;
    }

    /**
     * Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax types.
     * @return Number
     */
    this.getTaxType = function () {
        return this.TaxType;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType Number 
     */
    this.setTaxType = function (taxType) {
        this.TaxType = taxType;
    }

    /**
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax levels.
     * @param taxLevel Number
     * @return Reference to this object for method chaining. 
     */
    this.taxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax levels.
     * @return Number
     */
    this.getTaxLevel = function () {
        return this.TaxLevel;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax levels.
     * @param taxLevel Number 
     */
    this.setTaxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
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
     * Adds a tax bracket to this override.
     * @param bracketInfoItem TaxBracketInfo object.
     * @return Reference to this object for method chaining. 
     */
    this.addBracket = function (bracketInfoItem) {
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
