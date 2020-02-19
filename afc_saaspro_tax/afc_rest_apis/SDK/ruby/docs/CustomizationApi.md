# OpenapiClient::CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_profiles_get_profiles_get**](CustomizationApi.md#api_v2_profiles_get_profiles_get) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
[**api_v2_profiles_set_bundles_post**](CustomizationApi.md#api_v2_profiles_set_bundles_post) | **POST** /api/v2/profiles/SetBundles | Creates or updates bundle packages and associated profile mappings.
[**api_v2_profiles_set_config_post**](CustomizationApi.md#api_v2_profiles_set_config_post) | **POST** /api/v2/profiles/SetConfig | Creates or updates configuration settings and associated profile mappings.
[**api_v2_profiles_set_exclusions_post**](CustomizationApi.md#api_v2_profiles_set_exclusions_post) | **POST** /api/v2/profiles/SetExclusions | Creates or updates exclusions and associated profile mappings.
[**api_v2_profiles_set_overrides_post**](CustomizationApi.md#api_v2_profiles_set_overrides_post) | **POST** /api/v2/profiles/SetOverrides | Creates or updates overrides and associated profile mappings.



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


## api_v2_profiles_set_bundles_post

> TaxCalculationSettingsResponse api_v2_profiles_set_bundles_post(opts)

Creates or updates bundle packages and associated profile mappings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::CustomizationApi.new
opts = {
  set_tax_calculation_setting_request: OpenapiClient::SetTaxCalculationSettingRequest.new # SetTaxCalculationSettingRequest | 
}

begin
  #Creates or updates bundle packages and associated profile mappings.
  result = api_instance.api_v2_profiles_set_bundles_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CustomizationApi->api_v2_profiles_set_bundles_post: #{e}"
end
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


## api_v2_profiles_set_config_post

> TaxCalculationSettingsResponse api_v2_profiles_set_config_post(opts)

Creates or updates configuration settings and associated profile mappings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::CustomizationApi.new
opts = {
  set_tax_calculation_setting_request: OpenapiClient::SetTaxCalculationSettingRequest.new # SetTaxCalculationSettingRequest | 
}

begin
  #Creates or updates configuration settings and associated profile mappings.
  result = api_instance.api_v2_profiles_set_config_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CustomizationApi->api_v2_profiles_set_config_post: #{e}"
end
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


## api_v2_profiles_set_exclusions_post

> TaxCalculationSettingsResponse api_v2_profiles_set_exclusions_post(opts)

Creates or updates exclusions and associated profile mappings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::CustomizationApi.new
opts = {
  set_tax_calculation_setting_request: OpenapiClient::SetTaxCalculationSettingRequest.new # SetTaxCalculationSettingRequest | 
}

begin
  #Creates or updates exclusions and associated profile mappings.
  result = api_instance.api_v2_profiles_set_exclusions_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CustomizationApi->api_v2_profiles_set_exclusions_post: #{e}"
end
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


## api_v2_profiles_set_overrides_post

> TaxCalculationSettingsResponse api_v2_profiles_set_overrides_post(opts)

Creates or updates overrides and associated profile mappings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::CustomizationApi.new
opts = {
  set_tax_calculation_setting_request: OpenapiClient::SetTaxCalculationSettingRequest.new # SetTaxCalculationSettingRequest | 
}

begin
  #Creates or updates overrides and associated profile mappings.
  result = api_instance.api_v2_profiles_set_overrides_post(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CustomizationApi->api_v2_profiles_set_overrides_post: #{e}"
end
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

