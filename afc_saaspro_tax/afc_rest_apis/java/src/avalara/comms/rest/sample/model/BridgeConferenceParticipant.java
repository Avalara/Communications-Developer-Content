package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Structure returned when invoking the bridge conference tax calculation APIs.
 */
public class BridgeConferenceParticipant {

    @SerializedName("ParticipantAddress")
    private ZipAddress participantAddress = null;

    @SerializedName("ParticipantPCode")
    private Integer participantPCode = null;

    @SerializedName("ParticipantNpaNxx")
    private Integer participantNpaNxx = null;

    @SerializedName("ParticipantRef")
    private String participantRef = null;

    /**
     * Sets the Address for participant - all participants must use address values 
     * if any participant uses an address. Not required if ParticipantPCode or
     * ParticipantNpaNxx are specified.
     * @param participantAddress
     * @return 
     */
    public BridgeConferenceParticipant participantAddress(ZipAddress participantAddress) {
        this.participantAddress = participantAddress;
        return this;
    }

    /**
     * Address for participant - all participants must use address values if any
     * participant uses an address. Not required if ParticipantPCode or
     * ParticipantNpaNxx are specified.
     * @return participantAddress
     */
    public ZipAddress getParticipantAddress() {
        return participantAddress;
    }

    /**
     * Sets the Address for participant - all participants must use address values 
     * if any participant uses an address. Not required if ParticipantPCode or
     * ParticipantNpaNxx are specified.
     * @param participantAddress 
     */
    public void setParticipantAddress(ZipAddress participantAddress) {
        this.participantAddress = participantAddress;
    }

    /**
     * Sets the PCode forpParticipant – all participants must use PCode values 
     * if any participant uses PCode. Not required if ParticipantAddress or
     * ParticipantNpaNxx are specified.
     * @param participantPCode
     * @return 
     */
    public BridgeConferenceParticipant participantPCode(Integer participantPCode) {
        this.participantPCode = participantPCode;
        return this;
    }

    /**
     * PCode forpParticipant – all participants must use PCode values if any
     * participant uses PCode. Not required if ParticipantAddress or
     * ParticipantNpaNxx are specified.
     * @return participantPCode
     */
    public Integer getParticipantPCode() {
        return participantPCode;
    }

    /**
     * Sets the PCode forpParticipant – all participants must use PCode values 
     * if any participant uses PCode. Not required if ParticipantAddress or
     * ParticipantNpaNxx are specified.
     * @param participantPCode 
     */
    public void setParticipantPCode(Integer participantPCode) {
        this.participantPCode = participantPCode;
    }

    /**
     * Sets the NpaNxx for participant – all participants must use NPANXX values 
     * if any participant uses NPANXX. Not required if ParticipantAddress or
     * ParticipantPCode are specified.
     * @param participantNpaNxx
     * @return 
     */
    public BridgeConferenceParticipant participantNpaNxx(Integer participantNpaNxx) {
        this.participantNpaNxx = participantNpaNxx;
        return this;
    }

    /**
     * NpaNxx for participant – all participants must use NPANXX values if any
     * participant uses NPANXX. Not required if ParticipantAddress or
     * ParticipantPCode are specified.
     * @return participantNpaNxx
     */
    public Integer getParticipantNpaNxx() {
        return participantNpaNxx;
    }

    /**
     * Sets the NpaNxx for participant – all participants must use NPANXX values 
     * if any participant uses NPANXX. Not required if ParticipantAddress or
     * ParticipantPCode are specified.
     * @param participantNpaNxx 
     */
    public void setParticipantNpaNxx(Integer participantNpaNxx) {
        this.participantNpaNxx = participantNpaNxx;
    }

    /**
     * Sets the Alpha-numeric reference that will tie a participant in the request 
     * to participant taxes in response if ReturnParticipantTaxes is true. 
     * Max 127 bytes.
     * @param participantRef
     * @return 
     */
    public BridgeConferenceParticipant participantRef(String participantRef) {
        this.participantRef = participantRef;
        return this;
    }

    /**
     * Alpha-numeric reference that will tie a participant in the request to
     * participant taxes in response if ReturnParticipantTaxes is true.
     * @return participantRef
     */
    public String getParticipantRef() {
        return participantRef;
    }

    /**
     * Sets the Alpha-numeric reference that will tie a participant in the request 
     * to participant taxes in response if ReturnParticipantTaxes is true. 
     * Max 127 bytes.
     * @param participantRef 
     */
    public void setParticipantRef(String participantRef) {
        this.participantRef = participantRef;
    }
}
