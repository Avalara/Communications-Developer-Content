# OpenapiClient::ServiceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**server_time** | **DateTime** | Server time. | [optional] 
**versions** | [**VersionInfo**](VersionInfo.md) | Version information. | [optional] 
**error** | **String** | Error information. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::ServiceInfo.new(server_time: null,
                                 versions: null,
                                 error: null)
```


