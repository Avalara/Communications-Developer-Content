

# GeoBatchStatus

Individual File Status For Geo Batch result

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**processId** | **Integer** | Process ID for Batch file. |  [optional]
**requestDate** | **OffsetDateTime** | Request Date. |  [optional]
**processingStart** | **OffsetDateTime** | Processing Start. |  [optional]
**processingEnd** | **OffsetDateTime** | Processing End. |  [optional]
**status** | **String** | Status Of Batch File. |  [optional]
**downloads** | [**GeoBatchDownloadResponse**](GeoBatchDownloadResponse.md) |  |  [optional]
**error** | [**List&lt;Error&gt;**](Error.md) | Error information. |  [optional]



