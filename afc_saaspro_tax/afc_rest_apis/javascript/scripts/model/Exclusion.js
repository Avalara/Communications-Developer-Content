/**
 * Specifies a tax exclusion by state.
 */

function Exclusion() {

    this.CountryISO = "";
    this.State = "";
    this.ExclusionOn = false;

    /**
     * Sets the three-character country ISO code. Required if State not specified.
     * @param countryISO String
     * @return Reference to this object for method chaining. 
     */
    this.countryISO = function (countryISO) {
        this.CountryISO = countryISO;
        return this;
    }

    /**
     * Three-character country ISO code. Required if State not specified.
     * @return String
     */
    this.getCountryISO = function () {
        return this.CountryISO;
    }

    /* Reference to this object for method chaining.*
     * Sets the three-character country ISO code. Required if State not specified.
     * @param countryISO String 
     */
    this.setCountryISO = function (countryISO) {
        this.CountryISO = countryISO;
    }

    /**
     * Sets the two-character state abbreviation. Required if CountryISO not specified.
     * @param state String
     * @return Reference to this object for method chaining. 
     */
    this.state = function (state) {
        this.State = state;
        return this;
    }

    /**
     * Two-character state abbreviation. Required if CountryISO not specified.
     * @return String
     */
    this.getState = function () {
        return this.State;
    }

    /* Reference to this object for method chaining.*
     * Sets the two-character state abbreviation. Required if CountryISO not specified.
     * @param state String 
     */
    this.setState = function (state) {
        this.State = state;
    }

    /**
     * Sets a value indicating if the exclusion applies in the state.
     * @param exclusionOn Boolean
     * @return Reference to this object for method chaining. 
     */
    this.exclusionOn = function (exclusionOn) {
        this.ExclusionOn = exclusionOn;
        return this;
    }

    /**
     * True if entity exclusion applies in the state, otherwise false.
     * @return Boolean
     */
    this.getExclusionOn = function () {
        return this.ExclusionOn;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the exclusion applies in the state.
     * @param exclusionOn Boolean 
     */
    this.setExclusionOn = function (exclusionOn) {
        this.ExclusionOn = exclusionOn;
    }
}
