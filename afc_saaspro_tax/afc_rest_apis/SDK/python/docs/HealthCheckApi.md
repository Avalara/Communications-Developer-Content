# avalara.comms.rest.v2.HealthCheckApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_health_check_get**](HealthCheckApi.md#api_v2_health_check_get) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use


# **api_v2_health_check_get**
> api_v2_health_check_get()

Health check that confirms the service is operational and ready to use

### Example

```python
from __future__ import print_function
import time
import avalara.comms.rest.v2
from avalara.comms.rest.v2.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = avalara.comms.rest.v2.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Enter a context with an instance of the API client
with avalara.comms.rest.v2.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = avalara.comms.rest.v2.HealthCheckApi(api_client)
    
    try:
        # Health check that confirms the service is operational and ready to use
        api_instance.api_v2_health_check_get()
    except ApiException as e:
        print("Exception when calling HealthCheckApi->api_v2_health_check_get: %s\n" % e)
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
**200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

