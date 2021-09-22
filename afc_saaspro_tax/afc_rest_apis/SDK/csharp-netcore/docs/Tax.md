# avalara.comms.rest.v2.Model.Tax
Tax data for individual line item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bill** | **bool?** | Indicates if tax is billable to customer. | [optional] 
**Cmpl** | **bool?** | Indicates if the tax is to be reported to jurisdiction. | [optional] 
**Tm** | **double?** | Taxable measure. | [optional] 
**Calc** | **int?** | Calculation type. | [optional] 
**Cat** | **string** | Tax category name. | [optional] 
**Cid** | **int?** | Tax category ID. | [optional] 
**Name** | **string** | Tax name. | [optional] 
**Exm** | **double?** | Exempt sale amount. | [optional] 
**Lns** | **int?** | Lines. | [optional] 
**Min** | **double?** | Minutes. | [optional] 
**Pcd** | **int?** | PCode for reporting jurisdiction. | [optional] 
**Taxpcd** | **int?** | PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true | [optional] 
**Rate** | **double?** | Tax rate. | [optional] 
**Sur** | **bool?** | Indicates if this tax is a surcharge. | [optional] 
**_Tax** | **double?** | Tax amount. | [optional] 
**Lvl** | **int?** | Tax level ID. | [optional] 
**Tid** | **int?** | Tax type ID. | [optional] 
**Usexm** | **bool?** | Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true | [optional] 
**Notax** | **bool?** | Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true | [optional] 
**Trans** | **int?** | Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true | [optional] 
**Svc** | **int?** | Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true | [optional] 
**Chg** | **double?** | Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

