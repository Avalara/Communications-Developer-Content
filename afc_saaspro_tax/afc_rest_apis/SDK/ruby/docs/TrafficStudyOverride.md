# OpenapiClient::TrafficStudyOverride

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**traffic_study_type** | **Integer** | Defines which transaction type the traffic study override applies to.  Ref enum SafeHarborType for list. | [optional] 
**safe_harbor_fed_pcnt** | **Float** | Safe harbor value to be overriden.  Ref class SafeHarborTams for default values. | [optional] 
**traffic_study_fed_pcnt** | **Float** | Client provided traffic study rate (Federal) to be used instead of safe harbor. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::TrafficStudyOverride.new(traffic_study_type: null,
                                 safe_harbor_fed_pcnt: null,
                                 traffic_study_fed_pcnt: null)
```


