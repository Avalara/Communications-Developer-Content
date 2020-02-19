# OpenapiClient::PCodeLookupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**country_iso** | **String** |  | [optional] 
**state** | **String** |  | [optional] 
**county** | **String** |  | [optional] 
**city** | **String** |  | [optional] 
**zip_code** | **String** |  | [optional] 
**best_match** | **Boolean** |  | [optional] 
**limit_results** | **Integer** |  | [optional] 
**npa_nxx** | **String** |  | [optional] 
**fips** | **String** |  | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::PCodeLookupRequest.new(country_iso: null,
                                 state: null,
                                 county: null,
                                 city: null,
                                 zip_code: null,
                                 best_match: null,
                                 limit_results: null,
                                 npa_nxx: null,
                                 fips: null)
```


