# OpenapiClient::CommitRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **String** | Document code. | [optional] 
**cmmt** | **Boolean** | Indicates if transactions for the specified document code should be committed. | [optional] 
**opt** | [**Array&lt;KeyValuePair&gt;**](KeyValuePair.md) | Overrides value for OptionalFields field in reports. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::CommitRequest.new(doc: null,
                                 cmmt: null,
                                 opt: null)
```


