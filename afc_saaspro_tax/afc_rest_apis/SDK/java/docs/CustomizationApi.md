# CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2ProfilesGetProfilesGet**](CustomizationApi.md#apiV2ProfilesGetProfilesGet) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
[**apiV2ProfilesSetBundlesPost**](CustomizationApi.md#apiV2ProfilesSetBundlesPost) | **POST** /api/v2/profiles/SetBundles | Creates or updates bundle packages and associated profile mappings.
[**apiV2ProfilesSetConfigPost**](CustomizationApi.md#apiV2ProfilesSetConfigPost) | **POST** /api/v2/profiles/SetConfig | Creates or updates configuration settings and associated profile mappings.
[**apiV2ProfilesSetExclusionsPost**](CustomizationApi.md#apiV2ProfilesSetExclusionsPost) | **POST** /api/v2/profiles/SetExclusions | Creates or updates exclusions and associated profile mappings.
[**apiV2ProfilesSetOverridesPost**](CustomizationApi.md#apiV2ProfilesSetOverridesPost) | **POST** /api/v2/profiles/SetOverrides | Creates or updates overrides and associated profile mappings.


<a name="apiV2ProfilesGetProfilesGet"></a>
# **apiV2ProfilesGetProfilesGet**
> TaxCalculationSettingsResponse apiV2ProfilesGetProfilesGet(requestedClientId, requestedProfileId, itemType)

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
    

    CustomizationApi apiInstance = new CustomizationApi(defaultClient);
    Integer requestedClientId = 56; // Integer | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
    Integer requestedProfileId = 56; // Integer | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
    TaxCalculationSettingTypes itemType = new TaxCalculationSettingTypes(); // TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All
    try {
      TaxCalculationSettingsResponse result = apiInstance.apiV2ProfilesGetProfilesGet(requestedClientId, requestedProfileId, itemType);
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
 **itemType** | [**TaxCalculationSettingTypes**](.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] [enum: All, Configuration, Bundle, Exclusion, Override, Nexus, Exemption]

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2ProfilesSetBundlesPost"></a>
# **apiV2ProfilesSetBundlesPost**
> TaxCalculationSettingsResponse apiV2ProfilesSetBundlesPost(setTaxCalculationSettingRequest)

Creates or updates bundle packages and associated profile mappings.

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
    

    CustomizationApi apiInstance = new CustomizationApi(defaultClient);
    SetTaxCalculationSettingRequest setTaxCalculationSettingRequest = new SetTaxCalculationSettingRequest(); // SetTaxCalculationSettingRequest | 
    try {
      TaxCalculationSettingsResponse result = apiInstance.apiV2ProfilesSetBundlesPost(setTaxCalculationSettingRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling CustomizationApi#apiV2ProfilesSetBundlesPost");
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
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional]

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2ProfilesSetConfigPost"></a>
# **apiV2ProfilesSetConfigPost**
> TaxCalculationSettingsResponse apiV2ProfilesSetConfigPost(setTaxCalculationSettingRequest)

Creates or updates configuration settings and associated profile mappings.

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
    

    CustomizationApi apiInstance = new CustomizationApi(defaultClient);
    SetTaxCalculationSettingRequest setTaxCalculationSettingRequest = new SetTaxCalculationSettingRequest(); // SetTaxCalculationSettingRequest | 
    try {
      TaxCalculationSettingsResponse result = apiInstance.apiV2ProfilesSetConfigPost(setTaxCalculationSettingRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling CustomizationApi#apiV2ProfilesSetConfigPost");
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
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional]

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2ProfilesSetExclusionsPost"></a>
# **apiV2ProfilesSetExclusionsPost**
> TaxCalculationSettingsResponse apiV2ProfilesSetExclusionsPost(setTaxCalculationSettingRequest)

Creates or updates exclusions and associated profile mappings.

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
    

    CustomizationApi apiInstance = new CustomizationApi(defaultClient);
    SetTaxCalculationSettingRequest setTaxCalculationSettingRequest = new SetTaxCalculationSettingRequest(); // SetTaxCalculationSettingRequest | 
    try {
      TaxCalculationSettingsResponse result = apiInstance.apiV2ProfilesSetExclusionsPost(setTaxCalculationSettingRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling CustomizationApi#apiV2ProfilesSetExclusionsPost");
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
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional]

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2ProfilesSetOverridesPost"></a>
# **apiV2ProfilesSetOverridesPost**
> TaxCalculationSettingsResponse apiV2ProfilesSetOverridesPost(setTaxCalculationSettingRequest)

Creates or updates overrides and associated profile mappings.

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
    

    CustomizationApi apiInstance = new CustomizationApi(defaultClient);
    SetTaxCalculationSettingRequest setTaxCalculationSettingRequest = new SetTaxCalculationSettingRequest(); // SetTaxCalculationSettingRequest | 
    try {
      TaxCalculationSettingsResponse result = apiInstance.apiV2ProfilesSetOverridesPost(setTaxCalculationSettingRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling CustomizationApi#apiV2ProfilesSetOverridesPost");
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
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional]

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

