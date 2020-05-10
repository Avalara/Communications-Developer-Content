# WWW::OpenAPIClient::CustomizationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CustomizationApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_profiles_get_profiles_get**](CustomizationApi.md#api_v2_profiles_get_profiles_get) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items


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

