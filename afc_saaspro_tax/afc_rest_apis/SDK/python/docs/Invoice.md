# Invoice

Contains information about an invoice or quote.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **str** |  | [optional] 
**cmmt** | **bool** |  | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **int** |  | [optional] 
**lfln** | **bool** |  | [optional] 
**date** | **datetime** | Invoice date. | [optional] 
**exms** | [**list[TaxExemption]**](TaxExemption.md) |  | [optional] 
**itms** | [**list[LineItem]**](LineItem.md) |  | [optional] 
**invm** | **bool** |  | [optional] 
**dtl** | **bool** |  | [optional] 
**summ** | **bool** |  | [optional] 
**opt** | [**list[KeyValuePair]**](KeyValuePair.md) |  | [optional] 
**acct** | **str** |  | [optional] 
**custref** | **str** |  | [optional] 
**invn** | **str** |  | [optional] 
**bcyc** | **str** |  | [optional] 
**bpd** | [**BillingPeriod**](BillingPeriod.md) |  | [optional] 
**ccycd** | **str** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


