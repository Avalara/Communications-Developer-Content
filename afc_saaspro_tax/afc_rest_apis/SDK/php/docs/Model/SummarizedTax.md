# # SummarizedTax

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**max** | **double** | Maximum base for tax bracket. | [optional]
**min** | **double** | Minimum base for tax bracket. | [optional]
**tchg** | **double** | Total charge amount. | [optional]
**calc** | **int** | Calculation type. | [optional]
**cat** | **string** | Tax category name. | [optional]
**cid** | **int** | Tax category ID. | [optional]
**name** | **string** | Tax name. | [optional]
**exm** | **double** | Exempt sale amount. | [optional]
**lns** | **int** | Lines. | [optional]
**pcd** | **int** | PCode for reporting jurisdiction. | [optional]
**taxpcd** | **int** | PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true | [optional]
**rate** | **double** | Tax rate. | [optional]
**sur** | **bool** | Indicates if this tax is a surcharge. | [optional]
**tax** | **double** | Tax amount. | [optional]
**lvl** | **int** | Tax level ID. | [optional]
**tid** | **int** | Tax type ID. | [optional]
**usexm** | **bool** | Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true | [optional]
**notax** | **bool** | Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true | [optional]
**trans** | **int** | Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true | [optional]
**svc** | **int** | Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true | [optional]
**chg** | **double** | Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
