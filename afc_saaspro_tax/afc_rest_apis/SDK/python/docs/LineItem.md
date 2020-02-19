# LineItem

Data for an invoice or quote line item.
## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **str** |  | [optional] 
**_from** | [**Location**](Location.md) | Location for origination point. If null, will default to Invoice&#39;s BillTo location. | [optional] 
**to** | [**Location**](Location.md) | Location for destination point. If null, will default to Invoice&#39;s BillTo location. | [optional] 
**chg** | **float** |  | [optional] 
**line** | **int** |  | [optional] 
**loc** | **int** |  | [optional] 
**min** | **float** |  | [optional] 
**sale** | **int** |  | [optional] 
**plsp** | **float** |  | [optional] 
**incl** | **bool** |  | [optional] 
**pror** | **float** |  | [optional] 
**proadj** | **int** |  | [optional] 
**tran** | **int** |  | [optional] 
**serv** | **int** |  | [optional] 
**dbt** | **bool** |  | [optional] 
**adj** | **bool** |  | [optional] 
**adjm** | **int** |  | [optional] 
**disc** | **int** |  | [optional] 
**opt** | [**list[KeyValuePair]**](KeyValuePair.md) |  | [optional] 
**prop** | **int** |  | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **int** |  | [optional] 
**lfln** | **bool** |  | [optional] 
**date** | **datetime** | Invoice date. | [optional] 
**qty** | **int** |  | [optional] 
**glref** | **str** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


