package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 * Parameter for CustMode/ProcessBatch API.
 */
public class ProcessBatchRequest {

    @SerializedName("CustBatchId")
    private Long custBatchId = null;

    @SerializedName("Exclusions")
    private List<Exclusion> exclusions = new ArrayList<>();

    @SerializedName("ReturnDetail")
    private Boolean returnDetail = null;

    /**
     * Sets the identifier for customer batch to process.
     * @param custBatchId
     * @return 
     */
    public ProcessBatchRequest custBatchId(Long custBatchId) {
        this.custBatchId = custBatchId;
        return this;
    }

    /**
     * Identifier for customer batch to process.
     * @return custBatchId
     */
    public Long getCustBatchId() {
        return custBatchId;
    }

    /**
     * Sets the identifier for customer batch to process.
     * @param custBatchId 
     */
    public void setCustBatchId(Long custBatchId) {
        this.custBatchId = custBatchId;
    }

    /**
     * Sets a list of states for tax exclusions for this request.
     * @param exclusions
     * @return 
     */
    public ProcessBatchRequest exclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
        return this;
    }

    /**
     * Adds a state exclusion to this request.
     * @param exclusionsItem
     * @return 
     */
    public ProcessBatchRequest addExclusionsItem(Exclusion exclusionsItem) {
        this.exclusions.add(exclusionsItem);
        return this;
    }

    /**
     * List of states for tax exclusions.
     * @return exclusions
     */
    public List<Exclusion> getExclusions() {
        return exclusions;
    }

    /**
     * Sets a list of states for tax exclusions for this request.
     * @param exclusions 
     */
    public void setExclusions(List<Exclusion> exclusions) {
        this.exclusions = exclusions;
    }

    /**
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail
     * @return 
     */
    public ProcessBatchRequest returnDetail(Boolean returnDetail) {
        this.returnDetail = returnDetail;
        return this;
    }

    /**
     * Indicates if the individual transaction taxes should be returned in the
     * response.
     * @return returnDetail
     */
    public Boolean getReturnDetail() {
        return returnDetail;
    }

    /**
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail 
     */
    public void setReturnDetail(Boolean returnDetail) {
        this.returnDetail = returnDetail;
    }
}
