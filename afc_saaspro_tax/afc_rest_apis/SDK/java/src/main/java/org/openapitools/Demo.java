package org.openapitools;

import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.model.*;
import org.openapitools.client.api.LookupsApi;

public class Demo {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://communicationsua.avalara.net");
    // Set Client ID
    defaultClient.addDefaultHeader("client_id","0");
    // Optionally, set Profile ID
    defaultClient.addDefaultHeader("client_profile_id","0");
    
    // Configure HTTP basic authorization: Basic
    HttpBasicAuth Basic = (HttpBasicAuth) defaultClient.getAuthentication("Basic");
    Basic.setUsername("YOUR USERNAME");
    Basic.setPassword("YOUR PASSWORD");

    LookupsApi apiInstance = new LookupsApi(defaultClient);
    
    // Seattle, WA, USA
    Integer pCode = 4133800;

    try {
      PCodeLookupResult result = apiInstance.apiV2AfcLocationPCodeGet(pCode);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception:");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}