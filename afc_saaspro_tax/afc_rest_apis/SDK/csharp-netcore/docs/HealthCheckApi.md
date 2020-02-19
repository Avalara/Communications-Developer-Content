# avalara.comms.rest.v2.Api.HealthCheckApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2HealthCheckGet**](HealthCheckApi.md#apiv2healthcheckget) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use


<a name="apiv2healthcheckget"></a>
# **ApiV2HealthCheckGet**
> void ApiV2HealthCheckGet ()

Health check that confirms the service is operational and ready to use

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2HealthCheckGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthCheckApi(config);

            try
            {
                // Health check that confirms the service is operational and ready to use
                apiInstance.ApiV2HealthCheckGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthCheckApi.ApiV2HealthCheckGet: " + e.Message );
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

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

