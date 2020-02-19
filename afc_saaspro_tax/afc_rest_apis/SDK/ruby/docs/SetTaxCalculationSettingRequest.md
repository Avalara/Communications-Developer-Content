# OpenapiClient::SetTaxCalculationSettingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profile_config_id** | **Integer** | Profile configuration id to be used when updating an existing profile  Use null for new configuration | [optional] 
**link_profile_ids** | **Array&lt;Integer&gt;** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings | [optional] 
**unlink_profile_ids** | **Array&lt;Integer&gt;** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings | [optional] 
**client_id** | **Integer** | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable | [optional] 
**deactivate** | **Boolean** | True &#x3D; Deactivate the configuration  Requires ProfileConfigId to be provided and valid.  Automatically removes any profile mappings associated with the configuration. | [optional] 
**description** | **String** | Description to be applied to requested configuration | [optional] 
**replace_existing_links** | **Boolean** | Flag indicating existing configuration links to profile should be replaced  This only applies when one or more profiles have been specified to be linked.   - If true, mapping conflicts will be resolved by removing other links.   - If false, mapping conflicts will cause the request to fail with an error returned. | [optional] 
**settings** | [**Configuration**](Configuration.md) | Configuration settings (required) | [optional] 
**exclusions** | [**Array&lt;ExclusionConfig&gt;**](ExclusionConfig.md) | List of exclusions | [optional] 
**bundles** | [**Array&lt;BundleConfig&gt;**](BundleConfig.md) | List of bundles | [optional] 
**nexus** | [**Array&lt;NexusConfig&gt;**](NexusConfig.md) | List of nexus | [optional] 
**overrides** | **Array&lt;String&gt;** | Overrides | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::SetTaxCalculationSettingRequest.new(profile_config_id: null,
                                 link_profile_ids: null,
                                 unlink_profile_ids: null,
                                 client_id: null,
                                 deactivate: null,
                                 description: null,
                                 replace_existing_links: null,
                                 settings: null,
                                 exclusions: null,
                                 bundles: null,
                                 nexus: null,
                                 overrides: null)
```


