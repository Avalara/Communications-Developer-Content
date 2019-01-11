/**
 * Parameter for CustMode/ProcessBatch API.
 */

function ProcessBatchRequest() {

    this.CustBatchId = 0;
    this.Exclusions = [];
    this.ReturnDetail = false;

    /**
     * Sets the identifier for customer batch to process.
     * @param custBatchId Number
     * @return Reference to this object for method chaining. 
     */
    this.custBatchId = function (custBatchId) {
        this.CustBatchId = custBatchId;
        return this;
    }

    /**
     * Identifier for customer batch to process.
     * @return Number
     */
    this.getCustBatchId = function () {
        return this.CustBatchId;
    }

    /* Reference to this object for method chaining.*
     * Sets the identifier for customer batch to process.
     * @param custBatchId Number 
     */
    this.setCustBatchId = function (custBatchId) {
        this.CustBatchId = custBatchId;
    }

    /**
     * Sets a list of states for tax exclusions for this request.
     * @param exclusions Array of Exclusion
     * @return Reference to this object for method chaining. 
     */
    this.exclusions = function (exclusions) {
        this.Exclusions = exclusions;
        return this;
    }

    /**
     * Adds a state exclusion to this request.
     * @param exclusionsItem Exclusion object.
     * @return Reference to this object for method chaining. 
     */
    this.addExclusionsItem = function (exclusionsItem) {
        this.Exclusions.push(exclusionsItem);
        return this;
    }

    /**
     * List of states for tax exclusions.
     * @return Array of Exclusion
     */
    this.getExclusions = function () {
        return this.Exclusions;
    }

    /* Reference to this object for method chaining.*
     * Sets a list of states for tax exclusions for this request.
     * @param exclusions Array of Exclusion 
     */
    this.setExclusions = function (exclusions) {
        this.Exclusions = exclusions;
    }

    /**
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail Boolean
     * @return Reference to this object for method chaining. 
     */
    this.returnDetail = function (returnDetail) {
        this.ReturnDetail = returnDetail;
        return this;
    }

    /**
     * Indicates if the individual transaction taxes should be returned in the
     * response.
     * @return Boolean
     */
    this.getReturnDetail = function () {
        return this.ReturnDetail;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the individual transaction taxes should be 
     * returned in the response.
     * @param returnDetail Boolean 
     */
    this.setReturnDetail = function (returnDetail) {
        this.ReturnDetail = returnDetail;
    }
}
