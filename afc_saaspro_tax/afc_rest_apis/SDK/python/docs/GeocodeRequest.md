# GeocodeRequest

Input data for Geocoding API.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **str** | Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both. | [optional] 
**cass** | **bool** | Indicates if the CASS validated address is desired in the results. | [optional] 
**lat** | **float** | Latitude for geocoding based on lat/long coordinates. | [optional] 
**long** | **float** | Longitude for geocoding based on lat/long coordinates. | [optional] 
**addr** | **str** | Street address. | [optional] 
**city** | **str** | City name. | [optional] 
**st** | **str** | State name or abbreviation. | [optional] 
**zip** | **str** | Postal code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


