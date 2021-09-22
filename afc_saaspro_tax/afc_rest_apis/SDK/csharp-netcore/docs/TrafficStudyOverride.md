# avalara.comms.rest.v2.Model.TrafficStudyOverride
Specifies a traffic study override

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TrafficStudyType** | **int** | Defines which transaction type the traffic study override applies to.  Ref enum SafeHarborType for list. | [optional] 
**SafeHarborFedPcnt** | **double?** | Safe harbor value to be overriden.  Ref class SafeHarborTams for default values. | [optional] 
**TrafficStudyFedPcnt** | **double** | Client provided traffic study rate (Federal) to be used instead of safe harbor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

