# SaasPro.TaxCalculationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcCalcTaxesPost**](TaxCalculationApi.md#apiV2AfcCalcTaxesPost) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**apiV2AfcCommitPost**](TaxCalculationApi.md#apiV2AfcCommitPost) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.



## apiV2AfcCalcTaxesPost

> CalcTaxesResponse apiV2AfcCalcTaxesPost(opts)

Performs tax calculations on all invoices and line items within the request body.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.TaxCalculationApi();
let opts = {
  'calcTaxesRequest': new SaasPro.CalcTaxesRequest() // CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations.
};
apiInstance.apiV2AfcCalcTaxesPost(opts, (error, data, response) => {
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
 **calcTaxesRequest** | [**CalcTaxesRequest**](CalcTaxesRequest.md)| CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. | [optional] 

### Return type

[**CalcTaxesResponse**](CalcTaxesResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## apiV2AfcCommitPost

> CommitResponse apiV2AfcCommitPost(opts)

Commits or un-commits a document code.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.TaxCalculationApi();
let opts = {
  'commitRequest': new SaasPro.CommitRequest() // CommitRequest | CommitRequest object containing document code and optional field data to override in reports.
};
apiInstance.apiV2AfcCommitPost(opts, (error, data, response) => {
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
 **commitRequest** | [**CommitRequest**](CommitRequest.md)| CommitRequest object containing document code and optional field data to override in reports. | [optional] 

### Return type

[**CommitResponse**](CommitResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

