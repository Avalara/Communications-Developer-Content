# WWW::OpenAPIClient::Object::GeoBatchStatus

## Load the model package
```perl
use WWW::OpenAPIClient::Object::GeoBatchStatus;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**process_id** | **int** | Process ID for Batch file. | [optional] 
**request_date** | **DateTime** | Request Date. | [optional] 
**processing_start** | **DateTime** | Processing Start. | [optional] 
**processing_end** | **DateTime** | Processing End. | [optional] 
**status** | **string** | Status Of Batch File. | [optional] 
**downloads** | [**GeoBatchDownloadResponse**](GeoBatchDownloadResponse.md) | Output File Name. | [optional] 
**error** | [**ARRAY[Error]**](Error.md) | Error information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


