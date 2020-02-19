# BundleConfig

Bundles associated with a client profile configuration  Maybe associated with 0 to many profiles
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bundle_package** | **int** | Bundle Package - example:  20000 | [optional] 
**bundle_id** | **int** | Bundle Id - example:  20001 | [optional] 
**description** | **str** | Bundle Description | [optional] 
**bundle_items** | [**list[BundleItem]**](BundleItem.md) | Bundled items - percentage should add up to 100% (as applicable) | [optional] 
**version** | **str** | Version for bundle - intended to allow changes to format   without having to perform expensive SQL updates on existing bundles | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


