# OpenapiClient::LookupsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_v2_afc_location_pcode_get**](LookupsApi.md#api_v2_afc_location_pcode_get) | **GET** /api/v2/afc/location/{pcode} | Get location data associated with a PCode
[**api_v2_afc_primary_p_code_get**](LookupsApi.md#api_v2_afc_primary_p_code_get) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
[**api_v2_afc_serviceinfo_get**](LookupsApi.md#api_v2_afc_serviceinfo_get) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
[**api_v2_afc_taxtype_tax_type_get**](LookupsApi.md#api_v2_afc_taxtype_tax_type_get) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
[**api_v2_afc_tspairs_get**](LookupsApi.md#api_v2_afc_tspairs_get) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information



## api_v2_afc_location_pcode_get

> PCodeLookupResult api_v2_afc_location_pcode_get(pcode)

Get location data associated with a PCode

Request will return all jurisdictions associated with the PCode

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::LookupsApi.new
pcode = 56 # Integer | 

begin
  #Get location data associated with a PCode
  result = api_instance.api_v2_afc_location_pcode_get(pcode)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LookupsApi->api_v2_afc_location_pcode_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pcode** | **Integer**|  | 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## api_v2_afc_primary_p_code_get

> PCodeLookupResult api_v2_afc_primary_p_code_get(p_code)

Get primary location data associated with a PCode

Request will return primary jurisdiction associated with the PCode

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::LookupsApi.new
p_code = 56 # Integer | 

begin
  #Get primary location data associated with a PCode
  result = api_instance.api_v2_afc_primary_p_code_get(p_code)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LookupsApi->api_v2_afc_primary_p_code_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **p_code** | **Integer**|  | 

### Return type

[**PCodeLookupResult**](PCodeLookupResult.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## api_v2_afc_serviceinfo_get

> ServiceInfo api_v2_afc_serviceinfo_get

Retrieves server time, service build version and engine version

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::LookupsApi.new

begin
  #Retrieves server time, service build version and engine version
  result = api_instance.api_v2_afc_serviceinfo_get
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LookupsApi->api_v2_afc_serviceinfo_get: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ServiceInfo**](ServiceInfo.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## api_v2_afc_taxtype_tax_type_get

> Array&lt;TaxTypeData&gt; api_v2_afc_taxtype_tax_type_get(tax_type)

Get the tax information (description and category) for a tax type ID

This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::LookupsApi.new
tax_type = 'tax_type_example' # String | Tax type ID for the tax type.

begin
  #Get the tax information (description and category) for a tax type ID
  result = api_instance.api_v2_afc_taxtype_tax_type_get(tax_type)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LookupsApi->api_v2_afc_taxtype_tax_type_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tax_type** | **String**| Tax type ID for the tax type. | 

### Return type

[**Array&lt;TaxTypeData&gt;**](TaxTypeData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## api_v2_afc_tspairs_get

> Array&lt;TSPairData&gt; api_v2_afc_tspairs_get

Get transaction/service pair information

This method returns the description for the transaction type, service type and the ts pairs.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::LookupsApi.new

begin
  #Get transaction/service pair information
  result = api_instance.api_v2_afc_tspairs_get
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LookupsApi->api_v2_afc_tspairs_get: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**Array&lt;TSPairData&gt;**](TSPairData.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

