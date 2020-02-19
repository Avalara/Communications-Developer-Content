# WWW::OpenAPIClient::HealthCheckApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::HealthCheckApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_health_check_get**](HealthCheckApi.md#api_v2_health_check_get) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use


# **api_v2_health_check_get**
> api_v2_health_check_get()

Health check that confirms the service is operational and ready to use

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::HealthCheckApi;
my $api_instance = WWW::OpenAPIClient::HealthCheckApi->new(

    # Configure HTTP basic authorization: Basic
    
);


eval { 
    $api_instance->api_v2_health_check_get();
};
if ($@) {
    warn "Exception when calling HealthCheckApi->api_v2_health_check_get: $@\n";
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

