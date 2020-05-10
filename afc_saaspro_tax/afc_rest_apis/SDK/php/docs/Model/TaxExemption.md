# # TaxExemption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**frc** | **bool** | Override level exempt flag on wildcard tax type exemptions. | [optional] 
**loc** | [**\OpenAPI\Client\Model\Location**](Location.md) |  | [optional] 
**tpe** | **int** | Tax type to exempt.  Tax type exemptions and Category exemptions are mutually exclusive. | [optional] 
**lvl** | **int** | Tax level ID. | [optional] 
**cat** | **int** | Tax category to exempt. Tax type exemptions and Category exemptions are mutually exclusive. | [optional] 
**dom** | **int** | Exemption Domain.  This is the jurisdiction level in which the  exemption jurisdiction must match the taxing jurisdiction. | [optional] 
**scp** | **int** | Exemption Scope.  This defines the tax levels in which the  taxes will be considered as candidates for exemption. | [optional] 
**exnb** | **bool** | Exempt non-billable flag.  Determines if non-billable taxes are  to be considered as candidates for exemption. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


