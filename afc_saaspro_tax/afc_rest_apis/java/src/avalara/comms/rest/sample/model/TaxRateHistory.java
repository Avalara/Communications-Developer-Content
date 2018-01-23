package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

/**
 * Historical tax rate information for a tax.
 */
public class TaxRateHistory {

    @SerializedName("EffectiveDate")
    private LocalDateTime effectiveDate = null;

    @SerializedName("LevelExemptible")
    private Boolean levelExemptible = null;

    @SerializedName("BracketInfo")
    private List<TaxBracketInfo> bracketInfo = new ArrayList<TaxBracketInfo>();

    /**
     * Sets the effective date for the tax rate.
     * @param effectiveDate
     * @return 
     */
    public TaxRateHistory effectiveDate(LocalDateTime effectiveDate) {
        this.effectiveDate = effectiveDate;
        return this;
    }

    /**
     * Effective date for rate.
     * @return effectiveDate
     */
    public LocalDateTime getEffectiveDate() {
        return effectiveDate;
    }

    /**
     * Sets the effective date for the tax rate.
     * @param effectiveDate 
     */
    public void setEffectiveDate(LocalDateTime effectiveDate) {
        this.effectiveDate = effectiveDate;
    }

    /**
     * Sets a value indicating if the tax can be exempted using level exemptions.
     * @param levelExemptible
     * @return 
     */
    public TaxRateHistory levelExemptible(Boolean levelExemptible) {
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
    public TaxRateHistory bracketInfo(List<TaxBracketInfo> bracketInfo) {
        this.bracketInfo = bracketInfo;
        return this;
    }

    /**
     * Adds a bracket to this tax rate history record.
     * @param bracketInfoItem
     * @return 
     */
    public TaxRateHistory addBracketInfoItem(TaxBracketInfo bracketInfoItem) {
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