# avalara.comms.rest.v2.Model.Invoice
Contains information about an invoice or quote.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Doc** | **string** | Document code. | [optional] 
**Cmmt** | **bool?** | Indicates if invoice should be committed as soon as it is processed.  Default: false. | [optional] 
**Bill** | [**Location**](Location.md) |  | [optional] 
**Cust** | **int?** | Customer type. | [optional] 
**Lfln** | **bool?** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**Date** | **DateTime?** | Invoice date. | [optional] 
**Exms** | [**List&lt;TaxExemption&gt;**](TaxExemption.md) | Tax exemptions. | [optional] 
**Itms** | [**List&lt;LineItem&gt;**](LineItem.md) | Line items. | [optional] 
**Invm** | **bool?** | Indicates if all line items within invoice should be processed in invoice mode.  Default: true. | [optional] 
**Dtl** | **bool?** | Indicates if individual line item taxes should be included in response.  Default: true. | [optional] 
**Summ** | **bool?** | Indicates if the summarized taxes for the invoice should be included in the resonse.  Default: false. | [optional] 
**Opt** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) | Optional values for invoice. Maximum of 5. Keys must be numeric from 1 to 5. | [optional] 
**Acct** | **string** | Account reference for reporting | [optional] 
**Custref** | **string** | Customer Reference for reporting | [optional] 
**Invn** | **string** | Invoice Number reference for reporting | [optional] 
**Bcyc** | **string** | Bill Cycle reference for reporting | [optional] 
**Bpd** | [**BillingPeriod**](BillingPeriod.md) |  | [optional] 
**Ccycd** | **string** | Currency code for invoice.  Example: CAD &#x3D; Canadian Dollar | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

