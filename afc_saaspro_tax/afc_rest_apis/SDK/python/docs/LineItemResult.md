# LineItemResult

Tax calculation results for a single line item.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **str** | Reference ID for line item. | [optional] 
**base** | **float** | Base sale amount for tax-inclusive line items. | [optional] 
**txs** | [**list[Tax]**](Tax.md) | Taxes generated for line item. | [optional] 
**err** | [**list[Error]**](Error.md) | Error description (as applicable). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


