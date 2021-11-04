

# Tax

Tax data for individual line item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bill** | **Boolean** | Indicates if tax is billable to customer. |  [optional]
**cmpl** | **Boolean** | Indicates if the tax is to be reported to jurisdiction. |  [optional]
**tm** | **Double** | Taxable measure. |  [optional]
**calc** | **Integer** | Calculation type. |  [optional]
**cat** | **String** | Tax category name. |  [optional]
**cid** | **Integer** | Tax category ID. |  [optional]
**name** | **String** | Tax name. |  [optional]
**exm** | **Double** | Exempt sale amount. |  [optional]
**lns** | **Integer** | Lines. |  [optional]
**min** | **Double** | Minutes. |  [optional]
**pcd** | **Integer** | PCode for reporting jurisdiction. |  [optional]
**taxpcd** | **Integer** | PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true |  [optional]
**rate** | **Double** | Tax rate. |  [optional]
**sur** | **Boolean** | Indicates if this tax is a surcharge. |  [optional]
**tax** | **Double** | Tax amount. |  [optional]
**lvl** | **Integer** | Tax level ID. |  [optional]
**tid** | **Integer** | Tax type ID. |  [optional]
**usexm** | **Boolean** | Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true |  [optional]
**notax** | **Boolean** | Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true |  [optional]
**trans** | **Integer** | Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true |  [optional]
**svc** | **Integer** | Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true |  [optional]
**chg** | **Double** | Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true |  [optional]



