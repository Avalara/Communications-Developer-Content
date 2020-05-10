# WWW::OpenAPIClient::Object::GeocodeResult

## Load the model package
```perl
use WWW::OpenAPIClient::Object::GeocodeResult;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **string** | Reference Id from geocode request input. | [optional] 
**cass** | [**Address**](Address.md) |  | [optional] 
**c_blk** | **int** | Census block. | [optional] 
**c_trc** | **int** | Census tract. | [optional] 
**cnty** | **string** | County | [optional] 
**feat** | **int** | Feature ID. | [optional] 
**fips** | **string** | FIPS Code. | [optional] 
**inc** | **boolean** | Indicates if address is within city limits. | [optional] 
**jur** | **string** | Tax jurisdiction name. | [optional] 
**lat** | **double** | Latitude. | [optional] 
**long** | **double** | Longitude. | [optional] 
**pcd** | **int** | PCode for tax jurisdiction. | [optional] 
**scr** | **double** | Score indicating accuracy of address match in mapping database. | [optional] 
**err** | **string** | Error message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


