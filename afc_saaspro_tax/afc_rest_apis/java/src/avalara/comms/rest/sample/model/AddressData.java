package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Contains location and zip code range information for a jurisdiction.
 */
public class AddressData {

    @SerializedName("CountryISO")
    private String countryISO = null;

    @SerializedName("County")
    private String county = null;

    @SerializedName("Locality")
    private String locality = null;

    @SerializedName("State")
    private String state = null;

    @SerializedName("TaxLevel")
    private Integer taxLevel = null;

    @SerializedName("ZipBegin")
    private String zipBegin = null;

    @SerializedName("ZipEnd")
    private String zipEnd = null;

    @SerializedName("ZipP4Begin")
    private String zipP4Begin = null;

    @SerializedName("ZipP4End")
    private String zipP4End = null;
    
    /**
     * Sets the three-character country ISO code.
     * @param countryISO
     * @return 
     */
    public AddressData countryISO(String countryISO) {
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
    public AddressData county(String county) {
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
    public AddressData locality(String locality) {
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
    public AddressData state(String state) {
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
     * Sets the tax level ID.
     * @param taxLevel
     * @return 
     */
    public AddressData taxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level ID.
     * @return taxLevel
     */
    public Integer getTaxLevel() {
        return taxLevel;
    }

    /**
     * Sets the tax level ID.
     * @param taxLevel 
     */
    public void setTaxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
    }

    /**
     * Sets the start of the Zip code range.
     * @param zipBegin
     * @return 
     */
    public AddressData zipBegin(String zipBegin) {
        this.zipBegin = zipBegin;
        return this;
    }

    /**
     * Begin of Zip code range.
     * @return zipBegin
     */
    public String getZipBegin() {
        return zipBegin;
    }

    /**
     * Sets the start of the Zip code range.
     * @param zipBegin 
     */
    public void setZipBegin(String zipBegin) {
        this.zipBegin = zipBegin;
    }

    /**
     * Sets the end of the Zip code range.
     * @param zipEnd
     * @return 
     */
    public AddressData zipEnd(String zipEnd) {
        this.zipEnd = zipEnd;
        return this;
    }

    /**
     * End of Zip code range.
     * @return zipEnd
     */
    public String getZipEnd() {
        return zipEnd;
    }

    /**
     * Sets the end of the Zip code range.
     * @param zipEnd 
     */
    public void setZipEnd(String zipEnd) {
        this.zipEnd = zipEnd;
    }

    /**
     * Sets the start of the Zip+4 code range.
     * @param zipP4Begin
     * @return 
     */
    public AddressData zipP4Begin(String zipP4Begin) {
        this.zipP4Begin = zipP4Begin;
        return this;
    }

    /**
     * Begin of Zip+4 code range.
     * @return zipP4Begin
     */
    public String getZipP4Begin() {
        return zipP4Begin;
    }

    /**
     * Sets the start of the Zip+4 code range.
     * @param zipP4Begin
     */
    public void setZipP4Begin(String zipP4Begin) {
        this.zipP4Begin = zipP4Begin;
    }

    /**
     * Sets the end of the Zip+4 code range.
     * @param zipP4End
     * @return
     */
    public AddressData zipP4End(String zipP4End) {
        this.zipP4End = zipP4End;
        return this;
    }

    /**
     * End of Zip+4 code range.
     * @return zipP4End
     */
    public String getZipP4End() {
        return zipP4End;
    }

    /**
     * Sets the end of the Zip+4 code range.
     * @param zipP4End
     */
    public void setZipP4End(String zipP4End) {
        this.zipP4End = zipP4End;
    }
}
