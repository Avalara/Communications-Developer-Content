# OpenapiClient::BundleItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_id** | **Integer** | Transaction id for item | [optional] 
**service_id** | **Integer** | Service id for item | [optional] 
**percentage** | **Float** | Percentage of package charge to be applied to item | [optional] 
**fixed_amount** | **Float** | Fixed charge to be applied to item | [optional] 
**lines** | **Integer** | Fixed lines to be applied to item | [optional] 
**minutes** | **Float** | Fixed minutes to be applied to item | [optional] 
**transaction_desc** | **String** | Transaction id for item | [optional] 
**service_desc** | **String** | Service id for item | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::BundleItem.new(transaction_id: null,
                                 service_id: null,
                                 percentage: null,
                                 fixed_amount: null,
                                 lines: null,
                                 minutes: null,
                                 transaction_desc: null,
                                 service_desc: null)
```


