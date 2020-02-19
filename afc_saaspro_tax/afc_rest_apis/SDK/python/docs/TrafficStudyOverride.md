# TrafficStudyOverride

Specifies a traffic study override
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**traffic_study_type** | **int** | Defines which transaction type the traffic study override applies to.  Ref enum SafeHarborType for list. | [optional] 
**safe_harbor_fed_pcnt** | **float** | Safe harbor value to be overriden.  Ref class SafeHarborTams for default values. | [optional] 
**traffic_study_fed_pcnt** | **float** | Client provided traffic study rate (Federal) to be used instead of safe harbor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


