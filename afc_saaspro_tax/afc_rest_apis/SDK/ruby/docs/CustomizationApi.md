# OpenapiClient::CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_profiles_get_profiles_get**](CustomizationApi.md#api_v2_profiles_get_profiles_get) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items



## api_v2_profiles_get_profiles_get

> TaxCalculationSettingsResponse api_v2_profiles_get_profiles_get(opts)

Retrieves one or more profiles with associated settings and configurable items

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::CustomizationApi.new
opts = {
  requested_client_id: 56, # Integer | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
  requested_profile_id: 56, # Integer | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
  item_type: OpenapiClient::TaxCalculationSettingTypes.new # TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All
}

begin
  #Retrieves one or more profiles with associated settings and configurable items
  result = api_instance.api_v2_profiles_get_profiles_get(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CustomizationApi->api_v2_profiles_get_profiles_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requested_client_id** | **Integer**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional] 
 **requested_profile_id** | **Integer**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional] 
 **item_type** | [**TaxCalculationSettingTypes**](.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

