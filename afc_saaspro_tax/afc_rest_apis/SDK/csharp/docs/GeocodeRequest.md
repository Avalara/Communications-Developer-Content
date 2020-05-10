
# avalara.comms.rest.v2.Model.GeocodeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ref** | **string** | Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both. | [optional] 
**Cass** | **bool?** | Indicates if the CASS validated address is desired in the results. | [optional] 
**Lat** | **double?** | Latitude for geocoding based on lat/long coordinates. | [optional] 
**Long** | **double?** | Longitude for geocoding based on lat/long coordinates. | [optional] 
**Addr** | **string** | Street address. | [optional] 
**City** | **string** | City name. | [optional] 
**St** | **string** | State name or abbreviation. | [optional] 
**Zip** | **string** | Postal code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

