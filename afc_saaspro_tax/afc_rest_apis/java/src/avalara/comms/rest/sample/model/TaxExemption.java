package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Contains information for exemption a single tax.
 */
public class TaxExemption {

    @SerializedName("PCode")
    private Integer pCode = null;

    @SerializedName("TaxLevel")
    private Integer taxLevel = null;

    @SerializedName("TaxType")
    private Integer taxType = null;

    /**
     * Sets the PCode for the jurisdiction to exempt.
     * @param pCode
     * @return 
     */
    public TaxExemption pCode(Integer pCode) {
        this.pCode = pCode;
        return this;
    }

    /**
     * PCode for jurisdiction to exempt.
     * @return pCode
     */
    public Integer getPCode() {
        return pCode;
    }

    /**
     * Sets the PCode for the jurisdiction to exempt.
     * @param pCode 
     */
    public void setPCode(Integer pCode) {
        this.pCode = pCode;
    }

    /**
     * Sets the tax level for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
     * @param taxLevel
     * @return 
     */
    public TaxExemption taxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax levels.
     * @return taxLevel
     */
    public Integer getTaxLevel() {
        return taxLevel;
    }

    /**
     * Sets the tax level for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax levels.
     * @param taxLevel 
     */
    public void setTaxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
    }

    /**
     * Sets the tax type for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
     * @param taxType
     * @return 
     */
    public TaxExemption taxType(Integer taxType) {
        this.taxType = taxType;
        return this;
    }

    /**
     * Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax types.
     * @return taxType
     */
    public Integer getTaxType() {
        return taxType;
    }

    /**
     * Sets the tax type for the exemption. See the 
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid tax types.
     * @param taxType 
     */
    public void setTaxType(Integer taxType) {
        this.taxType = taxType;
    }
}
