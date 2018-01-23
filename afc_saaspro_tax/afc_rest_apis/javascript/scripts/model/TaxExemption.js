/**
 * Contains information for exemption a single tax.
 */

function TaxExemption() {

    this.PCode = 0;
    this.TaxLevel = 0;
    this.TaxType = 0;

    /**
     * Sets the PCode for the jurisdiction to exempt.
     * @param pCode Number
     * @return Reference to this object for method chaining. 
     */
    this.pCode = function (pCode) {
        this.PCode = pCode;
        return this;
    }

    /**
     * PCode for jurisdiction to exempt.
     * @return Number
     */
    this.getPCode = function () {
        return this.PCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode for the jurisdiction to exempt.
     * @param pCode Number 
     */
    this.setPCode = function (pCode) {
        this.PCode = pCode;
    }

    /**
     * Sets the tax level for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
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
     * Sets the tax level for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
     * @param taxLevel Number 
     */
    this.setTaxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
    }

    /**
     * Sets the tax type for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
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
     * Sets the tax type for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
     * @param taxType Number 
     */
    this.setTaxType = function (taxType) {
        this.TaxType = taxType;
    }
}
