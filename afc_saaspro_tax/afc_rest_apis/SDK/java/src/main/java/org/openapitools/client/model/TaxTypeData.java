/*
 * SaasPro
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * TaxTypeData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-08-04T15:26:12.946-04:00[America/New_York]")
public class TaxTypeData {
  public static final String SERIALIZED_NAME_TAX_TYPE = "TaxType";
  @SerializedName(SERIALIZED_NAME_TAX_TYPE)
  private Integer taxType;

  public static final String SERIALIZED_NAME_CATEGORY_TYPE = "CategoryType";
  @SerializedName(SERIALIZED_NAME_CATEGORY_TYPE)
  private Integer categoryType;

  public static final String SERIALIZED_NAME_TAX_DESCRIPTION = "TaxDescription";
  @SerializedName(SERIALIZED_NAME_TAX_DESCRIPTION)
  private String taxDescription;

  public static final String SERIALIZED_NAME_CATEGORY_DESCRIPTION = "CategoryDescription";
  @SerializedName(SERIALIZED_NAME_CATEGORY_DESCRIPTION)
  private String categoryDescription;


  public TaxTypeData taxType(Integer taxType) {
    
    this.taxType = taxType;
    return this;
  }

   /**
   * Get taxType
   * @return taxType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getTaxType() {
    return taxType;
  }


  public void setTaxType(Integer taxType) {
    this.taxType = taxType;
  }


  public TaxTypeData categoryType(Integer categoryType) {
    
    this.categoryType = categoryType;
    return this;
  }

   /**
   * Get categoryType
   * @return categoryType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getCategoryType() {
    return categoryType;
  }


  public void setCategoryType(Integer categoryType) {
    this.categoryType = categoryType;
  }


  public TaxTypeData taxDescription(String taxDescription) {
    
    this.taxDescription = taxDescription;
    return this;
  }

   /**
   * Get taxDescription
   * @return taxDescription
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getTaxDescription() {
    return taxDescription;
  }


  public void setTaxDescription(String taxDescription) {
    this.taxDescription = taxDescription;
  }


  public TaxTypeData categoryDescription(String categoryDescription) {
    
    this.categoryDescription = categoryDescription;
    return this;
  }

   /**
   * Get categoryDescription
   * @return categoryDescription
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCategoryDescription() {
    return categoryDescription;
  }


  public void setCategoryDescription(String categoryDescription) {
    this.categoryDescription = categoryDescription;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TaxTypeData taxTypeData = (TaxTypeData) o;
    return Objects.equals(this.taxType, taxTypeData.taxType) &&
        Objects.equals(this.categoryType, taxTypeData.categoryType) &&
        Objects.equals(this.taxDescription, taxTypeData.taxDescription) &&
        Objects.equals(this.categoryDescription, taxTypeData.categoryDescription);
  }

  @Override
  public int hashCode() {
    return Objects.hash(taxType, categoryType, taxDescription, categoryDescription);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TaxTypeData {\n");
    sb.append("    taxType: ").append(toIndentedString(taxType)).append("\n");
    sb.append("    categoryType: ").append(toIndentedString(categoryType)).append("\n");
    sb.append("    taxDescription: ").append(toIndentedString(taxDescription)).append("\n");
    sb.append("    categoryDescription: ").append(toIndentedString(categoryDescription)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

