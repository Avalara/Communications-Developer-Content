# OpenapiClient::Invoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **String** |  | [optional] 
**cmmt** | **Boolean** |  | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **Integer** |  | [optional] 
**lfln** | **Boolean** |  | [optional] 
**date** | **DateTime** | Invoice date. | [optional] 
**exms** | [**Array&lt;TaxExemption&gt;**](TaxExemption.md) |  | [optional] 
**itms** | [**Array&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**invm** | **Boolean** |  | [optional] 
**dtl** | **Boolean** |  | [optional] 
**summ** | **Boolean** |  | [optional] 
**opt** | [**Array&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 
**acct** | **String** |  | [optional] 
**custref** | **String** |  | [optional] 
**invn** | **String** |  | [optional] 
**bcyc** | **String** |  | [optional] 
**bpd** | [**BillingPeriod**](BillingPeriod.md) |  | [optional] 
**ccycd** | **String** |  | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::Invoice.new(doc: null,
                                 cmmt: null,
                                 bill: null,
                                 cust: null,
                                 lfln: null,
                                 date: null,
                                 exms: null,
                                 itms: null,
                                 invm: null,
                                 dtl: null,
                                 summ: null,
                                 opt: null,
                                 acct: null,
                                 custref: null,
                                 invn: null,
                                 bcyc: null,
                                 bpd: null,
                                 ccycd: null)
```


