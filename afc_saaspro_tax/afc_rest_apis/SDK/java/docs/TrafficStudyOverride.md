

# TrafficStudyOverride

Specifies a traffic study override
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**trafficStudyType** | **Integer** | Defines which transaction type the traffic study override applies to.  Ref enum SafeHarborType for list. |  [optional]
**safeHarborFedPcnt** | **Double** | Safe harbor value to be overriden.  Ref class SafeHarborTams for default values. |  [optional]
**trafficStudyFedPcnt** | **Double** | Client provided traffic study rate (Federal) to be used instead of safe harbor. |  [optional]



