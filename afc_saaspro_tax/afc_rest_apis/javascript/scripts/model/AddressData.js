/**
 * Contains location and zip code range information for a jurisdiction.
 */

function AddressData() {

    this.CountryISO = "";
    this.County = "";
    this.Locality = "";
    this.State = "";
    this.TaxLevel = 0;
    this.ZipBegin = "";
    this.ZipEnd = "";
    this.ZipP4Begin = "";
    this.ZipP4End = "";

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
     * Sets the tax level ID.
     * @param taxLevel Number
     * @return Reference to this object for method chaining. 
     */
    this.taxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level ID.
     * @return Number
     */
    this.getTaxLevel = function () {
        return this.TaxLevel;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax level ID.
     * @param taxLevel Number 
     */
    this.setTaxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
    }

    /**
     * Sets the start of the Zip code range.
     * @param zipBegin String
     * @return Reference to this object for method chaining. 
     */
    this.zipBegin = function (zipBegin) {
        this.ZipBegin = zipBegin;
        return this;
    }

    /**
     * Begin of Zip code range.
     * @return String
     */
    this.getZipBegin = function () {
        return this.ZipBegin;
    }

    /* Reference to this object for method chaining.*
     * Sets the start of the Zip code range.
     * @param zipBegin String 
     */
    this.setZipBegin = function (zipBegin) {
        this.ZipBegin = zipBegin;
    }

    /**
     * Sets the end of the Zip code range.
     * @param zipEnd String
     * @return Reference to this object for method chaining. 
     */
    this.zipEnd = function (zipEnd) {
        this.ZipEnd = zipEnd;
        return this;
    }

    /**
     * End of Zip code range.
     * @return String
     */
    this.getZipEnd = function () {
        return this.ZipEnd;
    }

    /* Reference to this object for method chaining.*
     * Sets the end of the Zip code range.
     * @param zipEnd String 
     */
    this.setZipEnd = function (zipEnd) {
        this.ZipEnd = zipEnd;
    }

    /**
     * Sets the start of the Zip+4 code range.
     * @param zipP4Begin String
     * @return Reference to this object for method chaining. 
     */
    this.zipP4Begin = function (zipP4Begin) {
        this.ZipP4Begin = zipP4Begin;
        return this;
    }

    /**
     * Begin of Zip+4 code range.
     * @return String
     */
    this.getZipP4Begin = function () {
        return this.ZipP4Begin;
    }

    /* Reference to this object for method chaining.*
     * Sets the start of the Zip+4 code range.
     * @param zipP4Begin String
     */
    this.setZipP4Begin = function (zipP4Begin) {
        this.ZipP4Begin = zipP4Begin;
    }

    /**
     * Sets the end of the Zip+4 code range.
     * @param zipP4End String
     * @return Reference to this object for method chaining.
     */
    this.zipP4End = function (zipP4End) {
        this.ZipP4End = zipP4End;
        return this;
    }

    /**
     * End of Zip+4 code range.
     * @return String
     */
    this.getZipP4End = function () {
        return this.ZipP4End;
    }

    /* Reference to this object for method chaining.*
     * Sets the end of the Zip+4 code range.
     * @param zipP4End String
     */
    this.setZipP4End = function (zipP4End) {
        this.ZipP4End = zipP4End;
    }
}
