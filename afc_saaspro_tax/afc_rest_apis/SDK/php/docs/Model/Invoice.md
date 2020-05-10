# # Invoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **string** | Document code. | [optional] 
**cmmt** | **bool** | Indicates if invoice should be committed as soon as it is processed.  Default: false. | [optional] 
**bill** | [**\OpenAPI\Client\Model\Location**](Location.md) |  | [optional] 
**cust** | **int** | Customer type. | [optional] 
**lfln** | **bool** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**date** | [**\DateTime**](\DateTime.md) | Invoice date. | [optional] 
**exms** | [**\OpenAPI\Client\Model\TaxExemption[]**](TaxExemption.md) | Tax exemptions. | [optional] 
**itms** | [**\OpenAPI\Client\Model\LineItem[]**](LineItem.md) | Line items. | [optional] 
**invm** | **bool** | Indicates if all line items within invoice should be processed in invoice mode.  Default: true. | [optional] 
**dtl** | **bool** | Indicates if individual line item taxes should be included in response.  Default: true. | [optional] 
**summ** | **bool** | Indicates if the summarized taxes for the invoice should be included in the resonse.  Default: false. | [optional] 
**opt** | [**\OpenAPI\Client\Model\KeyValuePair[]**](KeyValuePair.md) | Optional values for invoice. Maximum of 5. Keys must be numeric from 1 to 5. | [optional] 
**acct** | **string** | Account reference for reporting | [optional] 
**custref** | **string** | Customer Reference for reporting | [optional] 
**invn** | **string** | Invoice Number reference for reporting | [optional] 
**bcyc** | **string** | Bill Cycle reference for reporting | [optional] 
**bpd** | [**\OpenAPI\Client\Model\BillingPeriod**](BillingPeriod.md) |  | [optional] 
**ccycd** | **string** | Currency code for invoice.  Example: CAD &#x3D; Canadian Dollar | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


