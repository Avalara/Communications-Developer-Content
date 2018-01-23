/**
 * Structure returned when invoking the bridge conference tax calculation APIs.
 */

function BridgeConferenceParticipantResult() {

    this.ParticipantRef = "";
    this.ErrorCode = 0;
    this.TransactionType = 0;
    this.ServiceType = 0;
    this.ParticipantTaxes = [];

    /**
     * Sets the participant reference.
     * @param participantRef String
     * @return Reference to this object for method chaining. 
     */
    this.participantRef = function (participantRef) {
        this.ParticipantRef = participantRef;
        return this;
    }

    /**
     * Participant reference from request.
     * @return String
     */
    this.getParticipantRef = function () {
        return this.ParticipantRef;
    }

    /* Reference to this object for method chaining.*
     * Sets the participant reference.
     * @param participantRef String 
     */
    this.setParticipantRef = function (participantRef) {
        this.ParticipantRef = participantRef;
    }

    /**
     * Sets the error code for participant tax calculation (as applicable).
     * @param errorCode Number
     * @return Reference to this object for method chaining. 
     */
    this.errorCode = function (errorCode) {
        this.ErrorCode = errorCode;
        return this;
    }

    /**
     * Error code for participant tax calculation (as applicable).
     * @return Number
     */
    this.getErrorCode = function () {
        return this.ErrorCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the error code for participant tax calculation (as applicable).
     * @param errorCode Number 
     */
    this.setErrorCode = function (errorCode) {
        this.ErrorCode = errorCode;
    }

    /**
     * Sets the transaction type used for participant.
     * @param transactionType Number
     * @return Reference to this object for method chaining. 
     */
    this.transactionType = function (transactionType) {
        this.TransactionType = transactionType;
        return this;
    }

    /**
     * Transaction type used for participant.
     * @return Number
     */
    this.getTransactionType = function () {
        return this.TransactionType;
    }

    /* Reference to this object for method chaining.*
     * Sets the transaction type used for participant.
     * @param transactionType Number 
     */
    this.setTransactionType = function (transactionType) {
        this.TransactionType = transactionType;
    }

    /**
     * Sets the service type used for participant.
     * @param serviceType Number
     * @return Reference to this object for method chaining. 
     */
    this.serviceType = function (serviceType) {
        this.ServiceType = serviceType;
        return this;
    }

    /**
     * Service type used for participant.
     * @return Number
     */
    this.getServiceType = function () {
        return this.ServiceType;
    }

    /* Reference to this object for method chaining.*
     * Sets the service type used for participant.
     * @param serviceType Number 
     */
    this.setServiceType = function (serviceType) {
        this.ServiceType = serviceType;
    }

    /**
     * Sets the list of objects that contain information about the taxes for an
     * individual participant.
     * @param participantTaxes Array of TaxData
     * @return Reference to this object for method chaining. 
     */
    this.participantTaxes = function (participantTaxes) {
        this.ParticipantTaxes = participantTaxes;
        return this;
    }

    /**
     * Adds a tax to the participant result.
     * @param participantTaxesItem TaxData object.
     * @return Reference to this object for method chaining. 
     */
    this.addParticipantTaxesItem = function (participantTaxesItem) {
        this.ParticipantTaxes.push(participantTaxesItem);
        return this;
    }

    /**
     * List of objects that contain information about the taxes for an
     * individual participant.
     * @return Array of TaxData
     */
    this.getParticipantTaxes = function () {
        return this.ParticipantTaxes;
    }

    /* Reference to this object for method chaining.*
     * Sets the list of objects that contain information about the taxes for an
     * individual participant.
     * @param participantTaxes Array of TaxData 
     */
    this.setParticipantTaxes = function (participantTaxes) {
        this.ParticipantTaxes = participantTaxes;
    }
}
