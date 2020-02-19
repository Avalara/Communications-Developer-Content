# OpenapiClient::PCodeLookupResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_data** | [**Array&lt;LocationItem&gt;**](LocationItem.md) |  | [optional] 
**match_count** | **Integer** |  | [optional] 
**input_match_type** | **String** |  | [optional] 
**match_type_applied** | **String** |  | [optional] 
**results_limit** | **Integer** |  | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::PCodeLookupResult.new(location_data: null,
                                 match_count: null,
                                 input_match_type: null,
                                 match_type_applied: null,
                                 results_limit: null)
```


