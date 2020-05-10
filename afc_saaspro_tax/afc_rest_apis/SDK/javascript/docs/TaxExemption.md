# SaasPro.TaxExemption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**frc** | **Boolean** | Override level exempt flag on wildcard tax type exemptions. | [optional] 
**loc** | [**Location**](Location.md) |  | [optional] 
**tpe** | **Number** | Tax type to exempt.  Tax type exemptions and Category exemptions are mutually exclusive. | [optional] 
**lvl** | **Number** | Tax level ID. | [optional] 
**cat** | **Number** | Tax category to exempt. Tax type exemptions and Category exemptions are mutually exclusive. | [optional] 
**dom** | **Number** | Exemption Domain.  This is the jurisdiction level in which the  exemption jurisdiction must match the taxing jurisdiction. | [optional] 
**scp** | **Number** | Exemption Scope.  This defines the tax levels in which the  taxes will be considered as candidates for exemption. | [optional] 
**exnb** | **Boolean** | Exempt non-billable flag.  Determines if non-billable taxes are  to be considered as candidates for exemption. | [optional] 


