/**
 * Information used for looking up jurisdictions using location names and/or zip codes.
 */

function ZipAddress() {

    this.CountryISO = "";
    this.County = "";
    this.Locality = "";
    this.State = "";
    this.ZipCode = "";
    this.ZipP4 = "";

    /**
     * Sets the three-character country ISO code.
     * @param countryISO String
     * @return Reference to this object for method chaining. 
     */
    this.countryISO = function (countryISO) {
        this.CountryISO = countryISO;
        return this;
    }

    /**
     * Three-character country ISO code.
     * @return String
     */
    this.getCountryISO = function () {
        return this.CountryISO;
    }

    /* Reference to this object for method chaining.*
     * Sets the three-character country ISO code.
     * @param countryISO String 
     */
    this.setCountryISO = function (countryISO) {
        this.CountryISO = countryISO;
    }

    /**
     * Sets the county name.
     * @param county String
     * @return Reference to this object for method chaining. 
     */
    this.county = function (county) {
        this.County = county;
        return this;
    }

    /**
     * County name.
     * @return String
     */
    this.getCounty = function () {
        return this.County;
    }

    /* Reference to this object for method chaining.*
     * Sets the county name.
     * @param county String 
     */
    this.setCounty = function (county) {
        this.County = county;
    }

    /**
     * Sets the locality name.
     * @param locality String
     * @return Reference to this object for method chaining. 
     */
    this.locality = function (locality) {
        this.Locality = locality;
        return this;
    }

    /**
     * Locality name.
     * @return String
     */
    this.getLocality = function () {
        return this.Locality;
    }

    /* Reference to this object for method chaining.*
     * Sets the locality name.
     * @param locality String 
     */
    this.setLocality = function (locality) {
        this.Locality = locality;
    }

    /**
     * Sets the two-character state abbreviation.
     * @param state String
     * @return Reference to this object for method chaining. 
     */
    this.state = function (state) {
        this.State = state;
        return this;
    }

    /**
     * Two-character state abbreviation.
     * @return String
     */
    this.getState = function () {
        return this.State;
    }

    /* Reference to this object for method chaining.*
     * Sets the two-character state abbreviation.
     * @param state String 
     */
    this.setState = function (state) {
        this.State = state;
    }

    /**
     * Sets the zip code for the location.
     * @param zipCode String
     * @return Reference to this object for method chaining. 
     */
    this.zipCode = function (zipCode) {
        this.ZipCode = zipCode;
        return this;
    }

    /**
     * Zip code for location.
     * @return String
     */
    this.getZipCode = function () {
        return this.ZipCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the zip code for the location.
     * @param zipCode String 
     */
    this.setZipCode = function (zipCode) {
        this.ZipCode = zipCode;
    }

    /**
     * Sets the zip + 4 for the location.
     * @param zipP4 String
     * @return Reference to this object for method chaining. 
     */
    this.zipP4 = function (zipP4) {
        this.ZipP4 = zipP4;
        return this;
    }

    /**
     * Zip + 4 for location.
     * @return String
     */
    this.getZipP4 = function () {
        return this.ZipP4;
    }

    /* Reference to this object for method chaining.*
     * Sets the zip + 4 for the location.
     * @param zipP4 String 
     */
    this.setZipP4 = function (zipP4) {
        this.ZipP4 = zipP4;
    }
}
