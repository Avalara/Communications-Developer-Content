# SaasPro.Tax

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bill** | **Boolean** | Indicates if tax is billable to customer. | [optional] 
**cmpl** | **Boolean** | Indicates if the tax is to be reported to jurisdiction. | [optional] 
**tm** | **Number** | Taxable measure. | [optional] 
**calc** | **Number** | Calculation type. | [optional] 
**cat** | **String** | Tax category name. | [optional] 
**cid** | **Number** | Tax category ID. | [optional] 
**name** | **String** | Tax name. | [optional] 
**exm** | **Number** | Exempt sale amount. | [optional] 
**lns** | **Number** | Lines. | [optional] 
**min** | **Number** | Minutes. | [optional] 
**pcd** | **Number** | PCode for reporting jurisdiction. | [optional] 
**taxpcd** | **Number** | PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true | [optional] 
**rate** | **Number** | Tax rate. | [optional] 
**sur** | **Boolean** | Indicates if this tax is a surcharge. | [optional] 
**tax** | **Number** | Tax amount. | [optional] 
**lvl** | **Number** | Tax level ID. | [optional] 
**tid** | **Number** | Tax type ID. | [optional] 
**usexm** | **Boolean** | Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true | [optional] 
**notax** | **Boolean** | Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true | [optional] 
**trans** | **Number** | Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true | [optional] 
**svc** | **Number** | Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true | [optional] 
**chg** | **Number** | Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true | [optional] 


