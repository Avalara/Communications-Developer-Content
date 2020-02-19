# WWW::OpenAPIClient::LookupsApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::LookupsApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_location_pcode_get**](LookupsApi.md#api_v2_afc_location_pcode_get) | **GET** /api/v2/afc/location/{pcode} | Get location data associated with a PCode
[**api_v2_afc_primary_p_code_get**](LookupsApi.md#api_v2_afc_primary_p_code_get) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**api_v2_afc_serviceinfo_get**](LookupsApi.md#api_v2_afc_serviceinfo_get) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**api_v2_afc_taxtype_tax_type_get**](LookupsApi.md#api_v2_afc_taxtype_tax_type_get) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**api_v2_afc_tspairs_get**](LookupsApi.md#api_v2_afc_tspairs_get) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information


# **api_v2_afc_location_pcode_get**
> PCodeLookupResult api_v2_afc_location_pcode_get(pcode => $pcode)

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LookupsApi;
my $api_instance = WWW::OpenAPIClient::LookupsApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $pcode = 56; # int | 

eval { 
    my $result = $api_instance->api_v2_afc_location_pcode_get(pcode => $pcode);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling LookupsApi->api_v2_afc_location_pcode_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pcode** | **int**|  | 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_primary_p_code_get**
> PCodeLookupResult api_v2_afc_primary_p_code_get(p_code => $p_code)

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LookupsApi;
my $api_instance = WWW::OpenAPIClient::LookupsApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $p_code = 56; # int | 

eval { 
    my $result = $api_instance->api_v2_afc_primary_p_code_get(p_code => $p_code);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling LookupsApi->api_v2_afc_primary_p_code_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code** | **int**|  | 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_serviceinfo_get**
> ServiceInfo api_v2_afc_serviceinfo_get()

Retrieves server time, service build version and engine version

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LookupsApi;
my $api_instance = WWW::OpenAPIClient::LookupsApi->new(

    # Configure HTTP basic authorization: Basic
    
);


eval { 
    my $result = $api_instance->api_v2_afc_serviceinfo_get();
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling LookupsApi->api_v2_afc_serviceinfo_get: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServiceInfo**](ServiceInfo.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_taxtype_tax_type_get**
> ARRAY[TaxTypeData] api_v2_afc_taxtype_tax_type_get(tax_type => $tax_type)

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LookupsApi;
my $api_instance = WWW::OpenAPIClient::LookupsApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $tax_type = "tax_type_example"; # string | Tax type ID for the tax type.

eval { 
    my $result = $api_instance->api_v2_afc_taxtype_tax_type_get(tax_type => $tax_type);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling LookupsApi->api_v2_afc_taxtype_tax_type_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tax_type** | **string**| Tax type ID for the tax type. | 

### Return type

[**ARRAY[TaxTypeData]**](TaxTypeData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_afc_tspairs_get**
> ARRAY[TSPairData] api_v2_afc_tspairs_get()

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LookupsApi;
my $api_instance = WWW::OpenAPIClient::LookupsApi->new(

    # Configure HTTP basic authorization: Basic
    
);


eval { 
    my $result = $api_instance->api_v2_afc_tspairs_get();
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling LookupsApi->api_v2_afc_tspairs_get: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ARRAY[TSPairData]**](TSPairData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

