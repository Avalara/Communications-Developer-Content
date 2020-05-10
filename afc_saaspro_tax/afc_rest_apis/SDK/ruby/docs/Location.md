# OpenapiClient::Location

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cnty** | **String** | County name. | [optional] 
**ctry** | **String** | Country ISO code. | [optional] 
**int** | **Boolean** | Indicates if the location is within city limits.  Default: true. | [optional] 
**geo** | **Boolean** | Indicates if this address should be geocoded in order to obtain taxing jurisdiction.  Default: false. | [optional] 
**pcd** | **Integer** | PCode for taxing jurisdiction. | [optional] 
**npa** | **Integer** | NPANXX number. | [optional] 
**fips** | **String** | FIPS code for taxing jurisdiction. | [optional] 
**addr** | **String** | Street address. | [optional] 
**city** | **String** | City name. | [optional] 
**st** | **String** | State name or abbreviation. | [optional] 
**zip** | **String** | Postal code. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::Location.new(cnty: null,
                                 ctry: null,
                                 int: null,
                                 geo: null,
                                 pcd: null,
                                 npa: null,
                                 fips: null,
                                 addr: null,
                                 city: null,
                                 st: null,
                                 zip: null)
```


