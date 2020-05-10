# # TaxCalculationSettingsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profile_config_id** | **int** | Unique profile configuration id associated with configuration item | [optional] 
**profile_ids** | **int[]** | Profile id&#39;s associated with configuration item | [optional] 
**client_id** | **int** | Client id associated with configuration item | [optional] 
**last_update_by** | **string** | User who last updated the configuration item | [optional] 
**active** | **bool** | Active status of the configuration item | [optional] 
**settings** | [**\OpenAPI\Client\Model\Configuration**](Configuration.md) |  | [optional] 
**exclusions** | [**\OpenAPI\Client\Model\ExclusionConfig[]**](ExclusionConfig.md) | Exclusions (as applicable) | [optional] 
**bundles** | [**\OpenAPI\Client\Model\BundleConfig[]**](BundleConfig.md) | Bundles (as applicable) | [optional] 
**nexus** | [**\OpenAPI\Client\Model\NexusConfig[]**](NexusConfig.md) | Nexus (as applicable) | [optional] 
**overrides** | [**\OpenAPI\Client\Model\OverrideConfig**](OverrideConfig.md) |  | [optional] 
**description** | **string** | Description associated with this item | [optional] 
**error** | **string** | Error information. | [optional] 
**item_type** | **string** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override | [optional] 
**errors** | [**\OpenAPI\Client\Model\Error[]**](Error.md) | Error information. | [optional] 
**warnings** | [**\OpenAPI\Client\Model\Warning[]**](Warning.md) | Warning information. | [optional] 
**status** | [**\OpenAPI\Client\Model\Status[]**](Status.md) | Status information. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


