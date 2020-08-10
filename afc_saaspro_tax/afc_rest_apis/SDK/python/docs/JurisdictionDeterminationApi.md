# avalara.comms.rest.v2.JurisdictionDeterminationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_p_code_post**](JurisdictionDeterminationApi.md#api_v2_afc_p_code_post) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**api_v2_geo_batch_log_process_id_get**](JurisdictionDeterminationApi.md#api_v2_geo_batch_log_process_id_get) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**api_v2_geo_batch_status_process_id_get**](JurisdictionDeterminationApi.md#api_v2_geo_batch_status_process_id_get) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**api_v2_geo_batch_upload_post**](JurisdictionDeterminationApi.md#api_v2_geo_batch_upload_post) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**api_v2_geo_geocode_post**](JurisdictionDeterminationApi.md#api_v2_geo_geocode_post) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.


# **api_v2_afc_p_code_post**
> PCodeLookupResult api_v2_afc_p_code_post(p_code_lookup_request=p_code_lookup_request)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

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
    api_instance = avalara.comms.rest.v2.JurisdictionDeterminationApi(api_client)
    p_code_lookup_request = avalara.comms.rest.v2.PCodeLookupRequest() # PCodeLookupRequest |  (optional)

    try:
        # Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
        api_response = api_instance.api_v2_afc_p_code_post(p_code_lookup_request=p_code_lookup_request)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling JurisdictionDeterminationApi->api_v2_afc_p_code_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code_lookup_request** | [**PCodeLookupRequest**](PCodeLookupRequest.md)|  | [optional] 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_batch_log_process_id_get**
> GeoBatchLog api_v2_geo_batch_log_process_id_get(process_id)

Retrieves log on Geo Batch file

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
    api_instance = avalara.comms.rest.v2.JurisdictionDeterminationApi(api_client)
    process_id = 'process_id_example' # str | Process Id for Geo Batch File.

    try:
        # Retrieves log on Geo Batch file
        api_response = api_instance.api_v2_geo_batch_log_process_id_get(process_id)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_log_process_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **str**| Process Id for Geo Batch File. | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_batch_status_process_id_get**
> GeoBatchStatus api_v2_geo_batch_status_process_id_get(process_id)

Retrieves information on Geo Batch file status

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
    api_instance = avalara.comms.rest.v2.JurisdictionDeterminationApi(api_client)
    process_id = 'process_id_example' # str | Process Id for Geo Batch File.

    try:
        # Retrieves information on Geo Batch file status
        api_response = api_instance.api_v2_geo_batch_status_process_id_get(process_id)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_status_process_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **str**| Process Id for Geo Batch File. | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_batch_upload_post**
> GeoBatchSubmitFileResponse api_v2_geo_batch_upload_post(geo_batch_file=geo_batch_file)

Uploads file to Geo Batch.

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
    api_instance = avalara.comms.rest.v2.JurisdictionDeterminationApi(api_client)
    geo_batch_file = '/path/to/file' # file |  (optional)

    try:
        # Uploads file to Geo Batch.
        api_response = api_instance.api_v2_geo_batch_upload_post(geo_batch_file=geo_batch_file)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_upload_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geo_batch_file** | **file**|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_geocode_post**
> list[GeocodeResult] api_v2_geo_geocode_post(geocode_request=geocode_request)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

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
    api_instance = avalara.comms.rest.v2.JurisdictionDeterminationApi(api_client)
    geocode_request = [avalara.comms.rest.v2.GeocodeRequest()] # list[GeocodeRequest] | List of street addresses and/or lat/long coordinate pairs to geocode. (optional)

    try:
        # Geocodes one or multiple street addresses and/or lat/long coordinate pairs.
        api_response = api_instance.api_v2_geo_geocode_post(geocode_request=geocode_request)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling JurisdictionDeterminationApi->api_v2_geo_geocode_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geocode_request** | [**list[GeocodeRequest]**](GeocodeRequest.md)| List of street addresses and/or lat/long coordinate pairs to geocode. | [optional] 

### Return type

[**list[GeocodeResult]**](GeocodeResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

