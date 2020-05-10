# GeocodeResult

Results for geocoding request.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **str** | Reference Id from geocode request input. | [optional] 
**cass** | [**Address**](Address.md) |  | [optional] 
**c_blk** | **int** | Census block. | [optional] 
**c_trc** | **int** | Census tract. | [optional] 
**cnty** | **str** | County | [optional] 
**feat** | **int** | Feature ID. | [optional] 
**fips** | **str** | FIPS Code. | [optional] 
**inc** | **bool** | Indicates if address is within city limits. | [optional] 
**jur** | **str** | Tax jurisdiction name. | [optional] 
**lat** | **float** | Latitude. | [optional] 
**long** | **float** | Longitude. | [optional] 
**pcd** | **int** | PCode for tax jurisdiction. | [optional] 
**scr** | **float** | Score indicating accuracy of address match in mapping database. | [optional] 
**err** | **str** | Error message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


