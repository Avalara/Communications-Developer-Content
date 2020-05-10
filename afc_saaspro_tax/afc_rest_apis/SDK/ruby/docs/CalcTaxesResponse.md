# OpenapiClient::CalcTaxesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**inv** | [**Array&lt;InvoiceResult&gt;**](InvoiceResult.md) | Tax calculation results for each invoice submitted in request. | [optional] 
**err** | [**Array&lt;Error&gt;**](Error.md) | Error description (as applicable). | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::CalcTaxesResponse.new(inv: null,
                                 err: null)
```


