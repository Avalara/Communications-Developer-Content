package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Information used for looking up jurisdictions using location names and/or zip codes.
 */
public class ZipAddress {

    @SerializedName("CountryISO")
    private String countryISO = null;

    @SerializedName("County")
    private String county = null;

    @SerializedName("Locality")
    private String locality = null;

    @SerializedName("State")
    private String state = null;

    @SerializedName("ZipCode")
    private String zipCode = null;

    @SerializedName("ZipP4")
    private String zipP4 = null;

    /**
     * Sets the three-character country ISO code.
     * @param countryISO
     * @return 
     */
    public ZipAddress countryISO(String countryISO) {
        this.countryISO = countryISO;
        return this;
    }

    /**
     * Three-character country ISO code.
     * @return countryISO
     */
    public String getCountryISO() {
        return countryISO;
    }

    /**
     * Sets the three-character country ISO code.
     * @param countryISO 
     */
    public void setCountryISO(String countryISO) {
        this.countryISO = countryISO;
    }

    /**
     * Sets the county name.
     * @param county
     * @return 
     */
    public ZipAddress county(String county) {
        this.county = county;
        return this;
    }

    /**
     * County name.
     * @return county
     */
    public String getCounty() {
        return county;
    }

    /**
     * Sets the county name.
     * @param county 
     */
    public void setCounty(String county) {
        this.county = county;
    }
    
    /**
     * Sets the locality name.
     * @param locality
     * @return 
     */
    public ZipAddress locality(String locality) {
        this.locality = locality;
        return this;
    }

    /**
     * Locality name.
     * @return locality
     */
    public String getLocality() {
        return locality;
    }

    /**
     * Sets the locality name.
     * @param locality 
     */
    public void setLocality(String locality) {
        this.locality = locality;
    }

    /**
     * Sets the two-character state abbreviation.
     * @param state
     * @return 
     */
    public ZipAddress state(String state) {
        this.state = state;
        return this;
    }

    /**
     * Two-character state abbreviation.
     * @return state
     */
    public String getState() {
        return state;
    }

    /**
     * Sets the two-character state abbreviation.
     * @param state 
     */
    public void setState(String state) {
        this.state = state;
    }
    
    /**
     * Sets the zip code for the location.
     * @param zipCode
     * @return 
     */
    public ZipAddress zipCode(String zipCode) {
        this.zipCode = zipCode;
        return this;
    }

    /**
     * Zip code for location.
     * @return zipCode
     */
    public String getZipCode() {
        return zipCode;
    }

    /**
     * Sets the zip code for the location.
     * @param zipCode 
     */
    public void setZipCode(String zipCode) {
        this.zipCode = zipCode;
    }
    
    /**
     * Sets the zip + 4 for the location.
     * @param zipP4
     * @return 
     */
    public ZipAddress zipP4(String zipP4) {
        this.zipP4 = zipP4;
        return this;
    }

    /**
     * Zip + 4 for location.
     * @return zipP4
     */
    public String getZipP4() {
        return zipP4;
    }

    /**
     * Sets the zip + 4 for the location.
     * @param zipP4 
     */
    public void setZipP4(String zipP4) {
        this.zipP4 = zipP4;
    }
}
