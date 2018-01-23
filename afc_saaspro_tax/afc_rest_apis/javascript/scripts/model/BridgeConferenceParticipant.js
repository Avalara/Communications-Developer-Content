/**
 * Structure returned when invoking the bridge conference tax calculation APIs.
 */

function BridgeConferenceParticipant() {

    this.ParticipantAddress = null;
    this.ParticipantPCode = 0;
    this.ParticipantNpaNxx = 0;
    this.ParticipantRef = "";

    /**
     * Sets the Address for participant - all participants must use address values 
     * if any participant uses an address. Not required if ParticipantPCode or
     * ParticipantNpaNxx are specified.
     * @param participantAddress ZipAddress object.
     * @return Reference to this object for method chaining. 
     */
    this.participantAddress = function (participantAddress) {
        this.ParticipantAddress = participantAddress;
        return this;
    }

    /**
     * Address for participant - all participants must use address values if any
     * participant uses an address. Not required if ParticipantPCode or
     * ParticipantNpaNxx are specified.
     * @return ZipAddress object.
     */
    this.getParticipantAddress = function () {
        return this.ParticipantAddress;
    }

    /* Reference to this object for method chaining.*
     * Sets the Address for participant - all participants must use address values 
     * if any participant uses an address. Not required if ParticipantPCode or
     * ParticipantNpaNxx are specified.
     * @param participantAddress ZipAddress object. 
     */
    this.setParticipantAddress = function (participantAddress) {
        this.ParticipantAddress = participantAddress;
    }

    /**
     * Sets the PCode forpParticipant – all participants must use PCode values 
     * if any participant uses PCode. Not required if ParticipantAddress or
     * ParticipantNpaNxx are specified.
     * @param participantPCode Number
     * @return Reference to this object for method chaining. 
     */
    this.participantPCode = function (participantPCode) {
        this.ParticipantPCode = participantPCode;
        return this;
    }

    /**
     * PCode forpParticipant – all participants must use PCode values if any
     * participant uses PCode. Not required if ParticipantAddress or
     * ParticipantNpaNxx are specified.
     * @return Number
     */
    this.getParticipantPCode = function () {
        return this.ParticipantPCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode forpParticipant – all participants must use PCode values 
     * if any participant uses PCode. Not required if ParticipantAddress or
     * ParticipantNpaNxx are specified.
     * @param participantPCode Number 
     */
    this.setParticipantPCode = function (participantPCode) {
        this.ParticipantPCode = participantPCode;
    }

    /**
     * Sets the NpaNxx for participant – all participants must use NPANXX values 
     * if any participant uses NPANXX. Not required if ParticipantAddress or
     * ParticipantPCode are specified.
     * @param participantNpaNxx Number
     * @return Reference to this object for method chaining. 
     */
    this.participantNpaNxx = function (participantNpaNxx) {
        this.ParticipantNpaNxx = participantNpaNxx;
        return this;
    }

    /**
     * NpaNxx for participant – all participants must use NPANXX values if any
     * participant uses NPANXX. Not required if ParticipantAddress or
     * ParticipantPCode are specified.
     * @return Number
     */
    this.getParticipantNpaNxx = function () {
        return this.ParticipantNpaNxx;
    }

    /* Reference to this object for method chaining.*
     * Sets the NpaNxx for participant – all participants must use NPANXX values 
     * if any participant uses NPANXX. Not required if ParticipantAddress or
     * ParticipantPCode are specified.
     * @param participantNpaNxx Number 
     */
    this.setParticipantNpaNxx = function (participantNpaNxx) {
        this.ParticipantNpaNxx = participantNpaNxx;
    }

    /**
     * Sets the Alpha-numeric reference that will tie a participant in the request 
     * to participant taxes in response if ReturnParticipantTaxes is true. 
     * Max 127 bytes.
     * @param participantRef String
     * @return Reference to this object for method chaining. 
     */
    this.participantRef = function (participantRef) {
        this.ParticipantRef = participantRef;
        return this;
    }

    /**
     * Alpha-numeric reference that will tie a participant in the request to
     * participant taxes in response if ReturnParticipantTaxes is true.
     * @return String
     */
    this.getParticipantRef = function () {
        return this.ParticipantRef;
    }

    /* Reference to this object for method chaining.*
     * Sets the Alpha-numeric reference that will tie a participant in the request 
     * to participant taxes in response if ReturnParticipantTaxes is true. 
     * Max 127 bytes.
     * @param participantRef String 
     */
    this.setParticipantRef = function (participantRef) {
        this.ParticipantRef = participantRef;
    }
}
