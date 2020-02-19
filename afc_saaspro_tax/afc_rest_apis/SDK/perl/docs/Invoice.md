# WWW::OpenAPIClient::Object::Invoice

## Load the model package
```perl
use WWW::OpenAPIClient::Object::Invoice;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **string** |  | [optional] 
**cmmt** | **boolean** |  | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **int** |  | [optional] 
**lfln** | **boolean** |  | [optional] 
**date** | **DateTime** | Invoice date. | [optional] 
**exms** | [**ARRAY[TaxExemption]**](TaxExemption.md) |  | [optional] 
**itms** | [**ARRAY[LineItem]**](LineItem.md) |  | [optional] 
**invm** | **boolean** |  | [optional] 
**dtl** | **boolean** |  | [optional] 
**summ** | **boolean** |  | [optional] 
**opt** | [**ARRAY[KeyValuePair]**](KeyValuePair.md) |  | [optional] 
**acct** | **string** |  | [optional] 
**custref** | **string** |  | [optional] 
**invn** | **string** |  | [optional] 
**bcyc** | **string** |  | [optional] 
**bpd** | [**BillingPeriod**](BillingPeriod.md) |  | [optional] 
**ccycd** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


