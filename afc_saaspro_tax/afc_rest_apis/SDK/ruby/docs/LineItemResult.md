# OpenapiClient::LineItemResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** | Reference ID for line item. | [optional] 
**base** | **Float** | Base sale amount for tax-inclusive line items. | [optional] 
**txs** | [**Array&lt;Tax&gt;**](Tax.md) | Taxes generated for line item. | [optional] 
**err** | [**Array&lt;Error&gt;**](Error.md) | Error description (as applicable). | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::LineItemResult.new(ref: null,
                                 base: null,
                                 txs: null,
                                 err: null)
```


