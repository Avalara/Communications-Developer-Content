# InvoiceResult

Tax calculation results for an invoice.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **str** | Document number for invoice. | [optional] 
**itms** | [**list[LineItemResult]**](LineItemResult.md) | Individual tax calculation results for each line item. | [optional] 
**summ** | [**list[SummarizedTax]**](SummarizedTax.md) | Summarized taxes for invoice. | [optional] 
**err** | [**list[Error]**](Error.md) | Error description (as applicable). | [optional] 
**incrf** | [**ReportingInformation**](ReportingInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


