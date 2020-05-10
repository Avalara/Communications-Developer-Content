# avalara.comms.rest.v2.Model.LineItemResult
Tax calculation results for a single line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ref** | **string** | Reference ID for line item. | [optional] 
**Base** | **double?** | Base sale amount for tax-inclusive line items. | [optional] 
**Txs** | [**List&lt;Tax&gt;**](Tax.md) | Taxes generated for line item. | [optional] 
**Err** | [**List&lt;Error&gt;**](Error.md) | Error description (as applicable). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

