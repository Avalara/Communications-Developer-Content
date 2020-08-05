# avalara.comms.rest.v2.TaxCalculationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_calc_taxes_post**](TaxCalculationApi.md#api_v2_afc_calc_taxes_post) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**api_v2_afc_commit_post**](TaxCalculationApi.md#api_v2_afc_commit_post) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.


# **api_v2_afc_calc_taxes_post**
> CalcTaxesResponse api_v2_afc_calc_taxes_post(calc_taxes_request=calc_taxes_request)

Performs tax calculations on all invoices and line items within the request body.

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
    api_instance = avalara.comms.rest.v2.TaxCalculationApi(api_client)
    calc_taxes_request = avalara.comms.rest.v2.CalcTaxesRequest() # CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)

    try:
        # Performs tax calculations on all invoices and line items within the request body.
        api_response = api_instance.api_v2_afc_calc_taxes_post(calc_taxes_request=calc_taxes_request)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling TaxCalculationApi->api_v2_afc_calc_taxes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calc_taxes_request** | [**CalcTaxesRequest**](CalcTaxesRequest.md)| CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. | [optional] 

### Return type

[**CalcTaxesResponse**](CalcTaxesResponse.md)

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

# **api_v2_afc_commit_post**
> CommitResponse api_v2_afc_commit_post(commit_request=commit_request)

Commits or un-commits a document code.

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
    api_instance = avalara.comms.rest.v2.TaxCalculationApi(api_client)
    commit_request = avalara.comms.rest.v2.CommitRequest() # CommitRequest | CommitRequest object containing document code and optional field data to override in reports. (optional)

    try:
        # Commits or un-commits a document code.
        api_response = api_instance.api_v2_afc_commit_post(commit_request=commit_request)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling TaxCalculationApi->api_v2_afc_commit_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commit_request** | [**CommitRequest**](CommitRequest.md)| CommitRequest object containing document code and optional field data to override in reports. | [optional] 

### Return type

[**CommitResponse**](CommitResponse.md)

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

