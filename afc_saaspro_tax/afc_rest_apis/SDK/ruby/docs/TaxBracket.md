# OpenapiClient::TaxBracket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**rate** | **Float** | Tax rate. Value cannot be negative. For rated taxes, value must be from 0 to 1. Otherwise, value may be larger. | [optional] 
**max** | **Float** | Maximum base that this rate applies to. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::TaxBracket.new(rate: null,
                                 max: null)
```


