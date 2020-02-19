# SaasPro.LookupsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcLocationPcodeGet**](LookupsApi.md#apiV2AfcLocationPcodeGet) | **GET** /api/v2/afc/location/{pcode} | Get location data associated with a PCode
[**apiV2AfcPrimaryPCodeGet**](LookupsApi.md#apiV2AfcPrimaryPCodeGet) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**apiV2AfcServiceinfoGet**](LookupsApi.md#apiV2AfcServiceinfoGet) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**apiV2AfcTaxtypeTaxTypeGet**](LookupsApi.md#apiV2AfcTaxtypeTaxTypeGet) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**apiV2AfcTspairsGet**](LookupsApi.md#apiV2AfcTspairsGet) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information



## apiV2AfcLocationPcodeGet

> PCodeLookupResult apiV2AfcLocationPcodeGet(pcode)

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.LookupsApi();
let pcode = 56; // Number | 
apiInstance.apiV2AfcLocationPcodeGet(pcode, (error, data, response) => {
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
 **pcode** | **Number**|  | 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## apiV2AfcPrimaryPCodeGet

> PCodeLookupResult apiV2AfcPrimaryPCodeGet(pCode)

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.LookupsApi();
let pCode = 56; // Number | 
apiInstance.apiV2AfcPrimaryPCodeGet(pCode, (error, data, response) => {
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
 **pCode** | **Number**|  | 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## apiV2AfcServiceinfoGet

> ServiceInfo apiV2AfcServiceinfoGet()

Retrieves server time, service build version and engine version

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.LookupsApi();
apiInstance.apiV2AfcServiceinfoGet((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
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


## apiV2AfcTaxtypeTaxTypeGet

> [TaxTypeData] apiV2AfcTaxtypeTaxTypeGet(taxType)

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.LookupsApi();
let taxType = "taxType_example"; // String | Tax type ID for the tax type.
apiInstance.apiV2AfcTaxtypeTaxTypeGet(taxType, (error, data, response) => {
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
 **taxType** | **String**| Tax type ID for the tax type. | 

### Return type

[**[TaxTypeData]**](TaxTypeData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## apiV2AfcTspairsGet

> [TSPairData] apiV2AfcTspairsGet()

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.LookupsApi();
apiInstance.apiV2AfcTspairsGet((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[TSPairData]**](TSPairData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

