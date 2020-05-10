# OpenAPI\Client\CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2ProfilesGetProfilesGet**](CustomizationApi.md#apiV2ProfilesGetProfilesGet) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items



## apiV2ProfilesGetProfilesGet

> \OpenAPI\Client\Model\TaxCalculationSettingsResponse apiV2ProfilesGetProfilesGet($requested_client_id, $requested_profile_id, $item_type)

Retrieves one or more profiles with associated settings and configurable items

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\CustomizationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$requested_client_id = 56; // int | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
$requested_profile_id = 56; // int | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
$item_type = new \OpenAPI\Client\Model\\OpenAPI\Client\Model\TaxCalculationSettingTypes(); // \OpenAPI\Client\Model\TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All

try {
    $result = $apiInstance->apiV2ProfilesGetProfilesGet($requested_client_id, $requested_profile_id, $item_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CustomizationApi->apiV2ProfilesGetProfilesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requested_client_id** | **int**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional]
 **requested_profile_id** | **int**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional]
 **item_type** | [**\OpenAPI\Client\Model\TaxCalculationSettingTypes**](../Model/.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional]

### Return type

[**\OpenAPI\Client\Model\TaxCalculationSettingsResponse**](../Model/TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

