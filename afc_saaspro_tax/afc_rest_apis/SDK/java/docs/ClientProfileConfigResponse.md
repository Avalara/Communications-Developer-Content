

# ClientProfileConfigResponse

Data for an invoice or quote line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**profileConfigId** | **Long** | Unique profile configuration id associated with configuration item |  [optional]
**profileIds** | **List&lt;Integer&gt;** | Profile id&#39;s associated with configuration item |  [optional]
**clientId** | **Integer** | Client id associated with configuration item |  [optional]
**lastUpdateBy** | **String** | User who last updated the configuration item |  [optional]
**active** | **Boolean** | Active status of the configuration item |  [optional]
**settings** | [**ModelConfiguration**](ModelConfiguration.md) |  |  [optional]
**exclusions** | [**List&lt;ExclusionConfig&gt;**](ExclusionConfig.md) | Exclusions (as applicable) |  [optional]
**bundles** | [**List&lt;BundleConfig&gt;**](BundleConfig.md) | Bundles (as applicable) |  [optional]
**nexus** | [**List&lt;NexusConfig&gt;**](NexusConfig.md) | Nexus (as applicable) |  [optional]
**overrides** | [**OverrideConfig**](OverrideConfig.md) |  |  [optional]
**description** | **String** | Description associated with this item |  [optional]
**error** | **String** | Error information. |  [optional]
**itemType** | **String** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override |  [optional]
**errors** | [**List&lt;Error&gt;**](Error.md) | Error information. |  [optional]
**warnings** | [**List&lt;Warning&gt;**](Warning.md) | Warning information. |  [optional]
**status** | [**List&lt;Status&gt;**](Status.md) | Status information. |  [optional]



