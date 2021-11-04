

# InvoiceResult

Tax calculation results for an invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **String** | Document number for invoice. |  [optional]
**itms** | [**List&lt;LineItemResult&gt;**](LineItemResult.md) | Individual tax calculation results for each line item. |  [optional]
**summ** | [**List&lt;SummarizedTax&gt;**](SummarizedTax.md) | Summarized taxes for invoice. |  [optional]
**err** | [**List&lt;Error&gt;**](Error.md) | Error description (as applicable). |  [optional]
**incrf** | [**ReportingInformation**](ReportingInformation.md) |  |  [optional]



