# avalara.comms.rest.v2.Model.Location
Location data used to determine taxing jurisdiction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cnty** | **string** | County name. | [optional] 
**Ctry** | **string** | Country ISO code. | [optional] 
**Int** | **bool?** | Indicates if the location is within city limits.  Default: true. | [optional] 
**Geo** | **bool?** | Indicates if this address should be geocoded in order to obtain taxing jurisdiction.  Default: false. | [optional] 
**Pcd** | **int?** | PCode for taxing jurisdiction. | [optional] 
**Npa** | **int?** | NPANXX number. | [optional] 
**Fips** | **string** | FIPS code for taxing jurisdiction. | [optional] 
**Addr** | **string** | Street address. | [optional] 
**City** | **string** | City name. | [optional] 
**St** | **string** | State name or abbreviation. | [optional] 
**Zip** | **string** | Postal code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

