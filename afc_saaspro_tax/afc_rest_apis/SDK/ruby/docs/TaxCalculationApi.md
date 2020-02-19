# OpenapiClient::TaxCalculationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_calc_taxes_post**](TaxCalculationApi.md#api_v2_afc_calc_taxes_post) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**api_v2_afc_commit_post**](TaxCalculationApi.md#api_v2_afc_commit_post) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.



## api_v2_afc_calc_taxes_post

> CalcTaxesResponse api_v2_afc_calc_taxes_post(opts)

Performs tax calculations on all invoices and line items within the request body.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::TaxCalculationApi.new
opts = {
  calc_taxes_request: OpenapiClient::CalcTaxesRequest.new # CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations.
}

begin
  #Performs tax calculations on all invoices and line items within the request body.
  result = api_instance.api_v2_afc_calc_taxes_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TaxCalculationApi->api_v2_afc_calc_taxes_post: #{e}"
end
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


## api_v2_afc_commit_post

> CommitResponse api_v2_afc_commit_post(opts)

Commits or un-commits a document code.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::TaxCalculationApi.new
opts = {
  commit_request: OpenapiClient::CommitRequest.new # CommitRequest | CommitRequest object containing document code and optional field data to override in reports.
}

begin
  #Commits or un-commits a document code.
  result = api_instance.api_v2_afc_commit_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TaxCalculationApi->api_v2_afc_commit_post: #{e}"
end
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

