/**
 * Contains location information for PCode conversion.
 */

function RequestPCodeDetail() {

    this.FipsCode = "";
    this.NpaNxx = 0;
    this.ZipAddress = null;

    /**
     * Sets the FIPS code - leave null if other value is used.
     * @param fipsCode String
     * @return Reference to this object for method chaining. 
     */
    this.fipsCode = function (fipsCode) {
        this.FipsCode = fipsCode;
        return this;
    }

    /**
     * FIPS code - leave null if other value is used.
     * @return String
     */
    this.getFipsCode = function () {
        return this.FipsCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the FIPS code - leave null if other value is used.
     * @param fipsCode String 
     */
    this.setFipsCode = function (fipsCode) {
        this.FipsCode = fipsCode;
    }

    /**
     * Sets the NPANXX - leave null if other value is used.
     * @param npaNxx Number
     * @return Reference to this object for method chaining. 
     */
    this.npaNxx = function (npaNxx) {
        this.NpaNxx = npaNxx;
        return this;
    }

    /**
     * NPANXX - leave null if other value is used.
     * @return Number
     */
    this.getNpaNxx = function () {
        return this.NpaNxx;
    }

    /* Reference to this object for method chaining.*
     * Sets the NPANXX - leave null if other value is used.
     * @param npaNxx Number 
     */
    this.setNpaNxx = function (npaNxx) {
        this.NpaNxx = npaNxx;
    }

    /**
     * Sets the Zip Address - leave null if other value is used.
     * @param zipAddress ZipAddress object.
     * @return Reference to this object for method chaining. 
     */
    this.zipAddress = function (zipAddress) {
        this.ZipAddress = zipAddress;
        return this;
    }

    /**
     * Zip Address - leave null if other value is used.
     * @return ZipAddress object.
     */
    this.getZipAddress = function () {
        return this.ZipAddress;
    }

    /* Reference to this object for method chaining.*
     * Sets the Zip Address - leave null if other value is used.
     * @param zipAddress ZipAddress object. 
     */
    this.setZipAddress = function (zipAddress) {
        this.ZipAddress = zipAddress;
    }
}
