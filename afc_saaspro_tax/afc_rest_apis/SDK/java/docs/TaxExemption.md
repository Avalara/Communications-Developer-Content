

# TaxExemption

Tax exemption data.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**frc** | **Boolean** | Override level exempt flag on wildcard tax type exemptions. |  [optional]
**loc** | [**Location**](Location.md) |  |  [optional]
**tpe** | **Integer** | Tax type to exempt.  Tax type exemptions and Category exemptions are mutually exclusive. |  [optional]
**lvl** | **Integer** | Tax level ID. |  [optional]
**cat** | **Integer** | Tax category to exempt. Tax type exemptions and Category exemptions are mutually exclusive. |  [optional]
**dom** | **Integer** | Exemption Domain.  This is the jurisdiction level in which the  exemption jurisdiction must match the taxing jurisdiction. |  [optional]
**scp** | **Integer** | Exemption Scope.  This defines the tax levels in which the  taxes will be considered as candidates for exemption. |  [optional]
**exnb** | **Boolean** | Exempt non-billable flag.  Determines if non-billable taxes are  to be considered as candidates for exemption. |  [optional]



