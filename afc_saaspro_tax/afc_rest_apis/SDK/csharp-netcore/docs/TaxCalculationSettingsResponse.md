# avalara.comms.rest.v2.Model.TaxCalculationSettingsResponse
Data for an invoice or quote line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileConfigId** | **long?** | Unique profile configuration id associated with configuration item | [optional] 
**ProfileIds** | **List&lt;int&gt;** | Profile id&#39;s associated with configuration item | [optional] 
**ClientId** | **int?** | Client id associated with configuration item | [optional] 
**LastUpdateBy** | **string** | User who last updated the configuration item | [optional] 
**Active** | **bool?** | Active status of the configuration item | [optional] 
**Settings** | [**Configuration**](Configuration.md) | Configuration settings (as applicable) | [optional] 
**Exclusions** | [**List&lt;ExclusionConfig&gt;**](ExclusionConfig.md) | Exclusions (as applicable) | [optional] 
**Bundles** | [**List&lt;BundleConfig&gt;**](BundleConfig.md) | Bundles (as applicable) | [optional] 
**Nexus** | [**List&lt;NexusConfig&gt;**](NexusConfig.md) | Nexus (as applicable) | [optional] 
**Overrides** | [**OverrideConfig**](OverrideConfig.md) | Overrides (as applicable - raw data) | [optional] 
**Description** | **string** | Description associated with this item | [optional] 
**Error** | **string** | Error information. | [optional] 
**ItemType** | **string** | Item Type  Examples:    Configuration, Bundle, Exclusion, Override | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Error information. | [optional] 
**Warnings** | [**List&lt;Warning&gt;**](Warning.md) | Warning information. | [optional] 
**Status** | [**List&lt;Status&gt;**](Status.md) | Status information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

