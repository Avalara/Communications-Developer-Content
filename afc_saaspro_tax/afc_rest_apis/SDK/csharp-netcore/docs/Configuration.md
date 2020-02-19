# avalara.comms.rest.v2.Model.Configuration
Settings associated with a client profile configuration  Maybe associated with 0 to many profiles
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TrafficStudyOverrides** | [**List&lt;TrafficStudyOverride&gt;**](TrafficStudyOverride.md) | List of Traffic Study Overrides | [optional] 
**ReturnNonBillable** | **bool?** | true : Return both non-billable and billable taxes in taxation response  false (default) : Return billable taxes only in taxation response  Default: false | [optional] 
**TaxOnTaxAlgorithm** | **int?** | Tax-on-tax algorithm to be used in tax calculations  0 : Single pass  1 (default) : IterateOnTaxAmount  2 : IterateOnTaxableMeasure | [optional] 
**SelfTaxAlgorithm** | **int?** | Self-tax algorithm to be used in tax calculations  0 (default) : Calculate tax on individual self-taxing taxes  1 : Calculate tax on aggregate of self-taxing taxes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

