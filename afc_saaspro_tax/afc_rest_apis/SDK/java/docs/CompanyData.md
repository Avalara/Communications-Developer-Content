

# CompanyData

Container class for json properties associated with v2.CalcTaxes company data

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bscl** | **Integer** | Business class. 0 &#x3D; ILEC, 1 &#x3D; CLEC. |  [optional]
**svcl** | **Integer** | Service class. 0 &#x3D; Primary Local, 1 &#x3D; Primary Long Distance. |  [optional]
**fclt** | **Boolean** | Specifies if the carrier delivering the service has company owned facilities to provide the service. |  [optional]
**frch** | **Boolean** | Indicates if the company provides services sold pursuant to a franchise agreement between the carrier and jurisdiction. |  [optional]
**reg** | **Boolean** | Indicates if company is regulated. |  [optional]
**excl** | [**List&lt;Exclusion&gt;**](Exclusion.md) | Exclusion list. |  [optional]
**idnt** | **String** | An optional company identifier for reporting |  [optional]



