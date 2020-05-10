# OpenapiClient::CommitResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ok** | **Boolean** | Indicates if document code&#39;s commit status was updated successfully. | [optional] 
**err** | [**Array&lt;Error&gt;**](Error.md) | Error description (as applicable). | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::CommitResponse.new(ok: null,
                                 err: null)
```


