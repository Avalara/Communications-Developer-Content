# OpenapiClient::LineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ref** | **String** |  | [optional] 
**from** | [**Location**](Location.md) | Location for origination point. If null, will default to Invoice&#39;s BillTo location. | [optional] 
**to** | [**Location**](Location.md) | Location for destination point. If null, will default to Invoice&#39;s BillTo location. | [optional] 
**chg** | **Float** |  | [optional] 
**line** | **Integer** |  | [optional] 
**loc** | **Integer** |  | [optional] 
**min** | **Float** |  | [optional] 
**sale** | **Integer** |  | [optional] 
**plsp** | **Float** |  | [optional] 
**incl** | **Boolean** |  | [optional] 
**pror** | **Float** |  | [optional] 
**proadj** | **Integer** |  | [optional] 
**tran** | **Integer** |  | [optional] 
**serv** | **Integer** |  | [optional] 
**dbt** | **Boolean** |  | [optional] 
**adj** | **Boolean** |  | [optional] 
**adjm** | **Integer** |  | [optional] 
**disc** | **Integer** |  | [optional] 
**opt** | [**Array&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 
**prop** | **Integer** |  | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **Integer** |  | [optional] 
**lfln** | **Boolean** |  | [optional] 
**date** | **DateTime** | Invoice date. | [optional] 
**qty** | **Integer** |  | [optional] 
**glref** | **String** |  | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::LineItem.new(ref: null,
                                 from: null,
                                 to: null,
                                 chg: null,
                                 line: null,
                                 loc: null,
                                 min: null,
                                 sale: null,
                                 plsp: null,
                                 incl: null,
                                 pror: null,
                                 proadj: null,
                                 tran: null,
                                 serv: null,
                                 dbt: null,
                                 adj: null,
                                 adjm: null,
                                 disc: null,
                                 opt: null,
                                 prop: null,
                                 bill: null,
                                 cust: null,
                                 lfln: null,
                                 date: null,
                                 qty: null,
                                 glref: null)
```


