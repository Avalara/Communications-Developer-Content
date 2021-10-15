# avalara.comms.rest.v2 - php

The API requires Basic authentication.<br />
Users with access to multiple Clients must also set the request header parameter for <code>client_id</code>.<br />
Set <code>client_profile_id</code> to specify a profile to be used for taxation. The default profile is `0`. The default profile does not contain any customizations.<br />
<br />
Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation uses a minimum of TLS 1.2 encryption when making web requests to Avalara APIs.


## Installation & Usage

### Requirements

PHP 7.3 and later.
Should also work with PHP 8.0 but has not been tested.

### Composer

To install the bindings via [Composer](https://getcomposer.org/), add the following to `composer.json`:

```json
{
  "repositories": [
    {
      "type": "vcs",
      "url": "https://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
<?php
require_once('/path/to/avalara.comms.rest.v2/vendor/autoload.php');
```


## Using TLS 1.2 or higher
Avalara endpoints require a minimum of TLS 1.2. Enforcing TLS 1.2 is dependant on your PHP implementation. Please review https://www.php.net/manual/en/context.php

## Getting Started

1. Update the Username, Password, Client ID and Profile ID (optional) variables in `/lib/Demo.php`.
2. Run `php lib/Demo.php`

```php
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD')
              ->setHost('https://communicationsua.avalara.net');

// Set Client ID
$clientId = 0;
// Profile 0 = default profile (no customizations)
$profileId = 0;

```

## API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CustomizationApi* | [**apiV2ProfilesGetProfilesGet**](docs/Api/CustomizationApi.md#apiv2profilesgetprofilesget) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
*HealthCheckApi* | [**apiV2HealthCheckGet**](docs/Api/HealthCheckApi.md#apiv2healthcheckget) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use
*JurisdictionDeterminationApi* | [**apiV2AfcPCodePost**](docs/Api/JurisdictionDeterminationApi.md#apiv2afcpcodepost) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
*JurisdictionDeterminationApi* | [**apiV2GeoBatchLogProcessIdGet**](docs/Api/JurisdictionDeterminationApi.md#apiv2geobatchlogprocessidget) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
*JurisdictionDeterminationApi* | [**apiV2GeoBatchStatusProcessIdGet**](docs/Api/JurisdictionDeterminationApi.md#apiv2geobatchstatusprocessidget) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
*JurisdictionDeterminationApi* | [**apiV2GeoBatchUploadPost**](docs/Api/JurisdictionDeterminationApi.md#apiv2geobatchuploadpost) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
*JurisdictionDeterminationApi* | [**apiV2GeoGeocodePost**](docs/Api/JurisdictionDeterminationApi.md#apiv2geogeocodepost) | **POST** /api/v2/geo/Geocode | Geo-codes one or multiple street addresses and/or lat/long coordinate pairs.
*LookupsApi* | [**apiV2AfcLocationPCodeGet**](docs/Api/LookupsApi.md#apiv2afclocationpcodeget) | **GET** /api/v2/afc/location/{pCode} | Get location data associated with a PCode
*LookupsApi* | [**apiV2AfcPrimaryPCodeGet**](docs/Api/LookupsApi.md#apiv2afcprimarypcodeget) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
*LookupsApi* | [**apiV2AfcServiceinfoGet**](docs/Api/LookupsApi.md#apiv2afcserviceinfoget) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
*LookupsApi* | [**apiV2AfcTaxtypeTaxTypeGet**](docs/Api/LookupsApi.md#apiv2afctaxtypetaxtypeget) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
*LookupsApi* | [**apiV2AfcTspairsGet**](docs/Api/LookupsApi.md#apiv2afctspairsget) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information
*TaxCalculationApi* | [**apiV2AfcCalcTaxesPost**](docs/Api/TaxCalculationApi.md#apiv2afccalctaxespost) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
*TaxCalculationApi* | [**apiV2AfcCommitPost**](docs/Api/TaxCalculationApi.md#apiv2afccommitpost) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.

## Models

- [Address](docs/Model/Address.md)
- [BillingPeriod](docs/Model/BillingPeriod.md)
- [BundleConfig](docs/Model/BundleConfig.md)
- [BundleItem](docs/Model/BundleItem.md)
- [CalcTaxesRequest](docs/Model/CalcTaxesRequest.md)
- [CalcTaxesResponse](docs/Model/CalcTaxesResponse.md)
- [ClientProfileConfigResponse](docs/Model/ClientProfileConfigResponse.md)
- [ClientProfileConfigTypes](docs/Model/ClientProfileConfigTypes.md)
- [CommitRequest](docs/Model/CommitRequest.md)
- [CommitResponse](docs/Model/CommitResponse.md)
- [CompanyData](docs/Model/CompanyData.md)
- [Configuration](docs/Model/Configuration.md)
- [Error](docs/Model/Error.md)
- [Exclusion](docs/Model/Exclusion.md)
- [ExclusionConfig](docs/Model/ExclusionConfig.md)
- [GeoBatchDownloadResponse](docs/Model/GeoBatchDownloadResponse.md)
- [GeoBatchLog](docs/Model/GeoBatchLog.md)
- [GeoBatchLogItem](docs/Model/GeoBatchLogItem.md)
- [GeoBatchStatus](docs/Model/GeoBatchStatus.md)
- [GeoBatchSubmitFileResponse](docs/Model/GeoBatchSubmitFileResponse.md)
- [GeocodeRequest](docs/Model/GeocodeRequest.md)
- [GeocodeResult](docs/Model/GeocodeResult.md)
- [Invoice](docs/Model/Invoice.md)
- [InvoiceResult](docs/Model/InvoiceResult.md)
- [KeyValuePair](docs/Model/KeyValuePair.md)
- [LineItem](docs/Model/LineItem.md)
- [LineItemResult](docs/Model/LineItemResult.md)
- [Location](docs/Model/Location.md)
- [LocationItem](docs/Model/LocationItem.md)
- [NexusConfig](docs/Model/NexusConfig.md)
- [OverrideConfig](docs/Model/OverrideConfig.md)
- [PCodeLookupRequest](docs/Model/PCodeLookupRequest.md)
- [PCodeLookupResult](docs/Model/PCodeLookupResult.md)
- [ReportingInformation](docs/Model/ReportingInformation.md)
- [RequestConfig](docs/Model/RequestConfig.md)
- [SafeHarborOverride](docs/Model/SafeHarborOverride.md)
- [ServiceInfo](docs/Model/ServiceInfo.md)
- [Status](docs/Model/Status.md)
- [SummarizedTax](docs/Model/SummarizedTax.md)
- [Tax](docs/Model/Tax.md)
- [TaxBracket](docs/Model/TaxBracket.md)
- [TaxExemption](docs/Model/TaxExemption.md)
- [TaxOverride](docs/Model/TaxOverride.md)
- [TaxTypeData](docs/Model/TaxTypeData.md)
- [TrafficStudyOverride](docs/Model/TrafficStudyOverride.md)
- [TsPairData](docs/Model/TsPairData.md)
- [VersionInfo](docs/Model/VersionInfo.md)
- [Warning](docs/Model/Warning.md)

## Authorization

### Basic

- **Type**: HTTP basic authentication

## Tests

To run the tests, use:

```bash
composer install
vendor/bin/phpunit
```

## Author



## About this package

This PHP package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: `v2`
- Build package: `org.openapitools.codegen.languages.PhpClientCodegen`
