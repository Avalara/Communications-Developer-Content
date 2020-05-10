# avalara.comms.rest.v2.Api.CustomizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2ProfilesGetProfilesGet**](CustomizationApi.md#apiv2profilesgetprofilesget) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items


<a name="apiv2profilesgetprofilesget"></a>
# **ApiV2ProfilesGetProfilesGet**
> TaxCalculationSettingsResponse ApiV2ProfilesGetProfilesGet (int? requestedClientId = null, int? requestedProfileId = null, TaxCalculationSettingTypes itemType = null)

Retrieves one or more profiles with associated settings and configurable items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class ApiV2ProfilesGetProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomizationApi(config);
            var requestedClientId = 56;  // int? | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional) 
            var requestedProfileId = 56;  // int? | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional) 
            var itemType = new TaxCalculationSettingTypes(); // TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional) 

            try
            {
                // Retrieves one or more profiles with associated settings and configurable items
                TaxCalculationSettingsResponse result = apiInstance.ApiV2ProfilesGetProfilesGet(requestedClientId, requestedProfileId, itemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomizationApi.ApiV2ProfilesGetProfilesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestedClientId** | **int?**| Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. | [optional] 
 **requestedProfileId** | **int?**| Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. | [optional] 
 **itemType** | [**TaxCalculationSettingTypes**](TaxCalculationSettingTypes.md)| Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All | [optional] 

### Return type

[**TaxCalculationSettingsResponse**](TaxCalculationSettingsResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

