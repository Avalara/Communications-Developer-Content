# avalara.comms.rest.v2.Model.CompanyData
Container class for json properties associated with v2.CalcTaxes company data
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bscl** | **int?** | Business class. 0 &#x3D; ILEC, 1 &#x3D; CLEC. | [optional] 
**Svcl** | **int?** | Service class. 0 &#x3D; Primary Local, 1 &#x3D; Primary Long Distance. | [optional] 
**Fclt** | **bool?** | Specifies if the carrier delivering the service has company owned facilities to provide the service. | [optional] 
**Frch** | **bool?** | Indicates if the company provides services sold pursuant to a franchise agreement between the carrier and jurisdiction. | [optional] 
**Reg** | **bool?** | Indicates if company is regulated. | [optional] 
**Excl** | [**List&lt;Exclusion&gt;**](Exclusion.md) | Exclusion list. | [optional] 
**Idnt** | **string** | An optional company identifier for reporting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

