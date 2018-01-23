package avalara.comms.rest.sample.model;

import com.google.gson.annotations.SerializedName;

/**
 * Data structure used to provide optional alphanumeric data for transactions.
 */
public class OptionalField   {
  @SerializedName("OptionalKeyNo")
  private Integer optionalKeyNo = null;

  @SerializedName("OptionalValue")
  private String optionalValue = null;

  /**
   * Sets the key number (1 to 10) for optional field.
   * @param optionalKeyNo
   * @return 
   */
  public OptionalField optionalKeyNo(Integer optionalKeyNo) {
    this.optionalKeyNo = optionalKeyNo;
    return this;
  }

   /**
   * Key number (1 to 10) for optional field.
   * @return optionalKeyNo
  **/
  public Integer getOptionalKeyNo() {
    return optionalKeyNo;
  }

  /**
   * Sets the key number (1 to 10) for optional field.
   * @param optionalKeyNo 
   */
  public void setOptionalKeyNo(Integer optionalKeyNo) {
    this.optionalKeyNo = optionalKeyNo;
  }

  /**
   * Sets the optional field value.
   * @param optionalValue
   * @return 
   */
  public OptionalField optionalValue(String optionalValue) {
    this.optionalValue = optionalValue;
    return this;
  }

   /**
   * Optional field value.
   * @return optionalValue
  **/
  public String getOptionalValue() {
    return optionalValue;
  }

  /**
   * Sets the optional field value.
   * @param optionalValue 
   */
  public void setOptionalValue(String optionalValue) {
    this.optionalValue = optionalValue;
  }
}

