# TaxCalculationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcCalcTaxesPost**](TaxCalculationApi.md#apiV2AfcCalcTaxesPost) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**apiV2AfcCommitPost**](TaxCalculationApi.md#apiV2AfcCommitPost) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.


<a name="apiV2AfcCalcTaxesPost"></a>
# **apiV2AfcCalcTaxesPost**
> CalcTaxesResponse apiV2AfcCalcTaxesPost(calcTaxesRequest)

Performs tax calculations on all invoices and line items within the request body.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TaxCalculationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    
    // Configure HTTP basic authorization: Basic
    HttpBasicAuth Basic = (HttpBasicAuth) defaultClient.getAuthentication("Basic");
    Basic.setUsername("YOUR USERNAME");
    Basic.setPassword("YOUR PASSWORD");

    TaxCalculationApi apiInstance = new TaxCalculationApi(defaultClient);
    CalcTaxesRequest calcTaxesRequest = new CalcTaxesRequest(); // CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations.
    try {
      CalcTaxesResponse result = apiInstance.apiV2AfcCalcTaxesPost(calcTaxesRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling TaxCalculationApi#apiV2AfcCalcTaxesPost");
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
 **calcTaxesRequest** | [**CalcTaxesRequest**](CalcTaxesRequest.md)| CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. | [optional]

### Return type

[**CalcTaxesResponse**](CalcTaxesResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

<a name="apiV2AfcCommitPost"></a>
# **apiV2AfcCommitPost**
> CommitResponse apiV2AfcCommitPost(commitRequest)

Commits or un-commits a document code.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TaxCalculationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    
    // Configure HTTP basic authorization: Basic
    HttpBasicAuth Basic = (HttpBasicAuth) defaultClient.getAuthentication("Basic");
    Basic.setUsername("YOUR USERNAME");
    Basic.setPassword("YOUR PASSWORD");

    TaxCalculationApi apiInstance = new TaxCalculationApi(defaultClient);
    CommitRequest commitRequest = new CommitRequest(); // CommitRequest | CommitRequest object containing document code and optional field data to override in reports.
    try {
      CommitResponse result = apiInstance.apiV2AfcCommitPost(commitRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling TaxCalculationApi#apiV2AfcCommitPost");
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
 **commitRequest** | [**CommitRequest**](CommitRequest.md)| CommitRequest object containing document code and optional field data to override in reports. | [optional]

### Return type

[**CommitResponse**](CommitResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

