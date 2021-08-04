# SaasPro.ClientProfileConfigResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profileConfigId** | **Number** | Unique profile configuration id associated with configuration item | [optional] 
**profileIds** | **[Number]** | Profile id&#39;s associated with configuration item | [optional] 
**clientId** | **Number** | Client id associated with configuration item | [optional] 
**lastUpdateBy** | **String** | User who last updated the configuration item | [optional] 
**active** | **Boolean** | Active status of the configuration item | [optional] 
**settings** | [**Configuration**](Configuration.md) |  | [optional] 
**exclusions** | [**[ExclusionConfig]**](ExclusionConfig.md) | Exclusions (as applicable) | [optional] 
**bundles** | [**[BundleConfig]**](BundleConfig.md) | Bundles (as applicable) | [optional] 
**nexus** | [**[NexusConfig]**](NexusConfig.md) | Nexus (as applicable) | [optional] 
**overrides** | [**OverrideConfig**](OverrideConfig.md) |  | [optional] 
**description** | **String** | Description associated with this item | [optional] 
**error** | **String** | Error information. | [optional] 
**itemType** | **String** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override | [optional] 
**errors** | [**[Error]**](Error.md) | Error information. | [optional] 
**warnings** | [**[Warning]**](Warning.md) | Warning information. | [optional] 
**status** | [**[Status]**](Status.md) | Status information. | [optional] 


