# avalara.comms.rest.v2.Model.TaxExemption
Tax exemption data.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frc** | **bool?** | Override level exempt flag on wildcard tax type exemptions. | [optional] 
**Loc** | [**Location**](Location.md) |  | [optional] 
**Tpe** | **int?** | Tax type to exempt.  Tax type exemptions and Category exemptions are mutually exclusive. | [optional] 
**Lvl** | **int?** | Tax level ID. | [optional] 
**Cat** | **int?** | Tax category to exempt. Tax type exemptions and Category exemptions are mutually exclusive. | [optional] 
**Dom** | **int?** | Exemption Domain.  This is the jurisdiction level in which the  exemption jurisdiction must match the taxing jurisdiction. | [optional] 
**Scp** | **int?** | Exemption Scope.  This defines the tax levels in which the  taxes will be considered as candidates for exemption. | [optional] 
**Exnb** | **bool?** | Exempt non-billable flag.  Determines if non-billable taxes are  to be considered as candidates for exemption. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

