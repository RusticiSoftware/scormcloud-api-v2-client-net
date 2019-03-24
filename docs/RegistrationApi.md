# Com.RusticiSoftware.Cloud.V2.Api.RegistrationApi

All URIs are relative to *https://dev.cloud.scorm.com/api/v2/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewRegistrationInstance**](RegistrationApi.md#createnewregistrationinstance) | **POST** /registrations/{registrationId}/instances | Create a new instance for this registration specified by the registration ID
[**CreateRegistration**](RegistrationApi.md#createregistration) | **POST** /registrations | Create a registration.
[**DeleteRegistration**](RegistrationApi.md#deleteregistration) | **DELETE** /registrations/{registrationId} | Delete &#x60;registrationId&#x60;
[**DeleteRegistrationConfigurationSetting**](RegistrationApi.md#deleteregistrationconfigurationsetting) | **DELETE** /registrations/{registrationId}/configuration/{settingId} | Clears the &#x60;settingId&#x60; value for this registration
[**DeleteRegistrationInstanceConfigurationSetting**](RegistrationApi.md#deleteregistrationinstanceconfigurationsetting) | **DELETE** /registrations/{registrationId}/instances/{instanceId}/configuration/{settingId} | Clears the &#x60;settingId&#x60; value for this registration instance
[**DeleteRegistrationProgress**](RegistrationApi.md#deleteregistrationprogress) | **DELETE** /registrations/{registrationId}/progress | Delete registration progress (clear registration)
[**DeleteRegistrationsGlobalData**](RegistrationApi.md#deleteregistrationsglobaldata) | **DELETE** /registrations/{registrationId}/globalData | Delete global data associated with &#x60;registrationId&#x60;
[**GetRegistrationConfiguration**](RegistrationApi.md#getregistrationconfiguration) | **GET** /registrations/{registrationId}/configuration | Returns all configuration settings for this registration
[**GetRegistrationInstanceConfiguration**](RegistrationApi.md#getregistrationinstanceconfiguration) | **GET** /registrations/{registrationId}/instances/{instanceId}/configuration | Returns all configuration settings for this registration instance
[**GetRegistrationInstanceLaunchHistory**](RegistrationApi.md#getregistrationinstancelaunchhistory) | **GET** /registrations/{registrationId}/instances/{instanceId}/launchHistory | Returns history of this registration&#39;s launches
[**GetRegistrationInstanceProgress**](RegistrationApi.md#getregistrationinstanceprogress) | **GET** /registrations/{registrationId}/instances/{instanceId} | Get registration progress for instance &#x60;instanceId&#x60; of &#x60;registrationId&#x60;
[**GetRegistrationInstanceStatements**](RegistrationApi.md#getregistrationinstancestatements) | **GET** /registrations/{registrationId}/instances/{instanceId}/xAPIStatements | Get xAPI statements for instance &#x60;instanceId&#x60; of &#x60;registrationId&#x60;
[**GetRegistrationInstances**](RegistrationApi.md#getregistrationinstances) | **GET** /registrations/{registrationId}/instances | Get all the instances of this the registration specified by the registration ID
[**GetRegistrationLaunchHistory**](RegistrationApi.md#getregistrationlaunchhistory) | **GET** /registrations/{registrationId}/launchHistory | Returns history of this registration&#39;s launches
[**GetRegistrationLaunchLink**](RegistrationApi.md#getregistrationlaunchlink) | **POST** /registrations/{registrationId}/launchLink | Returns the link to use to launch this registration
[**GetRegistrationProgress**](RegistrationApi.md#getregistrationprogress) | **GET** /registrations/{registrationId} | Get registration progress for &#x60;registrationId&#x60;
[**GetRegistrationStatements**](RegistrationApi.md#getregistrationstatements) | **GET** /registrations/{registrationId}/xAPIStatements | Get xAPI statements for &#x60;registrationId&#x60;
[**GetRegistrations**](RegistrationApi.md#getregistrations) | **GET** /registrations | Gets a list of registrations including a summary of the status of each registration.
[**RegistrationExists**](RegistrationApi.md#registrationexists) | **HEAD** /registrations/{registrationId} | Does this registration exist?
[**SetRegistrationConfiguration**](RegistrationApi.md#setregistrationconfiguration) | **POST** /registrations/{registrationId}/configuration | Set configuration settings for this registration.
[**SetRegistrationInstanceConfiguration**](RegistrationApi.md#setregistrationinstanceconfiguration) | **POST** /registrations/{registrationId}/instances/{instanceId}/configuration | Set configuration settings for this registration instance.


<a name="createnewregistrationinstance"></a>
# **CreateNewRegistrationInstance**
> void CreateNewRegistrationInstance (string registrationId)

Create a new instance for this registration specified by the registration ID

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateNewRegistrationInstanceExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration

            try
            {
                // Create a new instance for this registration specified by the registration ID
                apiInstance.CreateNewRegistrationInstance(registrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.CreateNewRegistrationInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createregistration"></a>
# **CreateRegistration**
> void CreateRegistration (CreateRegistrationSchema registration, int? courseVersion = null)

Create a registration.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateRegistrationExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registration = new CreateRegistrationSchema(); // CreateRegistrationSchema | 
            var courseVersion = 56;  // int? | The version of the course you want to create the registration for. Unless you have a reason for using this you probably do not need to. (optional) 

            try
            {
                // Create a registration.
                apiInstance.CreateRegistration(registration, courseVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.CreateRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registration** | [**CreateRegistrationSchema**](CreateRegistrationSchema.md)|  | 
 **courseVersion** | **int?**| The version of the course you want to create the registration for. Unless you have a reason for using this you probably do not need to. | [optional] 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistration"></a>
# **DeleteRegistration**
> void DeleteRegistration (string registrationId)

Delete `registrationId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteRegistrationExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration

            try
            {
                // Delete `registrationId`
                apiInstance.DeleteRegistration(registrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.DeleteRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistrationconfigurationsetting"></a>
# **DeleteRegistrationConfigurationSetting**
> void DeleteRegistrationConfigurationSetting (string registrationId, string settingId)

Clears the `settingId` value for this registration

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteRegistrationConfigurationSettingExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var settingId = settingId_example;  // string | 

            try
            {
                // Clears the `settingId` value for this registration
                apiInstance.DeleteRegistrationConfigurationSetting(registrationId, settingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.DeleteRegistrationConfigurationSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **settingId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistrationinstanceconfigurationsetting"></a>
# **DeleteRegistrationInstanceConfigurationSetting**
> void DeleteRegistrationInstanceConfigurationSetting (string registrationId, int? instanceId, string settingId)

Clears the `settingId` value for this registration instance

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteRegistrationInstanceConfigurationSettingExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var instanceId = 56;  // int? | The instance of this registration
            var settingId = settingId_example;  // string | 

            try
            {
                // Clears the `settingId` value for this registration instance
                apiInstance.DeleteRegistrationInstanceConfigurationSetting(registrationId, instanceId, settingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.DeleteRegistrationInstanceConfigurationSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **instanceId** | **int?**| The instance of this registration | 
 **settingId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistrationprogress"></a>
# **DeleteRegistrationProgress**
> void DeleteRegistrationProgress (string registrationId)

Delete registration progress (clear registration)

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteRegistrationProgressExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration

            try
            {
                // Delete registration progress (clear registration)
                apiInstance.DeleteRegistrationProgress(registrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.DeleteRegistrationProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistrationsglobaldata"></a>
# **DeleteRegistrationsGlobalData**
> void DeleteRegistrationsGlobalData (string registrationId)

Delete global data associated with `registrationId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteRegistrationsGlobalDataExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration

            try
            {
                // Delete global data associated with `registrationId`
                apiInstance.DeleteRegistrationsGlobalData(registrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.DeleteRegistrationsGlobalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationconfiguration"></a>
# **GetRegistrationConfiguration**
> SettingListSchema GetRegistrationConfiguration (string registrationId, bool? includeMetadata = null)

Returns all configuration settings for this registration

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationConfigurationExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var includeMetadata = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Returns all configuration settings for this registration
                SettingListSchema result = apiInstance.GetRegistrationConfiguration(registrationId, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **includeMetadata** | **bool?**|  | [optional] [default to false]

### Return type

[**SettingListSchema**](SettingListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationinstanceconfiguration"></a>
# **GetRegistrationInstanceConfiguration**
> SettingListSchema GetRegistrationInstanceConfiguration (string registrationId, int? instanceId, bool? includeMetadata = null)

Returns all configuration settings for this registration instance

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationInstanceConfigurationExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var instanceId = 56;  // int? | The instance of this registration
            var includeMetadata = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Returns all configuration settings for this registration instance
                SettingListSchema result = apiInstance.GetRegistrationInstanceConfiguration(registrationId, instanceId, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationInstanceConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **instanceId** | **int?**| The instance of this registration | 
 **includeMetadata** | **bool?**|  | [optional] [default to false]

### Return type

[**SettingListSchema**](SettingListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationinstancelaunchhistory"></a>
# **GetRegistrationInstanceLaunchHistory**
> LaunchHistoryListSchema GetRegistrationInstanceLaunchHistory (string registrationId, int? instanceId, bool? includeHistoryLog = null)

Returns history of this registration's launches

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationInstanceLaunchHistoryExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var instanceId = 56;  // int? | The instance of this registration
            var includeHistoryLog = true;  // bool? | Whether to include the history log in the launch history (optional)  (default to false)

            try
            {
                // Returns history of this registration's launches
                LaunchHistoryListSchema result = apiInstance.GetRegistrationInstanceLaunchHistory(registrationId, instanceId, includeHistoryLog);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationInstanceLaunchHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **instanceId** | **int?**| The instance of this registration | 
 **includeHistoryLog** | **bool?**| Whether to include the history log in the launch history | [optional] [default to false]

### Return type

[**LaunchHistoryListSchema**](LaunchHistoryListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationinstanceprogress"></a>
# **GetRegistrationInstanceProgress**
> RegistrationSchema GetRegistrationInstanceProgress (string registrationId, int? instanceId, bool? includeChildResults = null, bool? includeInteractionsAndObjectives = null, bool? includeRuntime = null)

Get registration progress for instance `instanceId` of `registrationId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationInstanceProgressExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var instanceId = 56;  // int? | The instance of this registration
            var includeChildResults = true;  // bool? | Include information about each learning object, not just the top level in the results (optional)  (default to false)
            var includeInteractionsAndObjectives = true;  // bool? | Include interactions and objectives in the results (optional)  (default to false)
            var includeRuntime = true;  // bool? | Include runtime details in the results (optional)  (default to false)

            try
            {
                // Get registration progress for instance `instanceId` of `registrationId`
                RegistrationSchema result = apiInstance.GetRegistrationInstanceProgress(registrationId, instanceId, includeChildResults, includeInteractionsAndObjectives, includeRuntime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationInstanceProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **instanceId** | **int?**| The instance of this registration | 
 **includeChildResults** | **bool?**| Include information about each learning object, not just the top level in the results | [optional] [default to false]
 **includeInteractionsAndObjectives** | **bool?**| Include interactions and objectives in the results | [optional] [default to false]
 **includeRuntime** | **bool?**| Include runtime details in the results | [optional] [default to false]

### Return type

[**RegistrationSchema**](RegistrationSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationinstancestatements"></a>
# **GetRegistrationInstanceStatements**
> XapiStatementResult GetRegistrationInstanceStatements (string registrationId, int? instanceId, DateTime? since = null, DateTime? until = null, string more = null)

Get xAPI statements for instance `instanceId` of `registrationId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationInstanceStatementsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var instanceId = 56;  // int? | The instance of this registration
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 

            try
            {
                // Get xAPI statements for instance `instanceId` of `registrationId`
                XapiStatementResult result = apiInstance.GetRegistrationInstanceStatements(registrationId, instanceId, since, until, more);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationInstanceStatements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **instanceId** | **int?**| The instance of this registration | 
 **since** | **DateTime?**| Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **until** | **DateTime?**| Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **more** | **string**| Value for this parameter will be provided in the &#39;more&#39; property of registration lists, where needed. An opaque value, construction and parsing may change without notice. | [optional] 

### Return type

[**XapiStatementResult**](XapiStatementResult.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationinstances"></a>
# **GetRegistrationInstances**
> RegistrationListSchema GetRegistrationInstances (string registrationId, DateTime? until = null, DateTime? since = null, string more = null, bool? includeChildResults = null, bool? includeInteractionsAndObjectives = null, bool? includeRuntime = null)

Get all the instances of this the registration specified by the registration ID

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationInstancesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 
            var includeChildResults = true;  // bool? | Include information about each learning object, not just the top level in the results (optional)  (default to false)
            var includeInteractionsAndObjectives = true;  // bool? | Include interactions and objectives in the results (optional)  (default to false)
            var includeRuntime = true;  // bool? | Include runtime details in the results (optional)  (default to false)

            try
            {
                // Get all the instances of this the registration specified by the registration ID
                RegistrationListSchema result = apiInstance.GetRegistrationInstances(registrationId, until, since, more, includeChildResults, includeInteractionsAndObjectives, includeRuntime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **until** | **DateTime?**| Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **since** | **DateTime?**| Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **more** | **string**| Value for this parameter will be provided in the &#39;more&#39; property of registration lists, where needed. An opaque value, construction and parsing may change without notice. | [optional] 
 **includeChildResults** | **bool?**| Include information about each learning object, not just the top level in the results | [optional] [default to false]
 **includeInteractionsAndObjectives** | **bool?**| Include interactions and objectives in the results | [optional] [default to false]
 **includeRuntime** | **bool?**| Include runtime details in the results | [optional] [default to false]

### Return type

[**RegistrationListSchema**](RegistrationListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationlaunchhistory"></a>
# **GetRegistrationLaunchHistory**
> LaunchHistoryListSchema GetRegistrationLaunchHistory (string registrationId, bool? includeHistoryLog = null)

Returns history of this registration's launches

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationLaunchHistoryExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var includeHistoryLog = true;  // bool? | Whether to include the history log in the launch history (optional)  (default to false)

            try
            {
                // Returns history of this registration's launches
                LaunchHistoryListSchema result = apiInstance.GetRegistrationLaunchHistory(registrationId, includeHistoryLog);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationLaunchHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **includeHistoryLog** | **bool?**| Whether to include the history log in the launch history | [optional] [default to false]

### Return type

[**LaunchHistoryListSchema**](LaunchHistoryListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationlaunchlink"></a>
# **GetRegistrationLaunchLink**
> LaunchLinkSchema GetRegistrationLaunchLink (string registrationId, LaunchLinkRequestSchema launchLinkRequest)

Returns the link to use to launch this registration

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationLaunchLinkExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var launchLinkRequest = new LaunchLinkRequestSchema(); // LaunchLinkRequestSchema | 

            try
            {
                // Returns the link to use to launch this registration
                LaunchLinkSchema result = apiInstance.GetRegistrationLaunchLink(registrationId, launchLinkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationLaunchLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **launchLinkRequest** | [**LaunchLinkRequestSchema**](LaunchLinkRequestSchema.md)|  | 

### Return type

[**LaunchLinkSchema**](LaunchLinkSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationprogress"></a>
# **GetRegistrationProgress**
> RegistrationSchema GetRegistrationProgress (string registrationId, bool? includeChildResults = null, bool? includeInteractionsAndObjectives = null, bool? includeRuntime = null)

Get registration progress for `registrationId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationProgressExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var includeChildResults = true;  // bool? | Include information about each learning object, not just the top level in the results (optional)  (default to false)
            var includeInteractionsAndObjectives = true;  // bool? | Include interactions and objectives in the results (optional)  (default to false)
            var includeRuntime = true;  // bool? | Include runtime details in the results (optional)  (default to false)

            try
            {
                // Get registration progress for `registrationId`
                RegistrationSchema result = apiInstance.GetRegistrationProgress(registrationId, includeChildResults, includeInteractionsAndObjectives, includeRuntime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **includeChildResults** | **bool?**| Include information about each learning object, not just the top level in the results | [optional] [default to false]
 **includeInteractionsAndObjectives** | **bool?**| Include interactions and objectives in the results | [optional] [default to false]
 **includeRuntime** | **bool?**| Include runtime details in the results | [optional] [default to false]

### Return type

[**RegistrationSchema**](RegistrationSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationstatements"></a>
# **GetRegistrationStatements**
> XapiStatementResult GetRegistrationStatements (string registrationId, DateTime? since = null, DateTime? until = null, string more = null)

Get xAPI statements for `registrationId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationStatementsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 

            try
            {
                // Get xAPI statements for `registrationId`
                XapiStatementResult result = apiInstance.GetRegistrationStatements(registrationId, since, until, more);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrationStatements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **since** | **DateTime?**| Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **until** | **DateTime?**| Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **more** | **string**| Value for this parameter will be provided in the &#39;more&#39; property of registration lists, where needed. An opaque value, construction and parsing may change without notice. | [optional] 

### Return type

[**XapiStatementResult**](XapiStatementResult.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrations"></a>
# **GetRegistrations**
> RegistrationListSchema GetRegistrations (string courseId = null, string learnerId = null, DateTime? since = null, DateTime? until = null, string more = null, bool? includeChildResults = null, bool? includeInteractionsAndObjectives = null, bool? includeRuntime = null)

Gets a list of registrations including a summary of the status of each registration.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetRegistrationsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var courseId = courseId_example;  // string | Only registrations for the specified course id will be included. (optional) 
            var learnerId = learnerId_example;  // string | Only registrations for the specified learner id will be included. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 
            var includeChildResults = true;  // bool? | Include information about each learning object, not just the top level in the results (optional)  (default to false)
            var includeInteractionsAndObjectives = true;  // bool? | Include interactions and objectives in the results (optional)  (default to false)
            var includeRuntime = true;  // bool? | Include runtime details in the results (optional)  (default to false)

            try
            {
                // Gets a list of registrations including a summary of the status of each registration.
                RegistrationListSchema result = apiInstance.GetRegistrations(courseId, learnerId, since, until, more, includeChildResults, includeInteractionsAndObjectives, includeRuntime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistrations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**| Only registrations for the specified course id will be included. | [optional] 
 **learnerId** | **string**| Only registrations for the specified learner id will be included. | [optional] 
 **since** | **DateTime?**| Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **until** | **DateTime?**| Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **more** | **string**| Value for this parameter will be provided in the &#39;more&#39; property of registration lists, where needed. An opaque value, construction and parsing may change without notice. | [optional] 
 **includeChildResults** | **bool?**| Include information about each learning object, not just the top level in the results | [optional] [default to false]
 **includeInteractionsAndObjectives** | **bool?**| Include interactions and objectives in the results | [optional] [default to false]
 **includeRuntime** | **bool?**| Include runtime details in the results | [optional] [default to false]

### Return type

[**RegistrationListSchema**](RegistrationListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationexists"></a>
# **RegistrationExists**
> void RegistrationExists (string registrationId)

Does this registration exist?

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class RegistrationExistsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration

            try
            {
                // Does this registration exist?
                apiInstance.RegistrationExists(registrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.RegistrationExists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setregistrationconfiguration"></a>
# **SetRegistrationConfiguration**
> void SetRegistrationConfiguration (string registrationId, SettingsPostSchema configurationSettings)

Set configuration settings for this registration.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class SetRegistrationConfigurationExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var configurationSettings = new SettingsPostSchema(); // SettingsPostSchema | 

            try
            {
                // Set configuration settings for this registration.
                apiInstance.SetRegistrationConfiguration(registrationId, configurationSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.SetRegistrationConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **configurationSettings** | [**SettingsPostSchema**](SettingsPostSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setregistrationinstanceconfiguration"></a>
# **SetRegistrationInstanceConfiguration**
> void SetRegistrationInstanceConfiguration (string registrationId, int? instanceId, SettingsPostSchema configurationSettings)

Set configuration settings for this registration instance.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class SetRegistrationInstanceConfigurationExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var registrationId = registrationId_example;  // string | id for this registration
            var instanceId = 56;  // int? | The instance of this registration
            var configurationSettings = new SettingsPostSchema(); // SettingsPostSchema | 

            try
            {
                // Set configuration settings for this registration instance.
                apiInstance.SetRegistrationInstanceConfiguration(registrationId, instanceId, configurationSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.SetRegistrationInstanceConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| id for this registration | 
 **instanceId** | **int?**| The instance of this registration | 
 **configurationSettings** | [**SettingsPostSchema**](SettingsPostSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

