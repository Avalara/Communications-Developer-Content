# LookupsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcLocationPCodeGet**](LookupsApi.md#apiV2AfcLocationPCodeGet) | **GET** /api/v2/afc/location/{pCode} | Get location data associated with a PCode
[**apiV2AfcPrimaryPCodeGet**](LookupsApi.md#apiV2AfcPrimaryPCodeGet) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**apiV2AfcServiceinfoGet**](LookupsApi.md#apiV2AfcServiceinfoGet) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**apiV2AfcTaxtypeTaxTypeGet**](LookupsApi.md#apiV2AfcTaxtypeTaxTypeGet) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**apiV2AfcTspairsGet**](LookupsApi.md#apiV2AfcTspairsGet) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information


<a name="apiV2AfcLocationPCodeGet"></a>
# **apiV2AfcLocationPCodeGet**
> PCodeLookupResult apiV2AfcLocationPCodeGet(pCode)

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LookupsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    LookupsApi apiInstance = new LookupsApi(defaultClient);
    Integer pCode = 56; // Integer | 
    try {
      PCodeLookupResult result = apiInstance.apiV2AfcLocationPCodeGet(pCode);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LookupsApi#apiV2AfcLocationPCodeGet");
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
 **pCode** | **Integer**|  |

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2AfcPrimaryPCodeGet"></a>
# **apiV2AfcPrimaryPCodeGet**
> PCodeLookupResult apiV2AfcPrimaryPCodeGet(pCode)

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LookupsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    LookupsApi apiInstance = new LookupsApi(defaultClient);
    Integer pCode = 56; // Integer | 
    try {
      PCodeLookupResult result = apiInstance.apiV2AfcPrimaryPCodeGet(pCode);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LookupsApi#apiV2AfcPrimaryPCodeGet");
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
 **pCode** | **Integer**|  |

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2AfcServiceinfoGet"></a>
# **apiV2AfcServiceinfoGet**
> ServiceInfo apiV2AfcServiceinfoGet()

Retrieves server time, service build version and engine version

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LookupsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    LookupsApi apiInstance = new LookupsApi(defaultClient);
    try {
      ServiceInfo result = apiInstance.apiV2AfcServiceinfoGet();
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LookupsApi#apiV2AfcServiceinfoGet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServiceInfo**](ServiceInfo.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2AfcTaxtypeTaxTypeGet"></a>
# **apiV2AfcTaxtypeTaxTypeGet**
> List&lt;TaxTypeData&gt; apiV2AfcTaxtypeTaxTypeGet(taxType)

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LookupsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    LookupsApi apiInstance = new LookupsApi(defaultClient);
    String taxType = "taxType_example"; // String | Tax type ID for the tax type.
    try {
      List<TaxTypeData> result = apiInstance.apiV2AfcTaxtypeTaxTypeGet(taxType);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LookupsApi#apiV2AfcTaxtypeTaxTypeGet");
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
 **taxType** | **String**| Tax type ID for the tax type. |

### Return type

[**List&lt;TaxTypeData&gt;**](TaxTypeData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2AfcTspairsGet"></a>
# **apiV2AfcTspairsGet**
> List&lt;TsPairData&gt; apiV2AfcTspairsGet()

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LookupsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    

    LookupsApi apiInstance = new LookupsApi(defaultClient);
    try {
      List<TsPairData> result = apiInstance.apiV2AfcTspairsGet();
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LookupsApi#apiV2AfcTspairsGet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;TsPairData&gt;**](TsPairData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

