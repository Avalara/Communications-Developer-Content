# # Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**traffic_study_overrides** | [**\OpenAPI\Client\Model\TrafficStudyOverride[]**](TrafficStudyOverride.md) | List of Traffic Study Overrides | [optional] 
**return_non_billable** | **bool** | true : Return both non-billable and billable taxes in taxation response  false (default) : Return billable taxes only in taxation response  Default: false | [optional] 
**tax_on_tax_algorithm** | **int** | Tax-on-tax algorithm to be used in tax calculations  0 : Single pass  1 (default) : IterateOnTaxAmount  2 : IterateOnTaxableMeasure | [optional] 
**self_tax_algorithm** | **int** | Self-tax algorithm to be used in tax calculations  0 (default) : Calculate tax on individual self-taxing taxes  1 : Calculate tax on aggregate of self-taxing taxes | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


