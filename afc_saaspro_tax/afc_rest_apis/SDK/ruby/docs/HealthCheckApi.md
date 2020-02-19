# OpenapiClient::HealthCheckApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_health_check_get**](HealthCheckApi.md#api_v2_health_check_get) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use



## api_v2_health_check_get

> api_v2_health_check_get

Health check that confirms the service is operational and ready to use

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::HealthCheckApi.new

begin
  #Health check that confirms the service is operational and ready to use
  api_instance.api_v2_health_check_get
rescue OpenapiClient::ApiError => e
  puts "Exception when calling HealthCheckApi->api_v2_health_check_get: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

