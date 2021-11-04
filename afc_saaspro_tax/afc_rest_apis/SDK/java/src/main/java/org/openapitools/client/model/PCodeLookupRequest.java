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
import org.openapitools.jackson.nullable.JsonNullable;

/**
 * PCodeLookupRequest
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-04T16:10:49.104-04:00[America/New_York]")
public class PCodeLookupRequest {
  public static final String SERIALIZED_NAME_COUNTRY_ISO = "CountryIso";
  @SerializedName(SERIALIZED_NAME_COUNTRY_ISO)
  private String countryIso;

  public static final String SERIALIZED_NAME_STATE = "State";
  @SerializedName(SERIALIZED_NAME_STATE)
  private String state;

  public static final String SERIALIZED_NAME_COUNTY = "County";
  @SerializedName(SERIALIZED_NAME_COUNTY)
  private String county;

  public static final String SERIALIZED_NAME_CITY = "City";
  @SerializedName(SERIALIZED_NAME_CITY)
  private String city;

  public static final String SERIALIZED_NAME_ZIP_CODE = "ZipCode";
  @SerializedName(SERIALIZED_NAME_ZIP_CODE)
  private String zipCode;

  public static final String SERIALIZED_NAME_BEST_MATCH = "BestMatch";
  @SerializedName(SERIALIZED_NAME_BEST_MATCH)
  private Boolean bestMatch;

  public static final String SERIALIZED_NAME_LIMIT_RESULTS = "LimitResults";
  @SerializedName(SERIALIZED_NAME_LIMIT_RESULTS)
  private Integer limitResults;

  public static final String SERIALIZED_NAME_NPA_NXX = "NpaNxx";
  @SerializedName(SERIALIZED_NAME_NPA_NXX)
  private String npaNxx;

  public static final String SERIALIZED_NAME_FIPS = "Fips";
  @SerializedName(SERIALIZED_NAME_FIPS)
  private String fips;


  public PCodeLookupRequest countryIso(String countryIso) {
    
    this.countryIso = countryIso;
    return this;
  }

   /**
   * Get countryIso
   * @return countryIso
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCountryIso() {
    return countryIso;
  }


  public void setCountryIso(String countryIso) {
    this.countryIso = countryIso;
  }


  public PCodeLookupRequest state(String state) {
    
    this.state = state;
    return this;
  }

   /**
   * Get state
   * @return state
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getState() {
    return state;
  }


  public void setState(String state) {
    this.state = state;
  }


  public PCodeLookupRequest county(String county) {
    
    this.county = county;
    return this;
  }

   /**
   * Get county
   * @return county
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCounty() {
    return county;
  }


  public void setCounty(String county) {
    this.county = county;
  }


  public PCodeLookupRequest city(String city) {
    
    this.city = city;
    return this;
  }

   /**
   * Get city
   * @return city
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCity() {
    return city;
  }


  public void setCity(String city) {
    this.city = city;
  }


  public PCodeLookupRequest zipCode(String zipCode) {
    
    this.zipCode = zipCode;
    return this;
  }

   /**
   * Get zipCode
   * @return zipCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getZipCode() {
    return zipCode;
  }


  public void setZipCode(String zipCode) {
    this.zipCode = zipCode;
  }


  public PCodeLookupRequest bestMatch(Boolean bestMatch) {
    
    this.bestMatch = bestMatch;
    return this;
  }

   /**
   * Get bestMatch
   * @return bestMatch
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getBestMatch() {
    return bestMatch;
  }


  public void setBestMatch(Boolean bestMatch) {
    this.bestMatch = bestMatch;
  }


  public PCodeLookupRequest limitResults(Integer limitResults) {
    
    this.limitResults = limitResults;
    return this;
  }

   /**
   * Get limitResults
   * @return limitResults
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getLimitResults() {
    return limitResults;
  }


  public void setLimitResults(Integer limitResults) {
    this.limitResults = limitResults;
  }


  public PCodeLookupRequest npaNxx(String npaNxx) {
    
    this.npaNxx = npaNxx;
    return this;
  }

   /**
   * Get npaNxx
   * @return npaNxx
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getNpaNxx() {
    return npaNxx;
  }


  public void setNpaNxx(String npaNxx) {
    this.npaNxx = npaNxx;
  }


  public PCodeLookupRequest fips(String fips) {
    
    this.fips = fips;
    return this;
  }

   /**
   * Get fips
   * @return fips
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getFips() {
    return fips;
  }


  public void setFips(String fips) {
    this.fips = fips;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PCodeLookupRequest pcodeLookupRequest = (PCodeLookupRequest) o;
    return Objects.equals(this.countryIso, pcodeLookupRequest.countryIso) &&
        Objects.equals(this.state, pcodeLookupRequest.state) &&
        Objects.equals(this.county, pcodeLookupRequest.county) &&
        Objects.equals(this.city, pcodeLookupRequest.city) &&
        Objects.equals(this.zipCode, pcodeLookupRequest.zipCode) &&
        Objects.equals(this.bestMatch, pcodeLookupRequest.bestMatch) &&
        Objects.equals(this.limitResults, pcodeLookupRequest.limitResults) &&
        Objects.equals(this.npaNxx, pcodeLookupRequest.npaNxx) &&
        Objects.equals(this.fips, pcodeLookupRequest.fips);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && a.get().getClass().isArray() ? Arrays.equals((T[])a.get(), (T[])b.get()) : Objects.equals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(countryIso, state, county, city, zipCode, bestMatch, limitResults, npaNxx, fips);
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
    sb.append("class PCodeLookupRequest {\n");
    sb.append("    countryIso: ").append(toIndentedString(countryIso)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    county: ").append(toIndentedString(county)).append("\n");
    sb.append("    city: ").append(toIndentedString(city)).append("\n");
    sb.append("    zipCode: ").append(toIndentedString(zipCode)).append("\n");
    sb.append("    bestMatch: ").append(toIndentedString(bestMatch)).append("\n");
    sb.append("    limitResults: ").append(toIndentedString(limitResults)).append("\n");
    sb.append("    npaNxx: ").append(toIndentedString(npaNxx)).append("\n");
    sb.append("    fips: ").append(toIndentedString(fips)).append("\n");
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

