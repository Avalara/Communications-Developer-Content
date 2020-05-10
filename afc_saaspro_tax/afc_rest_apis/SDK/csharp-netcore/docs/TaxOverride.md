# avalara.comms.rest.v2.Model.TaxOverride
Tax rate override information.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Loc** | [**Location**](Location.md) |  | [optional] 
**Scp** | **int?** | Scope for override. 0 &#x3D; Country, 1 &#x3D; State, 2 &#x3D; County, 3 &#x3D; City. | [optional] 
**Tid** | **int?** | Tax type ID. | [optional] 
**Lvl** | **int?** | Tax level ID. 0 &#x3D; Federal, 1 &#x3D; State, 2 &#x3D; County, 3 &#x3D; City. | [optional] 
**LvlExm** | **bool?** | Indicates if the tax can be exempted using level exemptions. | [optional] 
**Brkt** | [**List&lt;TaxBracket&gt;**](TaxBracket.md) | Tax rate/bracket information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

