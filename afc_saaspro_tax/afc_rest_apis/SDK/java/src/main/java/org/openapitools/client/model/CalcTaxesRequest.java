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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.CompanyData;
import org.openapitools.client.model.Invoice;
import org.openapitools.client.model.RequestConfig;
import org.openapitools.client.model.SafeHarborOverride;
import org.openapitools.client.model.TaxOverride;
import org.openapitools.jackson.nullable.JsonNullable;

/**
 * Request body for tax calculation API.
 */
@ApiModel(description = "Request body for tax calculation API.")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-04T16:10:49.104-04:00[America/New_York]")
public class CalcTaxesRequest {
  public static final String SERIALIZED_NAME_CFG = "cfg";
  @SerializedName(SERIALIZED_NAME_CFG)
  private RequestConfig cfg;

  public static final String SERIALIZED_NAME_CMPN = "cmpn";
  @SerializedName(SERIALIZED_NAME_CMPN)
  private CompanyData cmpn;

  public static final String SERIALIZED_NAME_INV = "inv";
  @SerializedName(SERIALIZED_NAME_INV)
  private List<Invoice> inv = null;

  public static final String SERIALIZED_NAME_OVR = "ovr";
  @SerializedName(SERIALIZED_NAME_OVR)
  private List<TaxOverride> ovr = null;

  public static final String SERIALIZED_NAME_SOVR = "sovr";
  @SerializedName(SERIALIZED_NAME_SOVR)
  private List<SafeHarborOverride> sovr = null;


  public CalcTaxesRequest cfg(RequestConfig cfg) {
    
    this.cfg = cfg;
    return this;
  }

   /**
   * Get cfg
   * @return cfg
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public RequestConfig getCfg() {
    return cfg;
  }


  public void setCfg(RequestConfig cfg) {
    this.cfg = cfg;
  }


  public CalcTaxesRequest cmpn(CompanyData cmpn) {
    
    this.cmpn = cmpn;
    return this;
  }

   /**
   * Get cmpn
   * @return cmpn
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public CompanyData getCmpn() {
    return cmpn;
  }


  public void setCmpn(CompanyData cmpn) {
    this.cmpn = cmpn;
  }


  public CalcTaxesRequest inv(List<Invoice> inv) {
    
    this.inv = inv;
    return this;
  }

  public CalcTaxesRequest addInvItem(Invoice invItem) {
    if (this.inv == null) {
      this.inv = new ArrayList<Invoice>();
    }
    this.inv.add(invItem);
    return this;
  }

   /**
   * List of invoices to process.
   * @return inv
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "List of invoices to process.")

  public List<Invoice> getInv() {
    return inv;
  }


  public void setInv(List<Invoice> inv) {
    this.inv = inv;
  }


  public CalcTaxesRequest ovr(List<TaxOverride> ovr) {
    
    this.ovr = ovr;
    return this;
  }

  public CalcTaxesRequest addOvrItem(TaxOverride ovrItem) {
    if (this.ovr == null) {
      this.ovr = new ArrayList<TaxOverride>();
    }
    this.ovr.add(ovrItem);
    return this;
  }

   /**
   * Tax rate overrides.
   * @return ovr
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Tax rate overrides.")

  public List<TaxOverride> getOvr() {
    return ovr;
  }


  public void setOvr(List<TaxOverride> ovr) {
    this.ovr = ovr;
  }


  public CalcTaxesRequest sovr(List<SafeHarborOverride> sovr) {
    
    this.sovr = sovr;
    return this;
  }

  public CalcTaxesRequest addSovrItem(SafeHarborOverride sovrItem) {
    if (this.sovr == null) {
      this.sovr = new ArrayList<SafeHarborOverride>();
    }
    this.sovr.add(sovrItem);
    return this;
  }

   /**
   * Safe harbor overrides for USF taxes.
   * @return sovr
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Safe harbor overrides for USF taxes.")

  public List<SafeHarborOverride> getSovr() {
    return sovr;
  }


  public void setSovr(List<SafeHarborOverride> sovr) {
    this.sovr = sovr;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CalcTaxesRequest calcTaxesRequest = (CalcTaxesRequest) o;
    return Objects.equals(this.cfg, calcTaxesRequest.cfg) &&
        Objects.equals(this.cmpn, calcTaxesRequest.cmpn) &&
        Objects.equals(this.inv, calcTaxesRequest.inv) &&
        Objects.equals(this.ovr, calcTaxesRequest.ovr) &&
        Objects.equals(this.sovr, calcTaxesRequest.sovr);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && a.get().getClass().isArray() ? Arrays.equals((T[])a.get(), (T[])b.get()) : Objects.equals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(cfg, cmpn, inv, ovr, sovr);
  }

  private static <T> int hashCodeNullable(JsonNullable<T> a) {
    if (a == null) {
      return 1;
    }
    return a.isPresent()
      ? (a.get().getClass().isArray() ? Arrays.hashCode((T[])a.get()) : Objects.hashCode(a.get()))
      : 31;
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CalcTaxesRequest {\n");
    sb.append("    cfg: ").append(toIndentedString(cfg)).append("\n");
    sb.append("    cmpn: ").append(toIndentedString(cmpn)).append("\n");
    sb.append("    inv: ").append(toIndentedString(inv)).append("\n");
    sb.append("    ovr: ").append(toIndentedString(ovr)).append("\n");
    sb.append("    sovr: ").append(toIndentedString(sovr)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

