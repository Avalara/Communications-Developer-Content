# OpenAPI\Client\LookupsApi

All URIs are relative to http://localhost.

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcLocationPCodeGet()**](LookupsApi.md#apiV2AfcLocationPCodeGet) | **GET** /api/v2/afc/location/{pCode} | Get location data associated with a PCode
[**apiV2AfcPrimaryPCodeGet()**](LookupsApi.md#apiV2AfcPrimaryPCodeGet) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**apiV2AfcServiceinfoGet()**](LookupsApi.md#apiV2AfcServiceinfoGet) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**apiV2AfcTaxtypeTaxTypeGet()**](LookupsApi.md#apiV2AfcTaxtypeTaxTypeGet) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**apiV2AfcTspairsGet()**](LookupsApi.md#apiV2AfcTspairsGet) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information


## `apiV2AfcLocationPCodeGet()`

```php
apiV2AfcLocationPCodeGet($p_code): \OpenAPI\Client\Model\PCodeLookupResult
```

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure HTTP basic authorization: Basic
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new OpenAPI\Client\Api\LookupsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$p_code = 56; // int

try {
    $result = $apiInstance->apiV2AfcLocationPCodeGet($p_code);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LookupsApi->apiV2AfcLocationPCodeGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code** | **int**|  |

### Return type

[**\OpenAPI\Client\Model\PCodeLookupResult**](../Model/PCodeLookupResult.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `text/plain`, `application/json`, `text/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `apiV2AfcPrimaryPCodeGet()`

```php
apiV2AfcPrimaryPCodeGet($p_code): \OpenAPI\Client\Model\PCodeLookupResult
```

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure HTTP basic authorization: Basic
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new OpenAPI\Client\Api\LookupsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$p_code = 56; // int

try {
    $result = $apiInstance->apiV2AfcPrimaryPCodeGet($p_code);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LookupsApi->apiV2AfcPrimaryPCodeGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code** | **int**|  |

### Return type

[**\OpenAPI\Client\Model\PCodeLookupResult**](../Model/PCodeLookupResult.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `text/plain`, `application/json`, `text/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `apiV2AfcServiceinfoGet()`

```php
apiV2AfcServiceinfoGet(): \OpenAPI\Client\Model\ServiceInfo
```

Retrieves server time, service build version and engine version

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure HTTP basic authorization: Basic
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new OpenAPI\Client\Api\LookupsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiV2AfcServiceinfoGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LookupsApi->apiV2AfcServiceinfoGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OpenAPI\Client\Model\ServiceInfo**](../Model/ServiceInfo.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `text/plain`, `application/json`, `text/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `apiV2AfcTaxtypeTaxTypeGet()`

```php
apiV2AfcTaxtypeTaxTypeGet($tax_type): \OpenAPI\Client\Model\TaxTypeData[]
```

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure HTTP basic authorization: Basic
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new OpenAPI\Client\Api\LookupsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tax_type = 'tax_type_example'; // string | Tax type ID for the tax type.

try {
    $result = $apiInstance->apiV2AfcTaxtypeTaxTypeGet($tax_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LookupsApi->apiV2AfcTaxtypeTaxTypeGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tax_type** | **string**| Tax type ID for the tax type. |

### Return type

[**\OpenAPI\Client\Model\TaxTypeData[]**](../Model/TaxTypeData.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `text/plain`, `application/json`, `text/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `apiV2AfcTspairsGet()`

```php
apiV2AfcTspairsGet(): \OpenAPI\Client\Model\TsPairData[]
```

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure HTTP basic authorization: Basic
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new OpenAPI\Client\Api\LookupsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiV2AfcTspairsGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LookupsApi->apiV2AfcTspairsGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OpenAPI\Client\Model\TsPairData[]**](../Model/TsPairData.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `text/plain`, `application/json`, `text/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
