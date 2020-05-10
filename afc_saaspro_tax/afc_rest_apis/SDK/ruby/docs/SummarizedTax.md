# OpenapiClient::SummarizedTax

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**max** | **Float** | Maximum base for tax bracket. | [optional] 
**min** | **Float** | Minimum base for tax bracket. | [optional] 
**tchg** | **Float** | Total charge amount. | [optional] 
**calc** | **Integer** | Calculation type. | [optional] 
**cat** | **String** | Tax category name. | [optional] 
**cid** | **Integer** | Tax category ID. | [optional] 
**name** | **String** | Tax name. | [optional] 
**exm** | **Float** | Exempt sale amount. | [optional] 
**lns** | **Integer** | Lines. | [optional] 
**pcd** | **Integer** | PCode for reporting jurisdiction. | [optional] 
**taxpcd** | **Integer** | PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true | [optional] 
**rate** | **Float** | Tax rate. | [optional] 
**sur** | **Boolean** | Indicates if this tax is a surcharge. | [optional] 
**tax** | **Float** | Tax amount. | [optional] 
**lvl** | **Integer** | Tax level ID. | [optional] 
**tid** | **Integer** | Tax type ID. | [optional] 
**usexm** | **Boolean** | Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true | [optional] 
**notax** | **Boolean** | Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true | [optional] 
**trans** | **Integer** | Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true | [optional] 
**svc** | **Integer** | Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true | [optional] 
**chg** | **Float** | Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::SummarizedTax.new(max: null,
                                 min: null,
                                 tchg: null,
                                 calc: null,
                                 cat: null,
                                 cid: null,
                                 name: null,
                                 exm: null,
                                 lns: null,
                                 pcd: null,
                                 taxpcd: null,
                                 rate: null,
                                 sur: null,
                                 tax: null,
                                 lvl: null,
                                 tid: null,
                                 usexm: null,
                                 notax: null,
                                 trans: null,
                                 svc: null,
                                 chg: null)
```


