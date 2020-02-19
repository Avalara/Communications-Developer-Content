# OpenAPI\Client\HealthCheckApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2HealthCheckGet**](HealthCheckApi.md#apiV2HealthCheckGet) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use



## apiV2HealthCheckGet

> apiV2HealthCheckGet()

Health check that confirms the service is operational and ready to use

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\HealthCheckApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->apiV2HealthCheckGet();
} catch (Exception $e) {
    echo 'Exception when calling HealthCheckApi->apiV2HealthCheckGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

