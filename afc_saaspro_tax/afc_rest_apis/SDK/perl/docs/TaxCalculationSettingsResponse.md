# WWW::OpenAPIClient::Object::TaxCalculationSettingsResponse

## Load the model package
```perl
use WWW::OpenAPIClient::Object::TaxCalculationSettingsResponse;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profile_config_id** | **int** | Unique profile configuration id associated with configuration item | [optional] 
**profile_ids** | **ARRAY[int]** | Profile id&#39;s associated with configuration item | [optional] 
**client_id** | **int** | Client id associated with configuration item | [optional] 
**last_update_by** | **string** | User who last updated the configuration item | [optional] 
**active** | **boolean** | Active status of the configuration item | [optional] 
**settings** | [**Configuration**](Configuration.md) | Configuration settings (as applicable) | [optional] 
**exclusions** | [**ARRAY[ExclusionConfig]**](ExclusionConfig.md) | Exclusions (as applicable) | [optional] 
**bundles** | [**ARRAY[BundleConfig]**](BundleConfig.md) | Bundles (as applicable) | [optional] 
**nexus** | [**ARRAY[NexusConfig]**](NexusConfig.md) | Nexus (as applicable) | [optional] 
**overrides** | [**OverrideConfig**](OverrideConfig.md) | Overrides (as applicable - raw data) | [optional] 
**description** | **string** | Description associated with this item | [optional] 
**error** | **string** | Error information. | [optional] 
**item_type** | **string** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override | [optional] 
**errors** | [**ARRAY[Error]**](Error.md) | Error information. | [optional] 
**warnings** | [**ARRAY[Warning]**](Warning.md) | Warning information. | [optional] 
**status** | [**ARRAY[Status]**](Status.md) | Status information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


