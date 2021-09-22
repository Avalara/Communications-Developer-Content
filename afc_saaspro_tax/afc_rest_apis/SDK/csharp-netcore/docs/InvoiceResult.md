# avalara.comms.rest.v2.Model.InvoiceResult
Tax calculation results for an invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Doc** | **string** | Document number for invoice. | [optional] 
**Itms** | [**List&lt;LineItemResult&gt;**](LineItemResult.md) | Individual tax calculation results for each line item. | [optional] 
**Summ** | [**List&lt;SummarizedTax&gt;**](SummarizedTax.md) | Summarized taxes for invoice. | [optional] 
**Err** | [**List&lt;Error&gt;**](Error.md) | Error description (as applicable). | [optional] 
**Incrf** | [**ReportingInformation**](ReportingInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

