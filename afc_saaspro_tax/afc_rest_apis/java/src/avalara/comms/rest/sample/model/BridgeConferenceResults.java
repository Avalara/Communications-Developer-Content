package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Structure returned when invoking the bridge conference tax calculation APIs.
 */
public class BridgeConferenceResults {

    @SerializedName("ParticipantResults")
    private List<BridgeConferenceParticipantResult> participantResults = new ArrayList<>();

    @SerializedName("Taxes")
    private List<TaxData> taxes = new ArrayList<>();

    /**
     * Sets the participant results.
     * @param participantResults
     * @return 
     */
    public BridgeConferenceResults participantResults(List<BridgeConferenceParticipantResult> participantResults) {
        this.participantResults = participantResults;
        return this;
    }

    /**
     * Adds a participant result to the bridge conference results.
     * @param participantResultsItem
     * @return 
     */
    public BridgeConferenceResults addParticipantResultsItem(BridgeConferenceParticipantResult participantResultsItem) {
        this.participantResults.add(participantResultsItem);
        return this;
    }

    /**
     * Participant results.
     * @return participantResults
     */
    public List<BridgeConferenceParticipantResult> getParticipantResults() {
        return participantResults;
    }

    /**
     * Sets the participant Taxes.
     * @param participantResults 
     */
    public void setParticipantResults(List<BridgeConferenceParticipantResult> participantResults) {
        this.participantResults = participantResults;
    }

    /**
     * Sets the summarized Taxes for Bridge Conference.
     * @param taxes
     * @return 
     */
    public BridgeConferenceResults taxes(List<TaxData> taxes) {
        this.taxes = taxes;
        return this;
    }

    /**
     * Adds a summarized tax to the bridge conference results.
     * @param taxesItem
     * @return 
     */
    public BridgeConferenceResults addTaxesItem(TaxData taxesItem) {
        this.taxes.add(taxesItem);
        return this;
    }

    /**
     * Summarized Taxes for Bridge Conference.
     * @return taxes
     */
    public List<TaxData> getTaxes() {
        return taxes;
    }

    /**
     * Sets the summarized Taxes for Bridge Conference.
     * @param taxes 
     */
    public void setTaxes(List<TaxData> taxes) {
        this.taxes = taxes;
    }
}
