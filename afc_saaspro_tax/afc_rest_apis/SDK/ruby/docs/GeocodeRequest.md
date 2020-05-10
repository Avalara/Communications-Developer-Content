# OpenapiClient::GeocodeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** | Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both. | [optional] 
**cass** | **Boolean** | Indicates if the CASS validated address is desired in the results. | [optional] 
**lat** | **Float** | Latitude for geocoding based on lat/long coordinates. | [optional] 
**long** | **Float** | Longitude for geocoding based on lat/long coordinates. | [optional] 
**addr** | **String** | Street address. | [optional] 
**city** | **String** | City name. | [optional] 
**st** | **String** | State name or abbreviation. | [optional] 
**zip** | **String** | Postal code. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::GeocodeRequest.new(ref: null,
                                 cass: null,
                                 lat: null,
                                 long: null,
                                 addr: null,
                                 city: null,
                                 st: null,
                                 zip: null)
```


