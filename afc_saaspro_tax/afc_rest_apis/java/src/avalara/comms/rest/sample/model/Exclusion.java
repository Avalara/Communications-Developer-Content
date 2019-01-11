package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Specifies a tax exclusion by state.
 */
public class Exclusion {

    @SerializedName("CountryISO")
    private String countryISO = null;

    @SerializedName("State")
    private String state = null;

    @SerializedName("ExclusionOn")
    private Boolean exclusionOn = null;

    /**
     * Sets the three-character country ISO code. Required if State not specified.
     * @param countryISO
     * @return 
     */
    public Exclusion countryISO(String countryISO) {
        this.countryISO = countryISO;
        return this;
    }

    /**
     * Three-character country ISO code. Required if State not specified.
     * @return countryISO
     */
    public String getCountryISO() {
        return countryISO;
    }

    /**
     * Sets the three-character country ISO code. Required if State not specified.
     * @param countryISO 
     */
    public void setCountryISO(String countryISO) {
        this.countryISO = countryISO;
    }

    /**
     * Sets the two-character state abbreviation. Required if CountryISO not specified.
     * @param state
     * @return 
     */
    public Exclusion state(String state) {
        this.state = state;
        return this;
    }

    /**
     * Two-character state abbreviation. Required if CountryISO not specified.
     * @return state
     */
    public String getState() {
        return state;
    }

    /**
     * Sets the two-character state abbreviation. Required if CountryISO not specified.
     * @param state 
     */
    public void setState(String state) {
        this.state = state;
    }

    /**
     * Sets a value indicating if the exclusion applies in the state.
     * @param exclusionOn
     * @return 
     */
    public Exclusion exclusionOn(Boolean exclusionOn) {
        this.exclusionOn = exclusionOn;
        return this;
    }

    /**
     * True if entity exclusion applies in the state, otherwise false.
     * @return exclusionOn
     */
    public Boolean getExclusionOn() {
        return exclusionOn;
    }

    /**
     * Sets a value indicating if the exclusion applies in the state.
     * @param exclusionOn 
     */
    public void setExclusionOn(Boolean exclusionOn) {
        this.exclusionOn = exclusionOn;
    }
}
