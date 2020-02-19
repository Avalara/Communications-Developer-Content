# avalara.comms.rest.v2.Api.LookupsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2AfcLocationPcodeGet**](LookupsApi.md#apiv2afclocationpcodeget) | **GET** /api/v2/afc/location/{pcode} | Get location data associated with a PCode
[**ApiV2AfcPrimaryPCodeGet**](LookupsApi.md#apiv2afcprimarypcodeget) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**ApiV2AfcServiceinfoGet**](LookupsApi.md#apiv2afcserviceinfoget) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**ApiV2AfcTaxtypeTaxTypeGet**](LookupsApi.md#apiv2afctaxtypetaxtypeget) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**ApiV2AfcTspairsGet**](LookupsApi.md#apiv2afctspairsget) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information



## ApiV2AfcLocationPcodeGet

> PCodeLookupResult ApiV2AfcLocationPcodeGet (int pcode)

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcLocationPcodeGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupsApi(Configuration.Default);
            var pcode = 56;  // int | 

            try
            {
                // Get location data associated with a PCode
                PCodeLookupResult result = apiInstance.ApiV2AfcLocationPcodeGet(pcode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LookupsApi.ApiV2AfcLocationPcodeGet: " + e.Message );
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
 **pcode** | **int**|  | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2AfcPrimaryPCodeGet

> PCodeLookupResult ApiV2AfcPrimaryPCodeGet (int pCode)

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcPrimaryPCodeGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupsApi(Configuration.Default);
            var pCode = 56;  // int | 

            try
            {
                // Get primary location data associated with a PCode
                PCodeLookupResult result = apiInstance.ApiV2AfcPrimaryPCodeGet(pCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LookupsApi.ApiV2AfcPrimaryPCodeGet: " + e.Message );
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
 **pCode** | **int**|  | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2AfcServiceinfoGet

> ServiceInfo ApiV2AfcServiceinfoGet ()

Retrieves server time, service build version and engine version

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcServiceinfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupsApi(Configuration.Default);

            try
            {
                // Retrieves server time, service build version and engine version
                ServiceInfo result = apiInstance.ApiV2AfcServiceinfoGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LookupsApi.ApiV2AfcServiceinfoGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2AfcTaxtypeTaxTypeGet

> List&lt;TaxTypeData&gt; ApiV2AfcTaxtypeTaxTypeGet (string taxType)

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcTaxtypeTaxTypeGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupsApi(Configuration.Default);
            var taxType = taxType_example;  // string | Tax type ID for the tax type.

            try
            {
                // Get the tax information (description and category) for a tax type ID
                List<TaxTypeData> result = apiInstance.ApiV2AfcTaxtypeTaxTypeGet(taxType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LookupsApi.ApiV2AfcTaxtypeTaxTypeGet: " + e.Message );
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
 **taxType** | **string**| Tax type ID for the tax type. | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2AfcTspairsGet

> List&lt;TSPairData&gt; ApiV2AfcTspairsGet ()

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcTspairsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupsApi(Configuration.Default);

            try
            {
                // Get transaction/service pair information
                List<TSPairData> result = apiInstance.ApiV2AfcTspairsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LookupsApi.ApiV2AfcTspairsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;TSPairData&gt;**](TSPairData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

