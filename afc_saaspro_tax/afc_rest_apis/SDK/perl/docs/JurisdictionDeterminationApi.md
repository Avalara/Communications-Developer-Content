# WWW::OpenAPIClient::JurisdictionDeterminationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::JurisdictionDeterminationApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_p_code_post**](JurisdictionDeterminationApi.md#api_v2_afc_p_code_post) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**api_v2_geo_batch_log_process_id_get**](JurisdictionDeterminationApi.md#api_v2_geo_batch_log_process_id_get) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**api_v2_geo_batch_status_process_id_get**](JurisdictionDeterminationApi.md#api_v2_geo_batch_status_process_id_get) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**api_v2_geo_batch_upload_post**](JurisdictionDeterminationApi.md#api_v2_geo_batch_upload_post) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**api_v2_geo_geocode_post**](JurisdictionDeterminationApi.md#api_v2_geo_geocode_post) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.


# **api_v2_afc_p_code_post**
> PCodeLookupResult api_v2_afc_p_code_post(p_code_lookup_request => $p_code_lookup_request)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::JurisdictionDeterminationApi;
my $api_instance = WWW::OpenAPIClient::JurisdictionDeterminationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $p_code_lookup_request = WWW::OpenAPIClient::Object::PCodeLookupRequest->new(); # PCodeLookupRequest | 

eval { 
    my $result = $api_instance->api_v2_afc_p_code_post(p_code_lookup_request => $p_code_lookup_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling JurisdictionDeterminationApi->api_v2_afc_p_code_post: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_batch_log_process_id_get**
> GeoBatchLog api_v2_geo_batch_log_process_id_get(process_id => $process_id)

Retrieves log on Geo Batch file

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::JurisdictionDeterminationApi;
my $api_instance = WWW::OpenAPIClient::JurisdictionDeterminationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $process_id = "process_id_example"; # string | Process Id for Geo Batch File.

eval { 
    my $result = $api_instance->api_v2_geo_batch_log_process_id_get(process_id => $process_id);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_log_process_id_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **string**| Process Id for Geo Batch File. | 

### Return type

[**GeoBatchLog**](GeoBatchLog.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_batch_status_process_id_get**
> GeoBatchStatus api_v2_geo_batch_status_process_id_get(process_id => $process_id)

Retrieves information on Geo Batch file status

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::JurisdictionDeterminationApi;
my $api_instance = WWW::OpenAPIClient::JurisdictionDeterminationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $process_id = "process_id_example"; # string | Process Id for Geo Batch File.

eval { 
    my $result = $api_instance->api_v2_geo_batch_status_process_id_get(process_id => $process_id);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_status_process_id_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **string**| Process Id for Geo Batch File. | 

### Return type

[**GeoBatchStatus**](GeoBatchStatus.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_batch_upload_post**
> GeoBatchSubmitFileResponse api_v2_geo_batch_upload_post(geo_batch_file => $geo_batch_file)

Uploads file to Geo Batch.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::JurisdictionDeterminationApi;
my $api_instance = WWW::OpenAPIClient::JurisdictionDeterminationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $geo_batch_file = "/path/to/file"; # string | 

eval { 
    my $result = $api_instance->api_v2_geo_batch_upload_post(geo_batch_file => $geo_batch_file);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling JurisdictionDeterminationApi->api_v2_geo_batch_upload_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geo_batch_file** | **string****string**|  | [optional] 

### Return type

[**GeoBatchSubmitFileResponse**](GeoBatchSubmitFileResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_geo_geocode_post**
> ARRAY[GeocodeResult] api_v2_geo_geocode_post(geocode_request => $geocode_request)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::JurisdictionDeterminationApi;
my $api_instance = WWW::OpenAPIClient::JurisdictionDeterminationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $geocode_request = [WWW::OpenAPIClient::Object::ARRAY[GeocodeRequest]->new()]; # ARRAY[GeocodeRequest] | List of street addresses and/or lat/long coordinate pairs to geocode.

eval { 
    my $result = $api_instance->api_v2_geo_geocode_post(geocode_request => $geocode_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling JurisdictionDeterminationApi->api_v2_geo_geocode_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geocode_request** | [**ARRAY[GeocodeRequest]**](GeocodeRequest.md)| List of street addresses and/or lat/long coordinate pairs to geocode. | [optional] 

### Return type

[**ARRAY[GeocodeResult]**](GeocodeResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

