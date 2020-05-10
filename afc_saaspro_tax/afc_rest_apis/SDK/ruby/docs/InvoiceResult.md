# OpenapiClient::InvoiceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **String** | Document number for invoice. | [optional] 
**itms** | [**Array&lt;LineItemResult&gt;**](LineItemResult.md) | Individual tax calculation results for each line item. | [optional] 
**summ** | [**Array&lt;SummarizedTax&gt;**](SummarizedTax.md) | Summarized taxes for invoice. | [optional] 
**err** | [**Array&lt;Error&gt;**](Error.md) | Error description (as applicable). | [optional] 
**incrf** | [**ReportingInformation**](ReportingInformation.md) |  | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::InvoiceResult.new(doc: null,
                                 itms: null,
                                 summ: null,
                                 err: null,
                                 incrf: null)
```


