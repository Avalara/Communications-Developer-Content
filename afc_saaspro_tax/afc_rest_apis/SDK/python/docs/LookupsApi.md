# avalara.comms.rest.v2.LookupsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_location_p_code_get**](LookupsApi.md#api_v2_afc_location_p_code_get) | **GET** /api/v2/afc/location/{pCode} | Get location data associated with a PCode
[**api_v2_afc_primary_p_code_get**](LookupsApi.md#api_v2_afc_primary_p_code_get) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**api_v2_afc_serviceinfo_get**](LookupsApi.md#api_v2_afc_serviceinfo_get) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**api_v2_afc_taxtype_tax_type_get**](LookupsApi.md#api_v2_afc_taxtype_tax_type_get) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**api_v2_afc_tspairs_get**](LookupsApi.md#api_v2_afc_tspairs_get) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information


# **api_v2_afc_location_p_code_get**
> PCodeLookupResult api_v2_afc_location_p_code_get(p_code)

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

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
    api_instance = avalara.comms.rest.v2.LookupsApi(api_client)
    p_code = 56 # int | 

    try:
        # Get location data associated with a PCode
        api_response = api_instance.api_v2_afc_location_p_code_get(p_code)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling LookupsApi->api_v2_afc_location_p_code_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code** | **int**|  | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_primary_p_code_get**
> PCodeLookupResult api_v2_afc_primary_p_code_get(p_code)

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

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
    api_instance = avalara.comms.rest.v2.LookupsApi(api_client)
    p_code = 56 # int | 

    try:
        # Get primary location data associated with a PCode
        api_response = api_instance.api_v2_afc_primary_p_code_get(p_code)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling LookupsApi->api_v2_afc_primary_p_code_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code** | **int**|  | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_serviceinfo_get**
> ServiceInfo api_v2_afc_serviceinfo_get()

Retrieves server time, service build version and engine version

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
    api_instance = avalara.comms.rest.v2.LookupsApi(api_client)
    
    try:
        # Retrieves server time, service build version and engine version
        api_response = api_instance.api_v2_afc_serviceinfo_get()
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling LookupsApi->api_v2_afc_serviceinfo_get: %s\n" % e)
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_taxtype_tax_type_get**
> list[TaxTypeData] api_v2_afc_taxtype_tax_type_get(tax_type)

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

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
    api_instance = avalara.comms.rest.v2.LookupsApi(api_client)
    tax_type = 'tax_type_example' # str | Tax type ID for the tax type.

    try:
        # Get the tax information (description and category) for a tax type ID
        api_response = api_instance.api_v2_afc_taxtype_tax_type_get(tax_type)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling LookupsApi->api_v2_afc_taxtype_tax_type_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tax_type** | **str**| Tax type ID for the tax type. | 

### Return type

[**list[TaxTypeData]**](TaxTypeData.md)

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

# **api_v2_afc_tspairs_get**
> list[TSPairData] api_v2_afc_tspairs_get()

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

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
    api_instance = avalara.comms.rest.v2.LookupsApi(api_client)
    
    try:
        # Get transaction/service pair information
        api_response = api_instance.api_v2_afc_tspairs_get()
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling LookupsApi->api_v2_afc_tspairs_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[TSPairData]**](TSPairData.md)

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

