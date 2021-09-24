# avalara.comms.rest.v2.Api.TaxCalculationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2AfcCalcTaxesPost**](TaxCalculationApi.md#apiv2afccalctaxespost) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**ApiV2AfcCommitPost**](TaxCalculationApi.md#apiv2afccommitpost) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.


<a name="apiv2afccalctaxespost"></a>
# **ApiV2AfcCalcTaxesPost**
> CalcTaxesResponse ApiV2AfcCalcTaxesPost (CalcTaxesRequest calcTaxesRequest = null)

Performs tax calculations on all invoices and line items within the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcCalcTaxesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TaxCalculationApi(config);
            var calcTaxesRequest = new CalcTaxesRequest(); // CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional) 

            try
            {
                // Performs tax calculations on all invoices and line items within the request body.
                CalcTaxesResponse result = apiInstance.ApiV2AfcCalcTaxesPost(calcTaxesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxCalculationApi.ApiV2AfcCalcTaxesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2afccommitpost"></a>
# **ApiV2AfcCommitPost**
> CommitResponse ApiV2AfcCommitPost (CommitRequest commitRequest = null)

Commits or un-commits a document code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcCommitPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TaxCalculationApi(config);
            var commitRequest = new CommitRequest(); // CommitRequest | CommitRequest object containing document code and optional field data to override in reports. (optional) 

            try
            {
                // Commits or un-commits a document code.
                CommitResponse result = apiInstance.ApiV2AfcCommitPost(commitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxCalculationApi.ApiV2AfcCommitPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

