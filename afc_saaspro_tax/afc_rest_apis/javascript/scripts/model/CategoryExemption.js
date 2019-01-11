/**
 * Specifies tax exemptions based on the tax category.
 */

function CategoryExemption() {

    this.CountryISO = "";
    this.State = "";
    this.TaxCategory = 0;

    /**
     * Sets the three-character country ISO code. Required if State is not specified.
     * @param countryISO String
     * @return Reference to this object for method chaining. 
     */
    this.countryISO = function (countryISO) {
        this.CountryISO = countryISO;
        return this;
    }

    /**
     * Three-character country ISO code. Required if State is not specified.
     * @return String
     */
    this.getCountryISO = function () {
        return this.CountryISO;
    }

    /* Reference to this object for method chaining.*
     * Sets the three-character country ISO code. Required if State is not specified.
     * @param countryISO String 
     */
    this.setCountryISO = function (countryISO) {
        this.CountryISO = countryISO;
    }

    /**
     * Sets the two-character state abbreviation. Required if CountryISO is not
     * specified.
     * @param state String
     * @return Reference to this object for method chaining. 
     */
    this.state = function (state) {
        this.State = state;
        return this;
    }

    /**
     * Two-character state abbreviation. Required if CountryISO is not
     * specified.
     * @return String
     */
    this.getState = function () {
        return this.State;
    }

    /* Reference to this object for method chaining.*
     * Sets the two-character state abbreviation. Required if CountryISO is not
     * specified.
     * @param state String 
     */
    this.setState = function (state) {
        this.State = state;
    }

    /**
     * Sets the tax category ID. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid tax categories.
     * @param taxCategory Number
     * @return Reference to this object for method chaining. 
     */
    this.taxCategory = function (taxCategory) {
        this.TaxCategory = taxCategory;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid tax
     * categories.
     * @return Number
     */
    this.getTaxCategory = function () {
        return this.TaxCategory;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax category ID. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid tax categories.
     * @param taxCategory Number 
     */
    this.setTaxCategory = function (taxCategory) {
        this.TaxCategory = taxCategory;
    }
}
