# WWW::OpenAPIClient::Object::CompanyData

## Load the model package
```perl
use WWW::OpenAPIClient::Object::CompanyData;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bscl** | **int** | Business class. 0 &#x3D; ILEC, 1 &#x3D; CLEC. | [optional] 
**svcl** | **int** | Service class. 0 &#x3D; Primary Local, 1 &#x3D; Primary Long Distance. | [optional] 
**fclt** | **boolean** | Specifies if the carrier delivering the service has company owned facilities to provide the service. | [optional] 
**frch** | **boolean** | Indicates if the company provides services sold pursuant to a franchise agreement between the carrier and jurisdiction. | [optional] 
**reg** | **boolean** | Indicates if company is regulated. | [optional] 
**excl** | [**ARRAY[Exclusion]**](Exclusion.md) | Exclusion list. | [optional] 
**idnt** | **string** | An optional company identifier for reporting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


