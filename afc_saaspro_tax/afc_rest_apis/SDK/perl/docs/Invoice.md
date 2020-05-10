# WWW::OpenAPIClient::Object::Invoice

## Load the model package
```perl
use WWW::OpenAPIClient::Object::Invoice;
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **string** | Document code. | [optional] 
**cmmt** | **boolean** | Indicates if invoice should be committed as soon as it is processed.  Default: false. | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **int** | Customer type. | [optional] 
**lfln** | **boolean** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**date** | **DateTime** | Invoice date. | [optional] 
**exms** | [**ARRAY[TaxExemption]**](TaxExemption.md) | Tax exemptions. | [optional] 
**itms** | [**ARRAY[LineItem]**](LineItem.md) | Line items. | [optional] 
**invm** | **boolean** | Indicates if all line items within invoice should be processed in invoice mode.  Default: true. | [optional] 
**dtl** | **boolean** | Indicates if individual line item taxes should be included in response.  Default: true. | [optional] 
**summ** | **boolean** | Indicates if the summarized taxes for the invoice should be included in the resonse.  Default: false. | [optional] 
**opt** | [**ARRAY[KeyValuePair]**](KeyValuePair.md) | Optional values for invoice. Maximum of 5. Keys must be numeric from 1 to 5. | [optional] 
**acct** | **string** | Account reference for reporting | [optional] 
**custref** | **string** | Customer Reference for reporting | [optional] 
**invn** | **string** | Invoice Number reference for reporting | [optional] 
**bcyc** | **string** | Bill Cycle reference for reporting | [optional] 
**bpd** | [**BillingPeriod**](BillingPeriod.md) |  | [optional] 
**ccycd** | **string** | Currency code for invoice.  Example: CAD &#x3D; Canadian Dollar | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


