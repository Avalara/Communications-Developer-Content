

# CalcTaxesRequest

Request body for tax calculation API.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cfg** | [**RequestConfig**](RequestConfig.md) |  |  [optional]
**cmpn** | [**CompanyData**](CompanyData.md) |  |  [optional]
**inv** | [**List&lt;Invoice&gt;**](Invoice.md) | List of invoices to process. |  [optional]
**ovr** | [**List&lt;TaxOverride&gt;**](TaxOverride.md) | Tax rate overrides. |  [optional]
**sovr** | [**List&lt;SafeHarborOverride&gt;**](SafeHarborOverride.md) | Safe harbor overrides for USF taxes. |  [optional]



