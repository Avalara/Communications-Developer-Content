# SaasPro.JurisdictionDeterminationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcPCodePost**](JurisdictionDeterminationApi.md#apiV2AfcPCodePost) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**apiV2GeoBatchLogProcessIdGet**](JurisdictionDeterminationApi.md#apiV2GeoBatchLogProcessIdGet) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**apiV2GeoBatchStatusProcessIdGet**](JurisdictionDeterminationApi.md#apiV2GeoBatchStatusProcessIdGet) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**apiV2GeoBatchUploadPost**](JurisdictionDeterminationApi.md#apiV2GeoBatchUploadPost) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**apiV2GeoGeocodePost**](JurisdictionDeterminationApi.md#apiV2GeoGeocodePost) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.



## apiV2AfcPCodePost

> PCodeLookupResult apiV2AfcPCodePost(opts)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.JurisdictionDeterminationApi();
let opts = {
  'pCodeLookupRequest': new SaasPro.PCodeLookupRequest() // PCodeLookupRequest | 
};
apiInstance.apiV2AfcPCodePost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pCodeLookupRequest** | [**PCodeLookupRequest**](PCodeLookupRequest.md)|  | [optional] 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## apiV2GeoBatchLogProcessIdGet

> GeoBatchLog apiV2GeoBatchLogProcessIdGet(processId)

Retrieves log on Geo Batch file

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.JurisdictionDeterminationApi();
let processId = "processId_example"; // String | Process Id for Geo Batch File.
apiInstance.apiV2GeoBatchLogProcessIdGet(processId, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **String**| Process Id for Geo Batch File. | 

### Return type

[**GeoBatchLog**](GeoBatchLog.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## apiV2GeoBatchStatusProcessIdGet

> GeoBatchStatus apiV2GeoBatchStatusProcessIdGet(processId)

Retrieves information on Geo Batch file status

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.JurisdictionDeterminationApi();
let processId = "processId_example"; // String | Process Id for Geo Batch File.
apiInstance.apiV2GeoBatchStatusProcessIdGet(processId, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **String**| Process Id for Geo Batch File. | 

### Return type

[**GeoBatchStatus**](GeoBatchStatus.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## apiV2GeoBatchUploadPost

> GeoBatchSubmitFileResponse apiV2GeoBatchUploadPost(opts)

Uploads file to Geo Batch.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.JurisdictionDeterminationApi();
let opts = {
  'geoBatchFile': "/path/to/file" // File | 
};
apiInstance.apiV2GeoBatchUploadPost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geoBatchFile** | **File**|  | [optional] 

### Return type

[**GeoBatchSubmitFileResponse**](GeoBatchSubmitFileResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: text/plain, application/json, text/json


## apiV2GeoGeocodePost

> [GeocodeResult] apiV2GeoGeocodePost(opts)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.JurisdictionDeterminationApi();
let opts = {
  'geocodeRequest': [new SaasPro.GeocodeRequest()] // [GeocodeRequest] | List of street addresses and/or lat/long coordinate pairs to geocode.
};
apiInstance.apiV2GeoGeocodePost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geocodeRequest** | [**[GeocodeRequest]**](GeocodeRequest.md)| List of street addresses and/or lat/long coordinate pairs to geocode. | [optional] 

### Return type

[**[GeocodeResult]**](GeocodeResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

