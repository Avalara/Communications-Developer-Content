# OpenapiClient::CalcTaxesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cfg** | [**RequestConfig**](RequestConfig.md) |  | [optional] 
**cmpn** | [**CompanyData**](CompanyData.md) |  | [optional] 
**inv** | [**Array&lt;Invoice&gt;**](Invoice.md) |  | [optional] 
**ovr** | [**Array&lt;TaxOverride&gt;**](TaxOverride.md) |  | [optional] 
**sovr** | [**Array&lt;SafeHarborOverride&gt;**](SafeHarborOverride.md) |  | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::CalcTaxesRequest.new(cfg: null,
                                 cmpn: null,
                                 inv: null,
                                 ovr: null,
                                 sovr: null)
```


