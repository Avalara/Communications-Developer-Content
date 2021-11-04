# CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2ProfilesGetProfilesGet**](CustomizationApi.md#apiV2ProfilesGetProfilesGet) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items


<a name="apiV2ProfilesGetProfilesGet"></a>
# **apiV2ProfilesGetProfilesGet**
> List&lt;ClientProfileConfigResponse&gt; apiV2ProfilesGetProfilesGet(requestedClientId, requestedProfileId, itemType)

Retrieves one or more profiles with associated settings and configurable items

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.CustomizationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    
    // Configure HTTP basic authorization: Basic
    HttpBasicAuth Basic = (HttpBasicAuth) defaultClient.getAuthentication("Basic");
    Basic.setUsername("YOUR USERNAME");
    Basic.setPassword("YOUR PASSWORD");

    CustomizationApi apiInstance = new CustomizationApi(defaultClient);
    Integer requestedClientId = 56; // Integer | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
    Integer requestedProfileId = 56; // Integer | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
    ClientProfileConfigTypes itemType = ClientProfileConfigTypes.fromValue("All"); // ClientProfileConfigTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All
    try {
      List<ClientProfileConfigResponse> result = apiInstance.apiV2ProfilesGetProfilesGet(requestedClientId, requestedProfileId, itemType);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling CustomizationApi#apiV2ProfilesGetProfilesGet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestedClientId** | **Integer**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional]
 **requestedProfileId** | **Integer**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional]
 **itemType** | [**ClientProfileConfigTypes**](.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] [enum: All, Configuration, Bundle, Exclusion, Override, Nexus, Exemption]

### Return type

[**List&lt;ClientProfileConfigResponse&gt;**](ClientProfileConfigResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

