# OpenAPI\Client\TaxCalculationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2AfcCalcTaxesPost**](TaxCalculationApi.md#apiV2AfcCalcTaxesPost) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**apiV2AfcCommitPost**](TaxCalculationApi.md#apiV2AfcCommitPost) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.



## apiV2AfcCalcTaxesPost

> \OpenAPI\Client\Model\CalcTaxesResponse apiV2AfcCalcTaxesPost($calc_taxes_request)

Performs tax calculations on all invoices and line items within the request body.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\TaxCalculationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$calc_taxes_request = new \OpenAPI\Client\Model\CalcTaxesRequest(); // \OpenAPI\Client\Model\CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations.

try {
    $result = $apiInstance->apiV2AfcCalcTaxesPost($calc_taxes_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TaxCalculationApi->apiV2AfcCalcTaxesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calc_taxes_request** | [**\OpenAPI\Client\Model\CalcTaxesRequest**](../Model/CalcTaxesRequest.md)| CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. | [optional]

### Return type

[**\OpenAPI\Client\Model\CalcTaxesResponse**](../Model/CalcTaxesResponse.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## apiV2AfcCommitPost

> \OpenAPI\Client\Model\CommitResponse apiV2AfcCommitPost($commit_request)

Commits or un-commits a document code.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new OpenAPI\Client\Api\TaxCalculationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$commit_request = new \OpenAPI\Client\Model\CommitRequest(); // \OpenAPI\Client\Model\CommitRequest | CommitRequest object containing document code and optional field data to override in reports.

try {
    $result = $apiInstance->apiV2AfcCommitPost($commit_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TaxCalculationApi->apiV2AfcCommitPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commit_request** | [**\OpenAPI\Client\Model\CommitRequest**](../Model/CommitRequest.md)| CommitRequest object containing document code and optional field data to override in reports. | [optional]

### Return type

[**\OpenAPI\Client\Model\CommitResponse**](../Model/CommitResponse.md)

### Authorization

[Basic](../../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

