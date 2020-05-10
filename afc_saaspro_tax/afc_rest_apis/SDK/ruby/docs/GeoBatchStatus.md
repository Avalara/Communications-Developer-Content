# OpenapiClient::GeoBatchStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**process_id** | **Integer** | Process ID for Batch file. | [optional] 
**request_date** | **DateTime** | Request Date. | [optional] 
**processing_start** | **DateTime** | Processing Start. | [optional] 
**processing_end** | **DateTime** | Processing End. | [optional] 
**status** | **String** | Status Of Batch File. | [optional] 
**downloads** | [**GeoBatchDownloadResponse**](GeoBatchDownloadResponse.md) |  | [optional] 
**error** | [**Array&lt;Error&gt;**](Error.md) | Error information. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::GeoBatchStatus.new(process_id: null,
                                 request_date: null,
                                 processing_start: null,
                                 processing_end: null,
                                 status: null,
                                 downloads: null,
                                 error: null)
```


