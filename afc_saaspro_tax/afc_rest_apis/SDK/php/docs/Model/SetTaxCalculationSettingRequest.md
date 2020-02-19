# # SetTaxCalculationSettingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profile_config_id** | **int** | Profile configuration id to be used when updating an existing profile  Use null for new configuration | [optional] 
**link_profile_ids** | **int[]** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings | [optional] 
**unlink_profile_ids** | **int[]** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings | [optional] 
**client_id** | **int** | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable | [optional] 
**deactivate** | **bool** | True &#x3D; Deactivate the configuration  Requires ProfileConfigId to be provided and valid.  Automatically removes any profile mappings associated with the configuration. | [optional] 
**description** | **string** | Description to be applied to requested configuration | [optional] 
**replace_existing_links** | **bool** | Flag indicating existing configuration links to profile should be replaced  This only applies when one or more profiles have been specified to be linked.   - If true, mapping conflicts will be resolved by removing other links.   - If false, mapping conflicts will cause the request to fail with an error returned. | [optional] 
**settings** | [**Configuration**](Configuration.md) | Configuration settings (required) | [optional] 
**exclusions** | [**\OpenAPI\Client\Model\ExclusionConfig[]**](ExclusionConfig.md) | List of exclusions | [optional] 
**bundles** | [**\OpenAPI\Client\Model\BundleConfig[]**](BundleConfig.md) | List of bundles | [optional] 
**nexus** | [**\OpenAPI\Client\Model\NexusConfig[]**](NexusConfig.md) | List of nexus | [optional] 
**overrides** | **string[]** | Overrides | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


