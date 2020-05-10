# avalara.comms.rest.v2.CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_profiles_get_profiles_get**](CustomizationApi.md#api_v2_profiles_get_profiles_get) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items


# **api_v2_profiles_get_profiles_get**
> TaxCalculationSettingsResponse api_v2_profiles_get_profiles_get(requested_client_id=requested_client_id, requested_profile_id=requested_profile_id, item_type=item_type)

Retrieves one or more profiles with associated settings and configurable items

### Example

```python
from __future__ import print_function
import time
import avalara.comms.rest.v2
from avalara.comms.rest.v2.rest import ApiException
from pprint import pprint
configuration = avalara.comms.rest.v2.Configuration()

# Defining host is optional and default to http://localhost
configuration.host = "http://localhost"
# Enter a context with an instance of the API client
with avalara.comms.rest.v2.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = avalara.comms.rest.v2.CustomizationApi(api_client)
    requested_client_id = 56 # int | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional)
requested_profile_id = 56 # int | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional)
item_type = avalara.comms.rest.v2.TaxCalculationSettingTypes() # TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional)

    try:
        # Retrieves one or more profiles with associated settings and configurable items
        api_response = api_instance.api_v2_profiles_get_profiles_get(requested_client_id=requested_client_id, requested_profile_id=requested_profile_id, item_type=item_type)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling CustomizationApi->api_v2_profiles_get_profiles_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requested_client_id** | **int**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional] 
 **requested_profile_id** | **int**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional] 
 **item_type** | [**TaxCalculationSettingTypes**](.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

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

