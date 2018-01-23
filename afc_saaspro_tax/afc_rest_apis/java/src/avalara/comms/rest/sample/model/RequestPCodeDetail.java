package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Contains location information for PCode conversion.
 */
public class RequestPCodeDetail {

    @SerializedName("FipsCode")
    private String fipsCode = null;

    @SerializedName("NpaNxx")
    private Integer npaNxx = null;

    @SerializedName("ZipAddress")
    private ZipAddress zipAddress = null;

    /**
     * Sets the FIPS code - leave null if other value is used.
     * @param fipsCode
     * @return 
     */
    public RequestPCodeDetail fipsCode(String fipsCode) {
        this.fipsCode = fipsCode;
        return this;
    }

    /**
     * FIPS code - leave null if other value is used.
     * @return fipsCode
     */
    public String getFipsCode() {
        return fipsCode;
    }

    /**
     * Sets the FIPS code - leave null if other value is used.
     * @param fipsCode 
     */
    public void setFipsCode(String fipsCode) {
        this.fipsCode = fipsCode;
    }

    /**
     * Sets the NPANXX - leave null if other value is used.
     * @param npaNxx
     * @return 
     */
    public RequestPCodeDetail npaNxx(Integer npaNxx) {
        this.npaNxx = npaNxx;
        return this;
    }

    /**
     * NPANXX - leave null if other value is used.
     * @return npaNxx
     */
    public Integer getNpaNxx() {
        return npaNxx;
    }

    /**
     * Sets the NPANXX - leave null if other value is used.
     * @param npaNxx 
     */
    public void setNpaNxx(Integer npaNxx) {
        this.npaNxx = npaNxx;
    }

    /**
     * Sets the Zip Address - leave null if other value is used.
     * @param zipAddress
     * @return 
     */
    public RequestPCodeDetail zipAddress(ZipAddress zipAddress) {
        this.zipAddress = zipAddress;
        return this;
    }

    /**
     * Zip Address - leave null if other value is used.
     * @return zipAddress
     */
    public ZipAddress getZipAddress() {
        return zipAddress;
    }

    /**
     * Sets the Zip Address - leave null if other value is used.
     * @param zipAddress 
     */
    public void setZipAddress(ZipAddress zipAddress) {
        this.zipAddress = zipAddress;
    }
}
