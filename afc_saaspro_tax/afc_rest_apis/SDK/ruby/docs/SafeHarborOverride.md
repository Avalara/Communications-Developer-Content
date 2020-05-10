# OpenapiClient::SafeHarborOverride

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**sh** | **Integer** | Safe harbor type (1 &#x3D; Cellular, 2 &#x3D; VoIp, 4 &#x3D; Paging). | [optional] 
**old** | **Float** | Original Federal TAM value to override. | [optional] 
**new** | **Float** | New TAM value that will replace the original TAM value. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::SafeHarborOverride.new(sh: null,
                                 old: null,
                                 new: null)
```


