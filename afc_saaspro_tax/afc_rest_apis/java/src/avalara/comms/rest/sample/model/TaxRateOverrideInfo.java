package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Contains information required to override a tax rate.
 */
public class TaxRateOverrideInfo {

    @SerializedName("Pcode")
    private Integer pcode = null;

    @SerializedName("Scope")
    private Integer scope = null;

    @SerializedName("TaxType")
    private Integer taxType = null;

    @SerializedName("TaxLevel")
    private Integer taxLevel = null;

    @SerializedName("LevelExemptible")
    private Boolean levelExemptible = null;

    @SerializedName("BracketInfo")
    private List<TaxBracketInfo> bracketInfo = new ArrayList<>();

    /**
     * Sets the jurisdiction PCode for this tax rate override.
     * @param pcode
     * @return 
     */
    public TaxRateOverrideInfo pcode(Integer pcode) {
        this.pcode = pcode;
        return this;
    }

    /**
     * Jurisdiction PCode for this tax rate override.
     * @return pcode
     */
    public Integer getPcode() {
        return pcode;
    }

    /**
     * Sets the jurisdiction PCode for this tax rate override.
     * @param pcode 
     */
    public void setPcode(Integer pcode) {
        this.pcode = pcode;
    }

    /**
     * Sets the scope for the override. See tax levels in the
     * CommsPlatform.API.WrapperClasses User's Manual for valid values.
     * @param scope
     * @return 
     */
    public TaxRateOverrideInfo scope(Integer scope) {
        this.scope = scope;
        return this;
    }

    /**
     * Scope for override. See tax levels in the
     * CommsPlatform.API.WrapperClasses User's Manual for valid values.
     * @return scope
     */
    public Integer getScope() {
        return scope;
    }

    /**
     * Sets the scope for the override. See tax levels in the
     * CommsPlatform.API.WrapperClasses User's Manual for valid values.
     * @param scope 
     */
    public void setScope(Integer scope) {
        this.scope = scope;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType
     * @return 
     */
    public TaxRateOverrideInfo taxType(Integer taxType) {
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
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType 
     */
    public void setTaxType(Integer taxType) {
        this.taxType = taxType;
    }

    /**
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax levels.
     * @param taxLevel
     * @return 
     */
    public TaxRateOverrideInfo taxLevel(Integer taxLevel) {
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
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax levels.
     * @param taxLevel 
     */
    public void setTaxLevel(Integer taxLevel) {
        this.taxLevel = taxLevel;
    }

    /**
     * Sets a value indicating if the tax can be exempted using level exemptions.
     * @param levelExemptible
     * @return 
     */
    public TaxRateOverrideInfo levelExemptible(Boolean levelExemptible) {
        this.levelExemptible = levelExemptible;
        return this;
    }

    /**
     * Indicates if the tax can be exempted using level exemptions.
     * @return levelExemptible
     */
    public Boolean getLevelExemptible() {
        return levelExemptible;
    }

    /**
     * Sets a value indicating if the tax can be exempted using level exemptions.
     * @param levelExemptible 
     */
    public void setLevelExemptible(Boolean levelExemptible) {
        this.levelExemptible = levelExemptible;
    }

    /**
     * Sets the list of tax rate or bracket information.
     * @param bracketInfo
     * @return 
     */
    public TaxRateOverrideInfo bracketInfo(List<TaxBracketInfo> bracketInfo) {
        this.bracketInfo = bracketInfo;
        return this;
    }

    /**
     * Adds a tax bracket to this override.
     * @param bracketInfoItem
     * @return 
     */
    public TaxRateOverrideInfo addBracket(TaxBracketInfo bracketInfoItem) {
        this.bracketInfo.add(bracketInfoItem);
        return this;
    }

    /**
     * Tax rate/bracket information.
     * @return bracketInfo
     */
    public List<TaxBracketInfo> getBracketInfo() {
        return bracketInfo;
    }

    /**
     * Sets the list of tax rate or bracket information.
     * @param bracketInfo 
     */
    public void setBracketInfo(List<TaxBracketInfo> bracketInfo) {
        this.bracketInfo = bracketInfo;
    }
}
