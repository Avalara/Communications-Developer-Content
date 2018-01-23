/**
 * Structure returned when invoking the bridge conference tax calculation APIs.
 */

function BridgeConferenceResults() {

    this.ParticipantResults = [];
    this.Taxes = [];

    /**
     * Sets the participant results.
     * @param participantResults Array of BridgeConferenceParticipantResult
     * @return Reference to this object for method chaining. 
     */
    this.participantResults = function (participantResults) {
        this.ParticipantResults = participantResults;
        return this;
    }

    /**
     * Adds a participant result to the bridge conference results.
     * @param participantResultsItem BridgeConferenceParticipantResult object.
     * @return Reference to this object for method chaining. 
     */
    this.addParticipantResultsItem = function (participantResultsItem) {
        this.ParticipantResults.push(participantResultsItem);
        return this;
    }

    /**
     * Participant results.
     * @return Array of BridgeConferenceParticipantResult
     */
    this.getParticipantResults = function () {
        return this.ParticipantResults;
    }

    /* Reference to this object for method chaining.*
     * Sets the participant Taxes.
     * @param participantResults Array of BridgeConferenceParticipantResult 
     */
    this.setParticipantResults = function (participantResults) {
        this.ParticipantResults = participantResults;
    }

    /**
     * Sets the summarized Taxes for Bridge Conference.
     * @param taxes Array of TaxData
     * @return Reference to this object for method chaining. 
     */
    this.taxes = function (taxes) {
        this.Taxes = taxes;
        return this;
    }

    /**
     * Adds a summarized tax to the bridge conference results.
     * @param taxesItem TaxData object.
     * @return Reference to this object for method chaining. 
     */
    this.addTaxesItem = function (taxesItem) {
        this.Taxes.push(taxesItem);
        return this;
    }

    /**
     * Summarized Taxes for Bridge Conference.
     * @return Array of TaxData
     */
    this.getTaxes = function () {
        return this.Taxes;
    }

    /* Reference to this object for method chaining.*
     * Sets the summarized Taxes for Bridge Conference.
     * @param taxes Array of TaxData 
     */
    this.setTaxes = function (taxes) {
        this.Taxes = taxes;
    }
}
