

# BundleConfig

Bundles associated with a client profile configuration  Maybe associated with 0 to many profiles

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bundlePackage** | **Integer** | Bundle Package - example:  20000 |  [optional]
**bundleId** | **Integer** | Bundle Id - example:  20001 |  [optional]
**description** | **String** | Bundle Description |  [optional]
**bundleItems** | [**List&lt;BundleItem&gt;**](BundleItem.md) | Bundled items - percentage should add up to 100% (as applicable) |  [optional]
**version** | **String** | Version for bundle - intended to allow changes to format   without having to perform expensive SQL updates on existing bundles |  [optional]



