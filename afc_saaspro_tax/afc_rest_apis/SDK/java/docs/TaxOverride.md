

# TaxOverride

Tax rate override information.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loc** | [**Location**](Location.md) |  |  [optional]
**scp** | **Integer** | Scope for override. 0 &#x3D; Country, 1 &#x3D; State, 2 &#x3D; County, 3 &#x3D; City. |  [optional]
**tid** | **Integer** | Tax type ID. |  [optional]
**lvl** | **Integer** | Tax level ID. 0 &#x3D; Federal, 1 &#x3D; State, 2 &#x3D; County, 3 &#x3D; City. |  [optional]
**lvlExm** | **Boolean** | Indicates if the tax can be exempted using level exemptions. |  [optional]
**brkt** | [**List&lt;TaxBracket&gt;**](TaxBracket.md) | Tax rate/bracket information. |  [optional]



