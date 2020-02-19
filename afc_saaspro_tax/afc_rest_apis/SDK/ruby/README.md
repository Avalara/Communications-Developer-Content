# openapi_client

OpenapiClient - the Ruby gem for the SaasPro

APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.

This SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v2
- Package version: 1.0.0
- Build package: org.openapitools.codegen.languages.RubyClientCodegen

## Installation

### Build a gem

To build the Ruby code into a gem:

```shell
gem build openapi_client.gemspec
```

Then either install the gem locally:

```shell
gem install ./openapi_client-1.0.0.gem
```

(for development, run `gem install --dev ./openapi_client-1.0.0.gem` to install the development dependencies)

or publish the gem to a gem hosting service, e.g. [RubyGems](https://rubygems.org/).

Finally add this to the Gemfile:

    gem 'openapi_client', '~> 1.0.0'

### Install from Git

If the Ruby gem is hosted at a git repository: https://github.com/GIT_USER_ID/GIT_REPO_ID, then add the following in the Gemfile:

    gem 'openapi_client', :git => 'https://github.com/GIT_USER_ID/GIT_REPO_ID.git'

### Include the Ruby code directly

Include the Ruby code directly using `-I` as follows:

```shell
ruby -Ilib script.rb
```

## Getting Started

Please follow the [installation](#installation) procedure and then run the following code:

```ruby
# Load the gem
require 'openapi_client'

# Setup authorization
OpenapiClient.configure do |config|
end

api_instance = OpenapiClient::CustomizationApi.new
opts = {
  requested_client_id: 56, # Integer | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable.
  requested_profile_id: 56, # Integer | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set.
  item_type: OpenapiClient::TaxCalculationSettingTypes.new # TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All
}

begin
  #Retrieves one or more profiles with associated settings and configurable items
  result = api_instance.api_v2_profiles_get_profiles_get(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CustomizationApi->api_v2_profiles_get_profiles_get: #{e}"
end

```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*OpenapiClient::CustomizationApi* | [**api_v2_profiles_get_profiles_get**](docs/CustomizationApi.md#api_v2_profiles_get_profiles_get) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
*OpenapiClient::CustomizationApi* | [**api_v2_profiles_set_bundles_post**](docs/CustomizationApi.md#api_v2_profiles_set_bundles_post) | **POST** /api/v2/profiles/SetBundles | Creates or updates bundle packages and associated profile mappings.
*OpenapiClient::CustomizationApi* | [**api_v2_profiles_set_config_post**](docs/CustomizationApi.md#api_v2_profiles_set_config_post) | **POST** /api/v2/profiles/SetConfig | Creates or updates configuration settings and associated profile mappings.
*OpenapiClient::CustomizationApi* | [**api_v2_profiles_set_exclusions_post**](docs/CustomizationApi.md#api_v2_profiles_set_exclusions_post) | **POST** /api/v2/profiles/SetExclusions | Creates or updates exclusions and associated profile mappings.
*OpenapiClient::CustomizationApi* | [**api_v2_profiles_set_overrides_post**](docs/CustomizationApi.md#api_v2_profiles_set_overrides_post) | **POST** /api/v2/profiles/SetOverrides | Creates or updates overrides and associated profile mappings.
*OpenapiClient::HealthCheckApi* | [**api_v2_health_check_get**](docs/HealthCheckApi.md#api_v2_health_check_get) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use
*OpenapiClient::JurisdictionDeterminationApi* | [**api_v2_afc_p_code_post**](docs/JurisdictionDeterminationApi.md#api_v2_afc_p_code_post) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
*OpenapiClient::JurisdictionDeterminationApi* | [**api_v2_geo_batch_log_process_id_get**](docs/JurisdictionDeterminationApi.md#api_v2_geo_batch_log_process_id_get) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
*OpenapiClient::JurisdictionDeterminationApi* | [**api_v2_geo_batch_status_process_id_get**](docs/JurisdictionDeterminationApi.md#api_v2_geo_batch_status_process_id_get) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
*OpenapiClient::JurisdictionDeterminationApi* | [**api_v2_geo_batch_upload_post**](docs/JurisdictionDeterminationApi.md#api_v2_geo_batch_upload_post) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
*OpenapiClient::JurisdictionDeterminationApi* | [**api_v2_geo_geocode_post**](docs/JurisdictionDeterminationApi.md#api_v2_geo_geocode_post) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.
*OpenapiClient::LookupsApi* | [**api_v2_afc_location_pcode_get**](docs/LookupsApi.md#api_v2_afc_location_pcode_get) | **GET** /api/v2/afc/location/{pcode} | Get location data associated with a PCode
*OpenapiClient::LookupsApi* | [**api_v2_afc_primary_p_code_get**](docs/LookupsApi.md#api_v2_afc_primary_p_code_get) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
*OpenapiClient::LookupsApi* | [**api_v2_afc_serviceinfo_get**](docs/LookupsApi.md#api_v2_afc_serviceinfo_get) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
*OpenapiClient::LookupsApi* | [**api_v2_afc_taxtype_tax_type_get**](docs/LookupsApi.md#api_v2_afc_taxtype_tax_type_get) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
*OpenapiClient::LookupsApi* | [**api_v2_afc_tspairs_get**](docs/LookupsApi.md#api_v2_afc_tspairs_get) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information
*OpenapiClient::TaxCalculationApi* | [**api_v2_afc_calc_taxes_post**](docs/TaxCalculationApi.md#api_v2_afc_calc_taxes_post) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
*OpenapiClient::TaxCalculationApi* | [**api_v2_afc_commit_post**](docs/TaxCalculationApi.md#api_v2_afc_commit_post) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.


## Documentation for Models

 - [OpenapiClient::Address](docs/Address.md)
 - [OpenapiClient::BillingPeriod](docs/BillingPeriod.md)
 - [OpenapiClient::BundleConfig](docs/BundleConfig.md)
 - [OpenapiClient::BundleItem](docs/BundleItem.md)
 - [OpenapiClient::CalcTaxesRequest](docs/CalcTaxesRequest.md)
 - [OpenapiClient::CalcTaxesResponse](docs/CalcTaxesResponse.md)
 - [OpenapiClient::CommitRequest](docs/CommitRequest.md)
 - [OpenapiClient::CommitResponse](docs/CommitResponse.md)
 - [OpenapiClient::CompanyData](docs/CompanyData.md)
 - [OpenapiClient::Configuration](docs/Configuration.md)
 - [OpenapiClient::Error](docs/Error.md)
 - [OpenapiClient::Exclusion](docs/Exclusion.md)
 - [OpenapiClient::ExclusionConfig](docs/ExclusionConfig.md)
 - [OpenapiClient::GeoBatchDownloadResponse](docs/GeoBatchDownloadResponse.md)
 - [OpenapiClient::GeoBatchLog](docs/GeoBatchLog.md)
 - [OpenapiClient::GeoBatchLogItem](docs/GeoBatchLogItem.md)
 - [OpenapiClient::GeoBatchStatus](docs/GeoBatchStatus.md)
 - [OpenapiClient::GeoBatchSubmitFileResponse](docs/GeoBatchSubmitFileResponse.md)
 - [OpenapiClient::GeocodeRequest](docs/GeocodeRequest.md)
 - [OpenapiClient::GeocodeResult](docs/GeocodeResult.md)
 - [OpenapiClient::InlineObject](docs/InlineObject.md)
 - [OpenapiClient::Invoice](docs/Invoice.md)
 - [OpenapiClient::InvoiceResult](docs/InvoiceResult.md)
 - [OpenapiClient::KeyValuePair](docs/KeyValuePair.md)
 - [OpenapiClient::LineItem](docs/LineItem.md)
 - [OpenapiClient::LineItemResult](docs/LineItemResult.md)
 - [OpenapiClient::Location](docs/Location.md)
 - [OpenapiClient::LocationItem](docs/LocationItem.md)
 - [OpenapiClient::NexusConfig](docs/NexusConfig.md)
 - [OpenapiClient::OverrideConfig](docs/OverrideConfig.md)
 - [OpenapiClient::PCodeLookupRequest](docs/PCodeLookupRequest.md)
 - [OpenapiClient::PCodeLookupResult](docs/PCodeLookupResult.md)
 - [OpenapiClient::ReportingInformation](docs/ReportingInformation.md)
 - [OpenapiClient::RequestConfig](docs/RequestConfig.md)
 - [OpenapiClient::SafeHarborOverride](docs/SafeHarborOverride.md)
 - [OpenapiClient::ServiceInfo](docs/ServiceInfo.md)
 - [OpenapiClient::SetTaxCalculationSettingRequest](docs/SetTaxCalculationSettingRequest.md)
 - [OpenapiClient::Status](docs/Status.md)
 - [OpenapiClient::SummarizedTax](docs/SummarizedTax.md)
 - [OpenapiClient::TSPairData](docs/TSPairData.md)
 - [OpenapiClient::Tax](docs/Tax.md)
 - [OpenapiClient::TaxBracket](docs/TaxBracket.md)
 - [OpenapiClient::TaxCalculationSettingTypes](docs/TaxCalculationSettingTypes.md)
 - [OpenapiClient::TaxCalculationSettingsResponse](docs/TaxCalculationSettingsResponse.md)
 - [OpenapiClient::TaxExemption](docs/TaxExemption.md)
 - [OpenapiClient::TaxOverride](docs/TaxOverride.md)
 - [OpenapiClient::TaxTypeData](docs/TaxTypeData.md)
 - [OpenapiClient::TrafficStudyOverride](docs/TrafficStudyOverride.md)
 - [OpenapiClient::VersionInfo](docs/VersionInfo.md)
 - [OpenapiClient::Warning](docs/Warning.md)


## Documentation for Authorization


### Basic

