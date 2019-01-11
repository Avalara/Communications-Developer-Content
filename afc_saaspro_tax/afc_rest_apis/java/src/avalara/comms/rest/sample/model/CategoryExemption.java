package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Specifies tax exemptions based on the tax category.
 */
public class CategoryExemption {

    @SerializedName("CountryISO")
    private String countryISO = null;

    @SerializedName("State")
    private String state = null;

    @SerializedName("TaxCategory")
    private Integer taxCategory = null;

    /**
     * Sets the three-character country ISO code. Required if State is not specified.
     * @param countryISO
     * @return 
     */
    public CategoryExemption countryISO(String countryISO) {
        this.countryISO = countryISO;
        return this;
    }

    /**
     * Three-character country ISO code. Required if State is not specified.
     * @return countryISO
     */
    public String getCountryISO() {
        return countryISO;
    }

    /**
     * Sets the three-character country ISO code. Required if State is not specified.
     * @param countryISO 
     */
    public void setCountryISO(String countryISO) {
        this.countryISO = countryISO;
    }

    /**
     * Sets the two-character state abbreviation. Required if CountryISO is not
     * specified.
     * @param state
     * @return 
     */
    public CategoryExemption state(String state) {
        this.state = state;
        return this;
    }

    /**
     * Two-character state abbreviation. Required if CountryISO is not
     * specified.
     * @return state
     */
    public String getState() {
        return state;
    }

    /**
     * Sets the two-character state abbreviation. Required if CountryISO is not
     * specified.
     * @param state 
     */
    public void setState(String state) {
        this.state = state;
    }

    /**
     * Sets the tax category ID. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid tax categories.
     * @param taxCategory
     * @return 
     */
    public CategoryExemption taxCategory(Integer taxCategory) {
        this.taxCategory = taxCategory;
        return this;
    }

    /**
     * See the CommsPlatform.API.WrapperClasses User's Manual for valid tax
     * categories.
     * @return taxCategory
     */
    public Integer getTaxCategory() {
        return taxCategory;
    }

    /**
     * Sets the tax category ID. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for valid tax categories.
     * @param taxCategory 
     */
    public void setTaxCategory(Integer taxCategory) {
        this.taxCategory = taxCategory;
    }
}
