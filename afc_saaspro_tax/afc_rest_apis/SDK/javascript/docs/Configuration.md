# SaasPro.Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**trafficStudyOverrides** | [**[TrafficStudyOverride]**](TrafficStudyOverride.md) | List of Traffic Study Overrides | [optional] 
**returnNonBillable** | **Boolean** | true : Return both non-billable and billable taxes in taxation response  false (default) : Return billable taxes only in taxation response  Default: false | [optional] 
**taxOnTaxAlgorithm** | **Number** | Tax-on-tax algorithm to be used in tax calculations  0 : Single pass  1 (default) : IterateOnTaxAmount  2 : IterateOnTaxableMeasure | [optional] 
**selfTaxAlgorithm** | **Number** | Self-tax algorithm to be used in tax calculations  0 (default) : Calculate tax on individual self-taxing taxes  1 : Calculate tax on aggregate of self-taxing taxes | [optional] 


