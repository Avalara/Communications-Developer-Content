# OpenapiClient::GeocodeResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** | Reference Id from geocode request input. | [optional] 
**cass** | [**Address**](Address.md) |  | [optional] 
**c_blk** | **Integer** | Census block. | [optional] 
**c_trc** | **Integer** | Census tract. | [optional] 
**cnty** | **String** | County | [optional] 
**feat** | **Integer** | Feature ID. | [optional] 
**fips** | **String** | FIPS Code. | [optional] 
**inc** | **Boolean** | Indicates if address is within city limits. | [optional] 
**jur** | **String** | Tax jurisdiction name. | [optional] 
**lat** | **Float** | Latitude. | [optional] 
**long** | **Float** | Longitude. | [optional] 
**pcd** | **Integer** | PCode for tax jurisdiction. | [optional] 
**scr** | **Float** | Score indicating accuracy of address match in mapping database. | [optional] 
**err** | **String** | Error message. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::GeocodeResult.new(ref: null,
                                 cass: null,
                                 c_blk: null,
                                 c_trc: null,
                                 cnty: null,
                                 feat: null,
                                 fips: null,
                                 inc: null,
                                 jur: null,
                                 lat: null,
                                 long: null,
                                 pcd: null,
                                 scr: null,
                                 err: null)
```


