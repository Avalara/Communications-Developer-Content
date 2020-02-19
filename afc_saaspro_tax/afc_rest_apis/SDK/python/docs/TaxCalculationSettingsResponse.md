# TaxCalculationSettingsResponse

Data for an invoice or quote line item.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profile_config_id** | **int** | Unique profile configuration id associated with configuration item | [optional] 
**profile_ids** | **list[int]** | Profile id&#39;s associated with configuration item | [optional] 
**client_id** | **int** | Client id associated with configuration item | [optional] 
**last_update_by** | **str** | User who last updated the configuration item | [optional] 
**active** | **bool** | Active status of the configuration item | [optional] 
**settings** | [**Configuration**](Configuration.md) | Configuration settings (as applicable) | [optional] 
**exclusions** | [**list[ExclusionConfig]**](ExclusionConfig.md) | Exclusions (as applicable) | [optional] 
**bundles** | [**list[BundleConfig]**](BundleConfig.md) | Bundles (as applicable) | [optional] 
**nexus** | [**list[NexusConfig]**](NexusConfig.md) | Nexus (as applicable) | [optional] 
**overrides** | [**OverrideConfig**](OverrideConfig.md) | Overrides (as applicable - raw data) | [optional] 
**description** | **str** | Description associated with this item | [optional] 
**error** | **str** | Error information. | [optional] 
**item_type** | **str** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override | [optional] 
**errors** | [**list[Error]**](Error.md) | Error information. | [optional] 
**warnings** | [**list[Warning]**](Warning.md) | Warning information. | [optional] 
**status** | [**list[Status]**](Status.md) | Status information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


