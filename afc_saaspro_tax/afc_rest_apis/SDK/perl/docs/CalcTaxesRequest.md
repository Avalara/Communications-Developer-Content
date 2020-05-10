# WWW::OpenAPIClient::Object::CalcTaxesRequest

## Load the model package
```perl
use WWW::OpenAPIClient::Object::CalcTaxesRequest;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cfg** | [**RequestConfig**](RequestConfig.md) |  | [optional] 
**cmpn** | [**CompanyData**](CompanyData.md) |  | [optional] 
**inv** | [**ARRAY[Invoice]**](Invoice.md) | List of invoices to process. | [optional] 
**ovr** | [**ARRAY[TaxOverride]**](TaxOverride.md) | Tax rate overrides. | [optional] 
**sovr** | [**ARRAY[SafeHarborOverride]**](SafeHarborOverride.md) | Safe harbor overrides for USF taxes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


