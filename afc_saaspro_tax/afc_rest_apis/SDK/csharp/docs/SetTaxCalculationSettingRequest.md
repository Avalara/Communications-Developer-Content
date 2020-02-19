
# avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileConfigId** | **long?** | Profile configuration id to be used when updating an existing profile  Use null for new configuration | [optional] 
**LinkProfileIds** | **List&lt;int&gt;** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings | [optional] 
**UnlinkProfileIds** | **List&lt;int&gt;** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings | [optional] 
**ClientId** | **int?** | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable | [optional] 
**Deactivate** | **bool?** | True &#x3D; Deactivate the configuration  Requires ProfileConfigId to be provided and valid.  Automatically removes any profile mappings associated with the configuration. | [optional] 
**Description** | **string** | Description to be applied to requested configuration | [optional] 
**ReplaceExistingLinks** | **bool?** | Flag indicating existing configuration links to profile should be replaced  This only applies when one or more profiles have been specified to be linked.   - If true, mapping conflicts will be resolved by removing other links.   - If false, mapping conflicts will cause the request to fail with an error returned. | [optional] 
**Settings** | [**Configuration**](Configuration.md) | Configuration settings (required) | [optional] 
**Exclusions** | [**List&lt;ExclusionConfig&gt;**](ExclusionConfig.md) | List of exclusions | [optional] 
**Bundles** | [**List&lt;BundleConfig&gt;**](BundleConfig.md) | List of bundles | [optional] 
**Nexus** | [**List&lt;NexusConfig&gt;**](NexusConfig.md) | List of nexus | [optional] 
**Overrides** | **List&lt;string&gt;** | Overrides | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

