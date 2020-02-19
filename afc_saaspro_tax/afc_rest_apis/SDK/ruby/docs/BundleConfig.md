# OpenapiClient::BundleConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bundle_package** | **Integer** | Bundle Package - example:  20000 | [optional] 
**bundle_id** | **Integer** | Bundle Id - example:  20001 | [optional] 
**description** | **String** | Bundle Description | [optional] 
**bundle_items** | [**Array&lt;BundleItem&gt;**](BundleItem.md) | Bundled items - percentage should add up to 100% (as applicable) | [optional] 
**version** | **String** | Version for bundle - intended to allow changes to format   without having to perform expensive SQL updates on existing bundles | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::BundleConfig.new(bundle_package: null,
                                 bundle_id: null,
                                 description: null,
                                 bundle_items: null,
                                 version: null)
```


