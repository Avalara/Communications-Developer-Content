# OpenapiClient::RequestConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**retnb** | **Boolean** | Flag indicating non-billable taxes should be returned.  If set, will override account setting  Default if not provided is account setting value | [optional] 
**retext** | **Boolean** | Flag indicating extended tax information should be returned.  Reference online documentation for more details | [optional] 
**incrf** | **Boolean** | Flag indicating reporting information should be returned.  Reference online documentation for more details | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::RequestConfig.new(retnb: null,
                                 retext: null,
                                 incrf: null)
```


