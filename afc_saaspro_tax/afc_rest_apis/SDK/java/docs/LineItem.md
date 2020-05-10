

# LineItem

Data for an invoice or quote line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** | Reference ID for line item. |  [optional]
**from** | [**Location**](Location.md) |  |  [optional]
**to** | [**Location**](Location.md) |  |  [optional]
**chg** | **Double** | Charge amount.  Default: 0. |  [optional]
**line** | **Integer** | Number of lines.  Default: 0. |  [optional]
**loc** | **Integer** | Number of locations.  Default: 0. |  [optional]
**min** | **Double** | Number of minutes.  Default: 0. |  [optional]
**sale** | **Integer** | 0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only). |  [optional]
**plsp** | **Double** | Split for private-line transactions. |  [optional]
**incl** | **Boolean** | Indicates if the charge for this line item is tax-inclusive. |  [optional]
**pror** | **Double** | For pro-rated tax calculations. Percentage to pro-rate. |  [optional]
**proadj** | **Integer** | For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response |  [optional]
**tran** | **Integer** | Transaction type ID. |  [optional]
**serv** | **Integer** | Service type ID. |  [optional]
**dbt** | **Boolean** | Indicates if this line item is a debit card transaction.  Default: false. |  [optional]
**adj** | **Boolean** | Indicates if this line item is an adjustment.  Default: false. |  [optional]
**adjm** | **Integer** | Adjustment method. |  [optional]
**disc** | **Integer** | Discount type for adjustments. |  [optional]
**opt** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) | Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10. |  [optional]
**prop** | **Integer** | Attribute/property value for sales and use transaction/service pairs. |  [optional]
**bill** | [**Location**](Location.md) |  |  [optional]
**cust** | **Integer** | Customer type. |  [optional]
**lfln** | **Boolean** | Indicates if customer is a Lifeline participant.  Default: false. |  [optional]
**date** | [**OffsetDateTime**](OffsetDateTime.md) | Invoice date. |  [optional]
**qty** | **Integer** | Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity |  [optional]
**glref** | **String** | General Ledger reference to be used in reporting |  [optional]



