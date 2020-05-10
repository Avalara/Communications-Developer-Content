# OpenAPI\Client\JurisdictionDeterminationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcPCodePost**](JurisdictionDeterminationApi.md#apiV2AfcPCodePost) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
[**apiV2GeoBatchLogProcessIdGet**](JurisdictionDeterminationApi.md#apiV2GeoBatchLogProcessIdGet) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
[**apiV2GeoBatchStatusProcessIdGet**](JurisdictionDeterminationApi.md#apiV2GeoBatchStatusProcessIdGet) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
[**apiV2GeoBatchUploadPost**](JurisdictionDeterminationApi.md#apiV2GeoBatchUploadPost) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
[**apiV2GeoGeocodePost**](JurisdictionDeterminationApi.md#apiV2GeoGeocodePost) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.



## apiV2AfcPCodePost

> \OpenAPI\Client\Model\PCodeLookupResult apiV2AfcPCodePost($p_code_lookup_request)

Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.

Requests supports using best match or exact match as well as limiting the number of matches returned. Use a * on the end of Fips/Npanxx Codes to find a range of values.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\JurisdictionDeterminationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$p_code_lookup_request = new \OpenAPI\Client\Model\PCodeLookupRequest(); // \OpenAPI\Client\Model\PCodeLookupRequest | 

try {
    $result = $apiInstance->apiV2AfcPCodePost($p_code_lookup_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling JurisdictionDeterminationApi->apiV2AfcPCodePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code_lookup_request** | [**\OpenAPI\Client\Model\PCodeLookupRequest**](../Model/PCodeLookupRequest.md)|  | [optional]

### Return type

[**\OpenAPI\Client\Model\PCodeLookupResult**](../Model/PCodeLookupResult.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## apiV2GeoBatchLogProcessIdGet

> \OpenAPI\Client\Model\GeoBatchLog apiV2GeoBatchLogProcessIdGet($process_id)

Retrieves log on Geo Batch file

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\JurisdictionDeterminationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$process_id = 'process_id_example'; // string | Process Id for Geo Batch File.

try {
    $result = $apiInstance->apiV2GeoBatchLogProcessIdGet($process_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling JurisdictionDeterminationApi->apiV2GeoBatchLogProcessIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **string**| Process Id for Geo Batch File. |

### Return type

[**\OpenAPI\Client\Model\GeoBatchLog**](../Model/GeoBatchLog.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## apiV2GeoBatchStatusProcessIdGet

> \OpenAPI\Client\Model\GeoBatchStatus apiV2GeoBatchStatusProcessIdGet($process_id)

Retrieves information on Geo Batch file status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\JurisdictionDeterminationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$process_id = 'process_id_example'; // string | Process Id for Geo Batch File.

try {
    $result = $apiInstance->apiV2GeoBatchStatusProcessIdGet($process_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling JurisdictionDeterminationApi->apiV2GeoBatchStatusProcessIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **process_id** | **string**| Process Id for Geo Batch File. |

### Return type

[**\OpenAPI\Client\Model\GeoBatchStatus**](../Model/GeoBatchStatus.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## apiV2GeoBatchUploadPost

> \OpenAPI\Client\Model\GeoBatchSubmitFileResponse apiV2GeoBatchUploadPost($geo_batch_file)

Uploads file to Geo Batch.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\JurisdictionDeterminationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$geo_batch_file = "/path/to/file.txt"; // \SplFileObject | 

try {
    $result = $apiInstance->apiV2GeoBatchUploadPost($geo_batch_file);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling JurisdictionDeterminationApi->apiV2GeoBatchUploadPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geo_batch_file** | **\SplFileObject****\SplFileObject**|  | [optional]

### Return type

[**\OpenAPI\Client\Model\GeoBatchSubmitFileResponse**](../Model/GeoBatchSubmitFileResponse.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## apiV2GeoGeocodePost

> \OpenAPI\Client\Model\GeocodeResult[] apiV2GeoGeocodePost($geocode_request)

Geocodes one or multiple street addresses and/or lat/long coordinate pairs.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\JurisdictionDeterminationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$geocode_request = array(new \OpenAPI\Client\Model\GeocodeRequest()); // \OpenAPI\Client\Model\GeocodeRequest[] | List of street addresses and/or lat/long coordinate pairs to geocode.

try {
    $result = $apiInstance->apiV2GeoGeocodePost($geocode_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling JurisdictionDeterminationApi->apiV2GeoGeocodePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geocode_request** | [**\OpenAPI\Client\Model\GeocodeRequest[]**](../Model/GeocodeRequest.md)| List of street addresses and/or lat/long coordinate pairs to geocode. | [optional]

### Return type

[**\OpenAPI\Client\Model\GeocodeResult[]**](../Model/GeocodeResult.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

