
# avalara.comms.rest.v2.Model.BundleConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BundlePackage** | **int** | Bundle Package - example:  20000 | [optional] 
**BundleId** | **int** | Bundle Id - example:  20001 | [optional] 
**Description** | **string** | Bundle Description | [optional] 
**BundleItems** | [**List&lt;BundleItem&gt;**](BundleItem.md) | Bundled items - percentage should add up to 100% (as applicable) | [optional] 
**Version** | **string** | Version for bundle - intended to allow changes to format   without having to perform expensive SQL updates on existing bundles | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

