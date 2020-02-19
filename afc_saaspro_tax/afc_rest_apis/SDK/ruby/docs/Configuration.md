# OpenapiClient::Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**traffic_study_overrides** | [**Array&lt;TrafficStudyOverride&gt;**](TrafficStudyOverride.md) | List of Traffic Study Overrides | [optional] 
**return_non_billable** | **Boolean** | true : Return both non-billable and billable taxes in taxation response  false (default) : Return billable taxes only in taxation response  Default: false | [optional] 
**tax_on_tax_algorithm** | **Integer** | Tax-on-tax algorithm to be used in tax calculations  0 : Single pass  1 (default) : IterateOnTaxAmount  2 : IterateOnTaxableMeasure | [optional] 
**self_tax_algorithm** | **Integer** | Self-tax algorithm to be used in tax calculations  0 (default) : Calculate tax on individual self-taxing taxes  1 : Calculate tax on aggregate of self-taxing taxes | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::Configuration.new(traffic_study_overrides: null,
                                 return_non_billable: null,
                                 tax_on_tax_algorithm: null,
                                 self_tax_algorithm: null)
```


