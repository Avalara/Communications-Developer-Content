/**
 * Data structure used to provide optional alphanumeric data for transactions.
 */

function OptionalField  () {

    this.OptionalKeyNo = 0;
    this.OptionalValue = "";

  /**
   * Sets the key number (1 to 10) for optional field.
   * @param optionalKeyNo Number
   * @return Reference to this object for method chaining. 
   */
    this.optionalKeyNo = function (optionalKeyNo) {
        this.OptionalKeyNo = optionalKeyNo;
        return this;
    }

   /**
   * Key number (1 to 10) for optional field.
   * @return Number
  **/
    this.getOptionalKeyNo = function () {
        return this.OptionalKeyNo;
    }

  /** Reference to this object for method chaining.
   * Sets the key number (1 to 10) for optional field.
   * @param optionalKeyNo Number 
   */
    this.setOptionalKeyNo = function (optionalKeyNo) {
        this.OptionalKeyNo = optionalKeyNo;
    }

  /**
   * Sets the optional field value.
   * @param optionalValue String
   * @return Reference to this object for method chaining. 
   */
    this.optionalValue = function (optionalValue) {
        this.OptionalValue = optionalValue;
        return this;
    }

   /**
   * Optional field value.
   * @return String
  **/
    this.getOptionalValue = function () {
        return this.OptionalValue;
    }

  /** Reference to this object for method chaining.
   * Sets the optional field value.
   * @param optionalValue String 
   */
    this.setOptionalValue = function (optionalValue) {
        this.OptionalValue = optionalValue;
    }
}
