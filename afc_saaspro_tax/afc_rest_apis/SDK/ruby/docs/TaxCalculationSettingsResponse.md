# OpenapiClient::TaxCalculationSettingsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profile_config_id** | **Integer** | Unique profile configuration id associated with configuration item | [optional] 
**profile_ids** | **Array&lt;Integer&gt;** | Profile id&#39;s associated with configuration item | [optional] 
**client_id** | **Integer** | Client id associated with configuration item | [optional] 
**last_update_by** | **String** | User who last updated the configuration item | [optional] 
**active** | **Boolean** | Active status of the configuration item | [optional] 
**settings** | [**Configuration**](Configuration.md) | Configuration settings (as applicable) | [optional] 
**exclusions** | [**Array&lt;ExclusionConfig&gt;**](ExclusionConfig.md) | Exclusions (as applicable) | [optional] 
**bundles** | [**Array&lt;BundleConfig&gt;**](BundleConfig.md) | Bundles (as applicable) | [optional] 
**nexus** | [**Array&lt;NexusConfig&gt;**](NexusConfig.md) | Nexus (as applicable) | [optional] 
**overrides** | [**OverrideConfig**](OverrideConfig.md) | Overrides (as applicable - raw data) | [optional] 
**description** | **String** | Description associated with this item | [optional] 
**error** | **String** | Error information. | [optional] 
**item_type** | **String** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override | [optional] 
**errors** | [**Array&lt;Error&gt;**](Error.md) | Error information. | [optional] 
**warnings** | [**Array&lt;Warning&gt;**](Warning.md) | Warning information. | [optional] 
**status** | [**Array&lt;Status&gt;**](Status.md) | Status information. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::TaxCalculationSettingsResponse.new(profile_config_id: null,
                                 profile_ids: null,
                                 client_id: null,
                                 last_update_by: null,
                                 active: null,
                                 settings: null,
                                 exclusions: null,
                                 bundles: null,
                                 nexus: null,
                                 overrides: null,
                                 description: null,
                                 error: null,
                                 item_type: null,
                                 errors: null,
                                 warnings: null,
                                 status: null)
```


