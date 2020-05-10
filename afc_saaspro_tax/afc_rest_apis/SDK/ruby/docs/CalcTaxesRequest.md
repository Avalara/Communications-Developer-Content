# OpenapiClient::CalcTaxesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cfg** | [**RequestConfig**](RequestConfig.md) |  | [optional] 
**cmpn** | [**CompanyData**](CompanyData.md) |  | [optional] 
**inv** | [**Array&lt;Invoice&gt;**](Invoice.md) | List of invoices to process. | [optional] 
**ovr** | [**Array&lt;TaxOverride&gt;**](TaxOverride.md) | Tax rate overrides. | [optional] 
**sovr** | [**Array&lt;SafeHarborOverride&gt;**](SafeHarborOverride.md) | Safe harbor overrides for USF taxes. | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::CalcTaxesRequest.new(cfg: null,
                                 cmpn: null,
                                 inv: null,
                                 ovr: null,
                                 sovr: null)
```


