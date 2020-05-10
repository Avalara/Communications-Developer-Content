# # TaxOverride

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loc** | [**\OpenAPI\Client\Model\Location**](Location.md) |  | [optional] 
**scp** | **int** | Scope for override. 0 &#x3D; Country, 1 &#x3D; State, 2 &#x3D; County, 3 &#x3D; City. | [optional] 
**tid** | **int** | Tax type ID. | [optional] 
**lvl** | **int** | Tax level ID. 0 &#x3D; Federal, 1 &#x3D; State, 2 &#x3D; County, 3 &#x3D; City. | [optional] 
**lvl_exm** | **bool** | Indicates if the tax can be exempted using level exemptions. | [optional] 
**brkt** | [**\OpenAPI\Client\Model\TaxBracket[]**](TaxBracket.md) | Tax rate/bracket information. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


