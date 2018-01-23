package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Structure returned when invoking the bridge conference tax calculation APIs.
 */
public class BridgeConferenceParticipantResult {

    @SerializedName("ParticipantRef")
    private String participantRef = null;

    @SerializedName("ErrorCode")
    private Integer errorCode = null;

    @SerializedName("TransactionType")
    private Integer transactionType = null;

    @SerializedName("ServiceType")
    private Integer serviceType = null;

    @SerializedName("ParticipantTaxes")
    private List<TaxData> participantTaxes = new ArrayList<>();

    /**
     * Sets the participant reference.
     * @param participantRef
     * @return 
     */
    public BridgeConferenceParticipantResult participantRef(String participantRef) {
        this.participantRef = participantRef;
        return this;
    }

    /**
     * Participant reference from request.
     * @return participantRef
     */
    public String getParticipantRef() {
        return participantRef;
    }

    /**
     * Sets the participant reference.
     * @param participantRef 
     */
    public void setParticipantRef(String participantRef) {
        this.participantRef = participantRef;
    }

    /**
     * Sets the error code for participant tax calculation (as applicable).
     * @param errorCode
     * @return 
     */
    public BridgeConferenceParticipantResult errorCode(Integer errorCode) {
        this.errorCode = errorCode;
        return this;
    }

    /**
     * Error code for participant tax calculation (as applicable).
     * @return errorCode
     */
    public Integer getErrorCode() {
        return errorCode;
    }

    /**
     * Sets the error code for participant tax calculation (as applicable).
     * @param errorCode 
     */
    public void setErrorCode(Integer errorCode) {
        this.errorCode = errorCode;
    }

    /**
     * Sets the transaction type used for participant.
     * @param transactionType
     * @return 
     */
    public BridgeConferenceParticipantResult transactionType(Integer transactionType) {
        this.transactionType = transactionType;
        return this;
    }

    /**
     * Transaction type used for participant.
     * @return transactionType
     */
    public Integer getTransactionType() {
        return transactionType;
    }

    /**
     * Sets the transaction type used for participant.
     * @param transactionType 
     */
    public void setTransactionType(Integer transactionType) {
        this.transactionType = transactionType;
    }

    /**
     * Sets the service type used for participant.
     * @param serviceType
     * @return 
     */
    public BridgeConferenceParticipantResult serviceType(Integer serviceType) {
        this.serviceType = serviceType;
        return this;
    }

    /**
     * Service type used for participant.
     * @return serviceType
     */
    public Integer getServiceType() {
        return serviceType;
    }

    /**
     * Sets the service type used for participant.
     * @param serviceType 
     */
    public void setServiceType(Integer serviceType) {
        this.serviceType = serviceType;
    }

    /**
     * Sets the list of objects that contain information about the taxes for an
     * individual participant.
     * @param participantTaxes
     * @return 
     */
    public BridgeConferenceParticipantResult participantTaxes(List<TaxData> participantTaxes) {
        this.participantTaxes = participantTaxes;
        return this;
    }

    /**
     * Adds a tax to the participant result.
     * @param participantTaxesItem
     * @return 
     */
    public BridgeConferenceParticipantResult addParticipantTaxesItem(TaxData participantTaxesItem) {
        this.participantTaxes.add(participantTaxesItem);
        return this;
    }

    /**
     * List of objects that contain information about the taxes for an
     * individual participant.
     * @return participantTaxes
     */
    public List<TaxData> getParticipantTaxes() {
        return participantTaxes;
    }

    /**
     * Sets the list of objects that contain information about the taxes for an
     * individual participant.
     * @param participantTaxes 
     */
    public void setParticipantTaxes(List<TaxData> participantTaxes) {
        this.participantTaxes = participantTaxes;
    }
}
