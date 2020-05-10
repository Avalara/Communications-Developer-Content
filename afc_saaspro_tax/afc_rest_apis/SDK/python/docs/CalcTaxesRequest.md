# CalcTaxesRequest

Request body for tax calculation API.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cfg** | [**RequestConfig**](RequestConfig.md) |  | [optional] 
**cmpn** | [**CompanyData**](CompanyData.md) |  | [optional] 
**inv** | [**list[Invoice]**](Invoice.md) | List of invoices to process. | [optional] 
**ovr** | [**list[TaxOverride]**](TaxOverride.md) | Tax rate overrides. | [optional] 
**sovr** | [**list[SafeHarborOverride]**](SafeHarborOverride.md) | Safe harbor overrides for USF taxes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


