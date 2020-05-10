# avalara.comms.rest.v2.Model.LineItem
Data for an invoice or quote line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ref** | **string** | Reference ID for line item. | [optional] 
**From** | [**Location**](Location.md) |  | [optional] 
**To** | [**Location**](Location.md) |  | [optional] 
**Chg** | **double?** | Charge amount.  Default: 0. | [optional] 
**Line** | **int?** | Number of lines.  Default: 0. | [optional] 
**Loc** | **int?** | Number of locations.  Default: 0. | [optional] 
**Min** | **double?** | Number of minutes.  Default: 0. | [optional] 
**Sale** | **int?** | 0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only). | [optional] 
**Plsp** | **double?** | Split for private-line transactions. | [optional] 
**Incl** | **bool?** | Indicates if the charge for this line item is tax-inclusive. | [optional] 
**Pror** | **double?** | For pro-rated tax calculations. Percentage to pro-rate. | [optional] 
**Proadj** | **int** | For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response | [optional] 
**Tran** | **int?** | Transaction type ID. | [optional] 
**Serv** | **int?** | Service type ID. | [optional] 
**Dbt** | **bool?** | Indicates if this line item is a debit card transaction.  Default: false. | [optional] 
**Adj** | **bool?** | Indicates if this line item is an adjustment.  Default: false. | [optional] 
**Adjm** | **int?** | Adjustment method. | [optional] 
**Disc** | **int?** | Discount type for adjustments. | [optional] 
**Opt** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) | Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10. | [optional] 
**Prop** | **int?** | Attribute/property value for sales and use transaction/service pairs. | [optional] 
**Bill** | [**Location**](Location.md) |  | [optional] 
**Cust** | **int?** | Customer type. | [optional] 
**Lfln** | **bool?** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**Date** | **DateTime?** | Invoice date. | [optional] 
**Qty** | **int?** | Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity | [optional] 
**Glref** | **string** | General Ledger reference to be used in reporting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

