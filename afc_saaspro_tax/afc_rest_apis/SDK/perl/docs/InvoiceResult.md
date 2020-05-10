# WWW::OpenAPIClient::Object::InvoiceResult

## Load the model package
```perl
use WWW::OpenAPIClient::Object::InvoiceResult;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **string** | Document number for invoice. | [optional] 
**itms** | [**ARRAY[LineItemResult]**](LineItemResult.md) | Individual tax calculation results for each line item. | [optional] 
**summ** | [**ARRAY[SummarizedTax]**](SummarizedTax.md) | Summarized taxes for invoice. | [optional] 
**err** | [**ARRAY[Error]**](Error.md) | Error description (as applicable). | [optional] 
**incrf** | [**ReportingInformation**](ReportingInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


