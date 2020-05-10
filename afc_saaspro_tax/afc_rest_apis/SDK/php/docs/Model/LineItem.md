# # LineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **string** | Reference ID for line item. | [optional] 
**from** | [**\OpenAPI\Client\Model\Location**](Location.md) |  | [optional] 
**to** | [**\OpenAPI\Client\Model\Location**](Location.md) |  | [optional] 
**chg** | **double** | Charge amount.  Default: 0. | [optional] 
**line** | **int** | Number of lines.  Default: 0. | [optional] 
**loc** | **int** | Number of locations.  Default: 0. | [optional] 
**min** | **double** | Number of minutes.  Default: 0. | [optional] 
**sale** | **int** | 0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only). | [optional] 
**plsp** | **double** | Split for private-line transactions. | [optional] 
**incl** | **bool** | Indicates if the charge for this line item is tax-inclusive. | [optional] 
**pror** | **double** | For pro-rated tax calculations. Percentage to pro-rate. | [optional] 
**proadj** | **int** | For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response | [optional] 
**tran** | **int** | Transaction type ID. | [optional] 
**serv** | **int** | Service type ID. | [optional] 
**dbt** | **bool** | Indicates if this line item is a debit card transaction.  Default: false. | [optional] 
**adj** | **bool** | Indicates if this line item is an adjustment.  Default: false. | [optional] 
**adjm** | **int** | Adjustment method. | [optional] 
**disc** | **int** | Discount type for adjustments. | [optional] 
**opt** | [**\OpenAPI\Client\Model\KeyValuePair[]**](KeyValuePair.md) | Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10. | [optional] 
**prop** | **int** | Attribute/property value for sales and use transaction/service pairs. | [optional] 
**bill** | [**\OpenAPI\Client\Model\Location**](Location.md) |  | [optional] 
**cust** | **int** | Customer type. | [optional] 
**lfln** | **bool** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**date** | [**\DateTime**](\DateTime.md) | Invoice date. | [optional] 
**qty** | **int** | Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity | [optional] 
**glref** | **string** | General Ledger reference to be used in reporting | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


