

# SetTaxCalculationSettingRequest

Data for an invoice or quote line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profileConfigId** | **Long** | Profile configuration id to be used when updating an existing profile  Use null for new configuration |  [optional]
**linkProfileIds** | **List&lt;Integer&gt;** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings |  [optional]
**unlinkProfileIds** | **List&lt;Integer&gt;** | Profile(s) to be added to configuration  Leave null to not change profiles associated with configuration settings |  [optional]
**clientId** | **Integer** | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable |  [optional]
**deactivate** | **Boolean** | True &#x3D; Deactivate the configuration  Requires ProfileConfigId to be provided and valid.  Automatically removes any profile mappings associated with the configuration. |  [optional]
**description** | **String** | Description to be applied to requested configuration |  [optional]
**replaceExistingLinks** | **Boolean** | Flag indicating existing configuration links to profile should be replaced  This only applies when one or more profiles have been specified to be linked.   - If true, mapping conflicts will be resolved by removing other links.   - If false, mapping conflicts will cause the request to fail with an error returned. |  [optional]
**settings** | [**ModelConfiguration**](ModelConfiguration.md) | Configuration settings (required) |  [optional]
**exclusions** | [**List&lt;ExclusionConfig&gt;**](ExclusionConfig.md) | List of exclusions |  [optional]
**bundles** | [**List&lt;BundleConfig&gt;**](BundleConfig.md) | List of bundles |  [optional]
**nexus** | [**List&lt;NexusConfig&gt;**](NexusConfig.md) | List of nexus |  [optional]
**overrides** | **List&lt;String&gt;** | Overrides |  [optional]



