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
import java.io.File;
import java.io.IOException;

/**
 * InlineObject
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-08-04T15:26:12.946-04:00[America/New_York]")
public class InlineObject {
  public static final String SERIALIZED_NAME_GEO_BATCH_FILE = "geoBatchFile";
  @SerializedName(SERIALIZED_NAME_GEO_BATCH_FILE)
  private File geoBatchFile;


  public InlineObject geoBatchFile(File geoBatchFile) {
    
    this.geoBatchFile = geoBatchFile;
    return this;
  }

   /**
   * Get geoBatchFile
   * @return geoBatchFile
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public File getGeoBatchFile() {
    return geoBatchFile;
  }


  public void setGeoBatchFile(File geoBatchFile) {
    this.geoBatchFile = geoBatchFile;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineObject inlineObject = (InlineObject) o;
    return Objects.equals(this.geoBatchFile, inlineObject.geoBatchFile);
  }

  @Override
  public int hashCode() {
    return Objects.hash(geoBatchFile);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineObject {\n");
    sb.append("    geoBatchFile: ").append(toIndentedString(geoBatchFile)).append("\n");
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

