# SaasPro.HealthCheckApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2HealthCheckGet**](HealthCheckApi.md#apiV2HealthCheckGet) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use



## apiV2HealthCheckGet

> apiV2HealthCheckGet()

Health check that confirms the service is operational and ready to use

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.HealthCheckApi();
apiInstance.apiV2HealthCheckGet((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

