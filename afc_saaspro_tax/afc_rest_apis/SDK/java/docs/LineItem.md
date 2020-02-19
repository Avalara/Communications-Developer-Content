

# LineItem

Data for an invoice or quote line item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** |  |  [optional]
**from** | [**Location**](Location.md) | Location for origination point. If null, will default to Invoice&#39;s BillTo location. |  [optional]
**to** | [**Location**](Location.md) | Location for destination point. If null, will default to Invoice&#39;s BillTo location. |  [optional]
**chg** | **Double** |  |  [optional]
**line** | **Integer** |  |  [optional]
**loc** | **Integer** |  |  [optional]
**min** | **Double** |  |  [optional]
**sale** | **Integer** |  |  [optional]
**plsp** | **Double** |  |  [optional]
**incl** | **Boolean** |  |  [optional]
**pror** | **Double** |  |  [optional]
**proadj** | **Integer** |  |  [optional]
**tran** | **Integer** |  |  [optional]
**serv** | **Integer** |  |  [optional]
**dbt** | **Boolean** |  |  [optional]
**adj** | **Boolean** |  |  [optional]
**adjm** | **Integer** |  |  [optional]
**disc** | **Integer** |  |  [optional]
**opt** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  |  [optional]
**prop** | **Integer** |  |  [optional]
**bill** | [**Location**](Location.md) |  |  [optional]
**cust** | **Integer** |  |  [optional]
**lfln** | **Boolean** |  |  [optional]
**date** | [**OffsetDateTime**](OffsetDateTime.md) | Invoice date. |  [optional]
**qty** | **Integer** |  |  [optional]
**glref** | **String** |  |  [optional]



