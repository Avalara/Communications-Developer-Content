# SaasPro.CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV2ProfilesGetProfilesGet**](CustomizationApi.md#apiV2ProfilesGetProfilesGet) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
[**apiV2ProfilesSetBundlesPost**](CustomizationApi.md#apiV2ProfilesSetBundlesPost) | **POST** /api/v2/profiles/SetBundles | Creates or updates bundle packages and associated profile mappings.
[**apiV2ProfilesSetConfigPost**](CustomizationApi.md#apiV2ProfilesSetConfigPost) | **POST** /api/v2/profiles/SetConfig | Creates or updates configuration settings and associated profile mappings.
[**apiV2ProfilesSetExclusionsPost**](CustomizationApi.md#apiV2ProfilesSetExclusionsPost) | **POST** /api/v2/profiles/SetExclusions | Creates or updates exclusions and associated profile mappings.
[**apiV2ProfilesSetOverridesPost**](CustomizationApi.md#apiV2ProfilesSetOverridesPost) | **POST** /api/v2/profiles/SetOverrides | Creates or updates overrides and associated profile mappings.



## apiV2ProfilesGetProfilesGet

> TaxCalculationSettingsResponse apiV2ProfilesGetProfilesGet(opts)

Retrieves one or more profiles with associated settings and configurable items

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.CustomizationApi();
let opts = {
  'requestedClientId': 56, // Number | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
  'requestedProfileId': 56, // Number | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
  'itemType': new SaasPro.TaxCalculationSettingTypes() // TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All
};
apiInstance.apiV2ProfilesGetProfilesGet(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestedClientId** | **Number**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional] 
 **requestedProfileId** | **Number**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional] 
 **itemType** | [**TaxCalculationSettingTypes**](.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## apiV2ProfilesSetBundlesPost

> TaxCalculationSettingsResponse apiV2ProfilesSetBundlesPost(opts)

Creates or updates bundle packages and associated profile mappings.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.CustomizationApi();
let opts = {
  'setTaxCalculationSettingRequest': new SaasPro.SetTaxCalculationSettingRequest() // SetTaxCalculationSettingRequest | 
};
apiInstance.apiV2ProfilesSetBundlesPost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## apiV2ProfilesSetConfigPost

> TaxCalculationSettingsResponse apiV2ProfilesSetConfigPost(opts)

Creates or updates configuration settings and associated profile mappings.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.CustomizationApi();
let opts = {
  'setTaxCalculationSettingRequest': new SaasPro.SetTaxCalculationSettingRequest() // SetTaxCalculationSettingRequest | 
};
apiInstance.apiV2ProfilesSetConfigPost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## apiV2ProfilesSetExclusionsPost

> TaxCalculationSettingsResponse apiV2ProfilesSetExclusionsPost(opts)

Creates or updates exclusions and associated profile mappings.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.CustomizationApi();
let opts = {
  'setTaxCalculationSettingRequest': new SaasPro.SetTaxCalculationSettingRequest() // SetTaxCalculationSettingRequest | 
};
apiInstance.apiV2ProfilesSetExclusionsPost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## apiV2ProfilesSetOverridesPost

> TaxCalculationSettingsResponse apiV2ProfilesSetOverridesPost(opts)

Creates or updates overrides and associated profile mappings.

### Example

```javascript
import SaasPro from 'saas_pro';
let defaultClient = SaasPro.ApiClient.instance;

let apiInstance = new SaasPro.CustomizationApi();
let opts = {
  'setTaxCalculationSettingRequest': new SaasPro.SetTaxCalculationSettingRequest() // SetTaxCalculationSettingRequest | 
};
apiInstance.apiV2ProfilesSetOverridesPost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setTaxCalculationSettingRequest** | [**SetTaxCalculationSettingRequest**](SetTaxCalculationSettingRequest.md)|  | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

