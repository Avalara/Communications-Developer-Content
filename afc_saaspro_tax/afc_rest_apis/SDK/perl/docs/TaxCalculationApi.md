# WWW::OpenAPIClient::TaxCalculationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::TaxCalculationApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_calc_taxes_post**](TaxCalculationApi.md#api_v2_afc_calc_taxes_post) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
[**api_v2_afc_commit_post**](TaxCalculationApi.md#api_v2_afc_commit_post) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.


# **api_v2_afc_calc_taxes_post**
> CalcTaxesResponse api_v2_afc_calc_taxes_post(calc_taxes_request => $calc_taxes_request)

Performs tax calculations on all invoices and line items within the request body.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TaxCalculationApi;
my $api_instance = WWW::OpenAPIClient::TaxCalculationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $calc_taxes_request = WWW::OpenAPIClient::Object::CalcTaxesRequest->new(); # CalcTaxesRequest | CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations.

eval { 
    my $result = $api_instance->api_v2_afc_calc_taxes_post(calc_taxes_request => $calc_taxes_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling TaxCalculationApi->api_v2_afc_calc_taxes_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calc_taxes_request** | [**CalcTaxesRequest**](CalcTaxesRequest.md)| CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. | [optional] 

### Return type

[**CalcTaxesResponse**](CalcTaxesResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_commit_post**
> CommitResponse api_v2_afc_commit_post(commit_request => $commit_request)

Commits or un-commits a document code.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TaxCalculationApi;
my $api_instance = WWW::OpenAPIClient::TaxCalculationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $commit_request = WWW::OpenAPIClient::Object::CommitRequest->new(); # CommitRequest | CommitRequest object containing document code and optional field data to override in reports.

eval { 
    my $result = $api_instance->api_v2_afc_commit_post(commit_request => $commit_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling TaxCalculationApi->api_v2_afc_commit_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commit_request** | [**CommitRequest**](CommitRequest.md)| CommitRequest object containing document code and optional field data to override in reports. | [optional] 

### Return type

[**CommitResponse**](CommitResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

