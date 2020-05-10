# OpenapiClient::JurisdictionDeterminationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_p_code_post**](JurisdictionDeterminationApi.md#api_v2_afc_p_code_post) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**api_v2_geo_batch_log_process_id_get**](JurisdictionDeterminationApi.md#api_v2_geo_batch_log_process_id_get) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**api_v2_geo_batch_status_process_id_get**](JurisdictionDeterminationApi.md#api_v2_geo_batch_status_process_id_get) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**api_v2_geo_batch_upload_post**](JurisdictionDeterminationApi.md#api_v2_geo_batch_upload_post) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**api_v2_geo_geocode_post**](JurisdictionDeterminationApi.md#api_v2_geo_geocode_post) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.



## api_v2_afc_p_code_post

> PCodeLookupResult api_v2_afc_p_code_post(opts)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::JurisdictionDeterminationApi.new
opts = {
  p_code_lookup_request: OpenapiClient::PCodeLookupRequest.new # PCodeLookupRequest | 
}

begin
  #Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
  result = api_instance.api_v2_afc_p_code_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling JurisdictionDeterminationApi->api_v2_afc_p_code_post: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code_lookup_request** | [**PCodeLookupRequest**](PCodeLookupRequest.md)|  | [optional] 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
- **Accept**: text/plain, application/json, text/json


## api_v2_geo_batch_log_process_id_get

> GeoBatchLog api_v2_geo_batch_log_process_id_get(process_id)

Retrieves log on Geo Batch file

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::JurisdictionDeterminationApi.new
process_id = 'process_id_example' # String | Process Id for Geo Batch File.

begin
  #Retrieves log on Geo Batch file
  result = api_instance.api_v2_geo_batch_log_process_id_get(process_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_log_process_id_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **String**| Process Id for Geo Batch File. | 

### Return type

[**GeoBatchLog**](GeoBatchLog.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## api_v2_geo_batch_status_process_id_get

> GeoBatchStatus api_v2_geo_batch_status_process_id_get(process_id)

Retrieves information on Geo Batch file status

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::JurisdictionDeterminationApi.new
process_id = 'process_id_example' # String | Process Id for Geo Batch File.

begin
  #Retrieves information on Geo Batch file status
  result = api_instance.api_v2_geo_batch_status_process_id_get(process_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_status_process_id_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **String**| Process Id for Geo Batch File. | 

### Return type

[**GeoBatchStatus**](GeoBatchStatus.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## api_v2_geo_batch_upload_post

> GeoBatchSubmitFileResponse api_v2_geo_batch_upload_post(opts)

Uploads file to Geo Batch.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::JurisdictionDeterminationApi.new
opts = {
  geo_batch_file: File.new('/path/to/file') # File | 
}

begin
  #Uploads file to Geo Batch.
  result = api_instance.api_v2_geo_batch_upload_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_upload_post: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geo_batch_file** | **File**|  | [optional] 

### Return type

[**GeoBatchSubmitFileResponse**](GeoBatchSubmitFileResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: text/plain, application/json, text/json


## api_v2_geo_geocode_post

> Array&lt;GeocodeResult&gt; api_v2_geo_geocode_post(opts)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::JurisdictionDeterminationApi.new
opts = {
  geocode_request: [OpenapiClient::GeocodeRequest.new] # Array<GeocodeRequest> | List of street addresses and/or lat/long coordinate pairs to geocode.
}

begin
  #Geocodes one or multiple street addresses and/or lat/long coordinate pairs.
  result = api_instance.api_v2_geo_geocode_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling JurisdictionDeterminationApi->api_v2_geo_geocode_post: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geocode_request** | [**Array&lt;GeocodeRequest&gt;**](GeocodeRequest.md)| List of street addresses and/or lat/long coordinate pairs to geocode. | [optional] 

### Return type

[**Array&lt;GeocodeResult&gt;**](GeocodeResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
- **Accept**: text/plain, application/json, text/json

