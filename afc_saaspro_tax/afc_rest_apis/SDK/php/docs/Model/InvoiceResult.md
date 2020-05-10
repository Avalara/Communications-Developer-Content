# # InvoiceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **string** | Document number for invoice. | [optional] 
**itms** | [**\OpenAPI\Client\Model\LineItemResult[]**](LineItemResult.md) | Individual tax calculation results for each line item. | [optional] 
**summ** | [**\OpenAPI\Client\Model\SummarizedTax[]**](SummarizedTax.md) | Summarized taxes for invoice. | [optional] 
**err** | [**\OpenAPI\Client\Model\Error[]**](Error.md) | Error description (as applicable). | [optional] 
**incrf** | [**\OpenAPI\Client\Model\ReportingInformation**](ReportingInformation.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


