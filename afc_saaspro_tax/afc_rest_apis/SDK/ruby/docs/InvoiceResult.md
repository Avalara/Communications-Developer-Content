# OpenapiClient::InvoiceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **String** |  | [optional] 
**itms** | [**Array&lt;LineItemResult&gt;**](LineItemResult.md) |  | [optional] 
**summ** | [**Array&lt;SummarizedTax&gt;**](SummarizedTax.md) |  | [optional] 
**err** | [**Array&lt;Error&gt;**](Error.md) |  | [optional] 
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


