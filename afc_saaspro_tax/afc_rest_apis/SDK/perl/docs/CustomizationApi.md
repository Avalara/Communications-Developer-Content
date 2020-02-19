# WWW::OpenAPIClient::CustomizationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CustomizationApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_profiles_get_profiles_get**](CustomizationApi.md#api_v2_profiles_get_profiles_get) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
[**api_v2_profiles_set_bundles_post**](CustomizationApi.md#api_v2_profiles_set_bundles_post) | **POST** /api/v2/profiles/SetBundles | Creates or updates bundle packages and associated profile mappings.
[**api_v2_profiles_set_config_post**](CustomizationApi.md#api_v2_profiles_set_config_post) | **POST** /api/v2/profiles/SetConfig | Creates or updates configuration settings and associated profile mappings.
[**api_v2_profiles_set_exclusions_post**](CustomizationApi.md#api_v2_profiles_set_exclusions_post) | **POST** /api/v2/profiles/SetExclusions | Creates or updates exclusions and associated profile mappings.
[**api_v2_profiles_set_overrides_post**](CustomizationApi.md#api_v2_profiles_set_overrides_post) | **POST** /api/v2/profiles/SetOverrides | Creates or updates overrides and associated profile mappings.


# **api_v2_profiles_get_profiles_get**
> TaxCalculationSettingsResponse api_v2_profiles_get_profiles_get(requested_client_id => $requested_client_id, requested_profile_id => $requested_profile_id, item_type => $item_type)

Retrieves one or more profiles with associated settings and configurable items

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CustomizationApi;
my $api_instance = WWW::OpenAPIClient::CustomizationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $requested_client_id = 56; # int | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
my $requested_profile_id = 56; # int | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
my $item_type = new WWW::OpenAPIClient.TaxCalculationSettingTypes(); # TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All

eval { 
    my $result = $api_instance->api_v2_profiles_get_profiles_get(requested_client_id => $requested_client_id, requested_profile_id => $requested_profile_id, item_type => $item_type);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling CustomizationApi->api_v2_profiles_get_profiles_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requested_client_id** | **int**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional] 
 **requested_profile_id** | **int**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional] 
 **item_type** | [**TaxCalculationSettingTypes**](.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_profiles_set_bundles_post**
> TaxCalculationSettingsResponse api_v2_profiles_set_bundles_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request)

Creates or updates bundle packages and associated profile mappings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CustomizationApi;
my $api_instance = WWW::OpenAPIClient::CustomizationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $set_tax_calculation_setting_request = WWW::OpenAPIClient::Object::SetTaxCalculationSettingRequest->new(); # SetTaxCalculationSettingRequest | 

eval { 
    my $result = $api_instance->api_v2_profiles_set_bundles_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling CustomizationApi->api_v2_profiles_set_bundles_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **set_tax_calculation_setting_request** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_profiles_set_config_post**
> TaxCalculationSettingsResponse api_v2_profiles_set_config_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request)

Creates or updates configuration settings and associated profile mappings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CustomizationApi;
my $api_instance = WWW::OpenAPIClient::CustomizationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $set_tax_calculation_setting_request = WWW::OpenAPIClient::Object::SetTaxCalculationSettingRequest->new(); # SetTaxCalculationSettingRequest | 

eval { 
    my $result = $api_instance->api_v2_profiles_set_config_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling CustomizationApi->api_v2_profiles_set_config_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **set_tax_calculation_setting_request** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_profiles_set_exclusions_post**
> TaxCalculationSettingsResponse api_v2_profiles_set_exclusions_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request)

Creates or updates exclusions and associated profile mappings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CustomizationApi;
my $api_instance = WWW::OpenAPIClient::CustomizationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $set_tax_calculation_setting_request = WWW::OpenAPIClient::Object::SetTaxCalculationSettingRequest->new(); # SetTaxCalculationSettingRequest | 

eval { 
    my $result = $api_instance->api_v2_profiles_set_exclusions_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling CustomizationApi->api_v2_profiles_set_exclusions_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **set_tax_calculation_setting_request** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_v2_profiles_set_overrides_post**
> TaxCalculationSettingsResponse api_v2_profiles_set_overrides_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request)

Creates or updates overrides and associated profile mappings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CustomizationApi;
my $api_instance = WWW::OpenAPIClient::CustomizationApi->new(

    # Configure HTTP basic authorization: Basic
    
);

my $set_tax_calculation_setting_request = WWW::OpenAPIClient::Object::SetTaxCalculationSettingRequest->new(); # SetTaxCalculationSettingRequest | 

eval { 
    my $result = $api_instance->api_v2_profiles_set_overrides_post(set_tax_calculation_setting_request => $set_tax_calculation_setting_request);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling CustomizationApi->api_v2_profiles_set_overrides_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **set_tax_calculation_setting_request** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

