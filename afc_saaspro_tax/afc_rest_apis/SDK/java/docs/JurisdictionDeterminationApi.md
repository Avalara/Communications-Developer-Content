# JurisdictionDeterminationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcPCodePost**](JurisdictionDeterminationApi.md#apiV2AfcPCodePost) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**apiV2GeoBatchLogProcessIdGet**](JurisdictionDeterminationApi.md#apiV2GeoBatchLogProcessIdGet) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**apiV2GeoBatchStatusProcessIdGet**](JurisdictionDeterminationApi.md#apiV2GeoBatchStatusProcessIdGet) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**apiV2GeoBatchUploadPost**](JurisdictionDeterminationApi.md#apiV2GeoBatchUploadPost) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**apiV2GeoGeocodePost**](JurisdictionDeterminationApi.md#apiV2GeoGeocodePost) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.


<a name="apiV2AfcPCodePost"></a>
# **apiV2AfcPCodePost**
> PCodeLookupResult apiV2AfcPCodePost(pcodeLookupRequest)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.JurisdictionDeterminationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    JurisdictionDeterminationApi apiInstance = new JurisdictionDeterminationApi(defaultClient);
    PCodeLookupRequest pcodeLookupRequest = new PCodeLookupRequest(); // PCodeLookupRequest | 
    try {
      PCodeLookupResult result = apiInstance.apiV2AfcPCodePost(pcodeLookupRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling JurisdictionDeterminationApi#apiV2AfcPCodePost");
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
 **pcodeLookupRequest** | [**PCodeLookupRequest**](PCodeLookupRequest.md)|  | [optional]

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2GeoBatchLogProcessIdGet"></a>
# **apiV2GeoBatchLogProcessIdGet**
> GeoBatchLog apiV2GeoBatchLogProcessIdGet(processId)

Retrieves log on Geo Batch file

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.JurisdictionDeterminationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    JurisdictionDeterminationApi apiInstance = new JurisdictionDeterminationApi(defaultClient);
    String processId = "processId_example"; // String | Process Id for Geo Batch File.
    try {
      GeoBatchLog result = apiInstance.apiV2GeoBatchLogProcessIdGet(processId);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling JurisdictionDeterminationApi#apiV2GeoBatchLogProcessIdGet");
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
 **processId** | **String**| Process Id for Geo Batch File. |

### Return type

[**GeoBatchLog**](GeoBatchLog.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2GeoBatchStatusProcessIdGet"></a>
# **apiV2GeoBatchStatusProcessIdGet**
> GeoBatchStatus apiV2GeoBatchStatusProcessIdGet(processId)

Retrieves information on Geo Batch file status

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.JurisdictionDeterminationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    JurisdictionDeterminationApi apiInstance = new JurisdictionDeterminationApi(defaultClient);
    String processId = "processId_example"; // String | Process Id for Geo Batch File.
    try {
      GeoBatchStatus result = apiInstance.apiV2GeoBatchStatusProcessIdGet(processId);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling JurisdictionDeterminationApi#apiV2GeoBatchStatusProcessIdGet");
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
 **processId** | **String**| Process Id for Geo Batch File. |

### Return type

[**GeoBatchStatus**](GeoBatchStatus.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2GeoBatchUploadPost"></a>
# **apiV2GeoBatchUploadPost**
> GeoBatchSubmitFileResponse apiV2GeoBatchUploadPost(geoBatchFile)

Uploads file to Geo Batch.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.JurisdictionDeterminationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    JurisdictionDeterminationApi apiInstance = new JurisdictionDeterminationApi(defaultClient);
    File geoBatchFile = new File("/path/to/file"); // File | 
    try {
      GeoBatchSubmitFileResponse result = apiInstance.apiV2GeoBatchUploadPost(geoBatchFile);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling JurisdictionDeterminationApi#apiV2GeoBatchUploadPost");
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
 **geoBatchFile** | **File**|  | [optional]

### Return type

[**GeoBatchSubmitFileResponse**](GeoBatchSubmitFileResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2GeoGeocodePost"></a>
# **apiV2GeoGeocodePost**
> List&lt;GeocodeResult&gt; apiV2GeoGeocodePost(geocodeRequest)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.JurisdictionDeterminationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    JurisdictionDeterminationApi apiInstance = new JurisdictionDeterminationApi(defaultClient);
    List<GeocodeRequest> geocodeRequest = Arrays.asList(); // List<GeocodeRequest> | List of street addresses and/or lat/long coordinate pairs to geocode.
    try {
      List<GeocodeResult> result = apiInstance.apiV2GeoGeocodePost(geocodeRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling JurisdictionDeterminationApi#apiV2GeoGeocodePost");
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
 **geocodeRequest** | [**List&lt;GeocodeRequest&gt;**](GeocodeRequest.md)| List of street addresses and/or lat/long coordinate pairs to geocode. | [optional]

### Return type

[**List&lt;GeocodeResult&gt;**](GeocodeResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

