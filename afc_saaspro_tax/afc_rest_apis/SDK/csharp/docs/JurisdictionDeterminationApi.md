# avalara.comms.rest.v2.Api.JurisdictionDeterminationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2AfcPCodePost**](JurisdictionDeterminationApi.md#apiv2afcpcodepost) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**ApiV2GeoBatchLogProcessIdGet**](JurisdictionDeterminationApi.md#apiv2geobatchlogprocessidget) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**ApiV2GeoBatchStatusProcessIdGet**](JurisdictionDeterminationApi.md#apiv2geobatchstatusprocessidget) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**ApiV2GeoBatchUploadPost**](JurisdictionDeterminationApi.md#apiv2geobatchuploadpost) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**ApiV2GeoGeocodePost**](JurisdictionDeterminationApi.md#apiv2geogeocodepost) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.



## ApiV2AfcPCodePost

> PCodeLookupResult ApiV2AfcPCodePost (PCodeLookupRequest pCodeLookupRequest = null)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2AfcPCodePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JurisdictionDeterminationApi(Configuration.Default);
            var pCodeLookupRequest = new PCodeLookupRequest(); // PCodeLookupRequest |  (optional) 

            try
            {
                // Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
                PCodeLookupResult result = apiInstance.ApiV2AfcPCodePost(pCodeLookupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling JurisdictionDeterminationApi.ApiV2AfcPCodePost: " + e.Message );
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
 **pCodeLookupRequest** | [**PCodeLookupRequest**](PCodeLookupRequest.md)|  | [optional] 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2GeoBatchLogProcessIdGet

> GeoBatchLog ApiV2GeoBatchLogProcessIdGet (string processId)

Retrieves log on Geo Batch file

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2GeoBatchLogProcessIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JurisdictionDeterminationApi(Configuration.Default);
            var processId = processId_example;  // string | Process Id for Geo Batch File.

            try
            {
                // Retrieves log on Geo Batch file
                GeoBatchLog result = apiInstance.ApiV2GeoBatchLogProcessIdGet(processId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling JurisdictionDeterminationApi.ApiV2GeoBatchLogProcessIdGet: " + e.Message );
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
 **processId** | **string**| Process Id for Geo Batch File. | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2GeoBatchStatusProcessIdGet

> GeoBatchStatus ApiV2GeoBatchStatusProcessIdGet (string processId)

Retrieves information on Geo Batch file status

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2GeoBatchStatusProcessIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JurisdictionDeterminationApi(Configuration.Default);
            var processId = processId_example;  // string | Process Id for Geo Batch File.

            try
            {
                // Retrieves information on Geo Batch file status
                GeoBatchStatus result = apiInstance.ApiV2GeoBatchStatusProcessIdGet(processId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling JurisdictionDeterminationApi.ApiV2GeoBatchStatusProcessIdGet: " + e.Message );
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
 **processId** | **string**| Process Id for Geo Batch File. | 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2GeoBatchUploadPost

> GeoBatchSubmitFileResponse ApiV2GeoBatchUploadPost (System.IO.Stream geoBatchFile = null)

Uploads file to Geo Batch.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2GeoBatchUploadPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JurisdictionDeterminationApi(Configuration.Default);
            var geoBatchFile = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Uploads file to Geo Batch.
                GeoBatchSubmitFileResponse result = apiInstance.ApiV2GeoBatchUploadPost(geoBatchFile);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling JurisdictionDeterminationApi.ApiV2GeoBatchUploadPost: " + e.Message );
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
 **geoBatchFile** | **System.IO.Stream**|  | [optional] 

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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV2GeoGeocodePost

> List&lt;GeocodeResult&gt; ApiV2GeoGeocodePost (List<GeocodeRequest> geocodeRequest = null)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2GeoGeocodePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JurisdictionDeterminationApi(Configuration.Default);
            var geocodeRequest = new List<GeocodeRequest>(); // List<GeocodeRequest> | List of street addresses and/or lat/long coordinate pairs to geocode. (optional) 

            try
            {
                // Geocodes one or multiple street addresses and/or lat/long coordinate pairs.
                List<GeocodeResult> result = apiInstance.ApiV2GeoGeocodePost(geocodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling JurisdictionDeterminationApi.ApiV2GeoGeocodePost: " + e.Message );
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
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

