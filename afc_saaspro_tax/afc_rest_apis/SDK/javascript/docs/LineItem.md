# SaasPro.LineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** | Reference ID for line item. | [optional] 
**from** | [**Location**](Location.md) |  | [optional] 
**to** | [**Location**](Location.md) |  | [optional] 
**chg** | **Number** | Charge amount.  Default: 0. | [optional] 
**line** | **Number** | Number of lines.  Default: 0. | [optional] 
**loc** | **Number** | Number of locations.  Default: 0. | [optional] 
**min** | **Number** | Number of minutes.  Default: 0. | [optional] 
**sale** | **Number** | 0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only). | [optional] 
**plsp** | **Number** | Split for private-line transactions. | [optional] 
**incl** | **Boolean** | Indicates if the charge for this line item is tax-inclusive. | [optional] 
**pror** | **Number** | For pro-rated tax calculations. Percentage to pro-rate. | [optional] 
**proadj** | **Number** | For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response | [optional] 
**tran** | **Number** | Transaction type ID. | [optional] 
**serv** | **Number** | Service type ID. | [optional] 
**dbt** | **Boolean** | Indicates if this line item is a debit card transaction.  Default: false. | [optional] 
**adj** | **Boolean** | Indicates if this line item is an adjustment.  Default: false. | [optional] 
**adjm** | **Number** | Adjustment method. | [optional] 
**disc** | **Number** | Discount type for adjustments. | [optional] 
**opt** | [**[KeyValuePair]**](KeyValuePair.md) | Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10. | [optional] 
**prop** | **Number** | Attribute/property value for sales and use transaction/service pairs. | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **Number** | Customer type. | [optional] 
**lfln** | **Boolean** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**_date** | **Date** | Invoice date. | [optional] 
**qty** | **Number** | Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity | [optional] 
**glref** | **String** | General Ledger reference to be used in reporting | [optional] 


