# Com.RusticiSoftware.Cloud.V2.Api.ApplicationManagementApi

All URIs are relative to *https://cloud.scorm.com/api/v2/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateApplication**](ApplicationManagementApi.md#createapplication) | **PUT** /appManagement/applications/{applicationName} | Create a new application
[**CreateCredential**](ApplicationManagementApi.md#createcredential) | **POST** /appManagement/{childAppId}/credentials | Create credential
[**CreateToken**](ApplicationManagementApi.md#createtoken) | **POST** /appManagement/token | Create token
[**DeleteApplication**](ApplicationManagementApi.md#deleteapplication) | **DELETE** /appManagement/applications/{childAppId} | Delete an application.  If the application contains content, it must first be manually removed before calling this method, else an error will be thrown.
[**DeleteCredential**](ApplicationManagementApi.md#deletecredential) | **DELETE** /appManagement/{childAppId}/credentials/{credentialId} | Removes &#x60;credentialId&#x60; credentials
[**GetApplicationConfiguration**](ApplicationManagementApi.md#getapplicationconfiguration) | **GET** /appManagement/configuration | Returns all configuration settings for this level
[**GetApplicationList**](ApplicationManagementApi.md#getapplicationlist) | **GET** /appManagement/applications | Get list of all applications in this realm.
[**GetCredentials**](ApplicationManagementApi.md#getcredentials) | **GET** /appManagement/{childAppId}/credentials | List of credentials
[**SetApplicationConfiguration**](ApplicationManagementApi.md#setapplicationconfiguration) | **POST** /appManagement/configuration | Set configuration settings for this level.
[**UpdateCredential**](ApplicationManagementApi.md#updatecredential) | **PUT** /appManagement/{childAppId}/credentials/{credentialId} | Update the name or status associated with &#x60;credentialId&#x60;


<a name="createapplication"></a>
# **CreateApplication**
> ApplicationSchema CreateApplication (string applicationName)

Create a new application

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var applicationName = applicationName_example;  // string | 

            try
            {
                // Create a new application
                ApplicationSchema result = apiInstance.CreateApplication(applicationName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.CreateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationName** | **string**|  | 

### Return type

[**ApplicationSchema**](ApplicationSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcredential"></a>
# **CreateCredential**
> CredentialCreatedSchema CreateCredential (string childAppId, CredentialRequestSchema credentialRequest)

Create credential

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateCredentialExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var childAppId = childAppId_example;  // string | 
            var credentialRequest = new CredentialRequestSchema(); // CredentialRequestSchema | 

            try
            {
                // Create credential
                CredentialCreatedSchema result = apiInstance.CreateCredential(childAppId, credentialRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.CreateCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAppId** | **string**|  | 
 **credentialRequest** | [**CredentialRequestSchema**](CredentialRequestSchema.md)|  | 

### Return type

[**CredentialCreatedSchema**](CredentialCreatedSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtoken"></a>
# **CreateToken**
> StringResultSchema CreateToken (TokenRequestSchema tokenRequest)

Create token

Creates, signs and returns a token based on the provided permissions, if the credentials used to request the token have the permissions being requested. Note: the token is not stored and therefore can not be modified or deleted. The requested permissions are encoded in the token which is then signed. As long as the secret used to create it is not changed the token will be valid until it expires.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateTokenExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApplicationManagementApi();
            var tokenRequest = new TokenRequestSchema(); // TokenRequestSchema | 

            try
            {
                // Create token
                StringResultSchema result = apiInstance.CreateToken(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.CreateToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRequest** | [**TokenRequestSchema**](TokenRequestSchema.md)|  | 

### Return type

[**StringResultSchema**](StringResultSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapplication"></a>
# **DeleteApplication**
> void DeleteApplication (string childAppId)

Delete an application.  If the application contains content, it must first be manually removed before calling this method, else an error will be thrown.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteApplicationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var childAppId = childAppId_example;  // string | 

            try
            {
                // Delete an application.  If the application contains content, it must first be manually removed before calling this method, else an error will be thrown.
                apiInstance.DeleteApplication(childAppId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.DeleteApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAppId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecredential"></a>
# **DeleteCredential**
> void DeleteCredential (string childAppId, string credentialId)

Removes `credentialId` credentials

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteCredentialExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var childAppId = childAppId_example;  // string | 
            var credentialId = credentialId_example;  // string | 

            try
            {
                // Removes `credentialId` credentials
                apiInstance.DeleteCredential(childAppId, credentialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.DeleteCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAppId** | **string**|  | 
 **credentialId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationconfiguration"></a>
# **GetApplicationConfiguration**
> SettingListSchema GetApplicationConfiguration (string learningStandard = null, bool? singleSco = null, bool? includeMetadata = null)

Returns all configuration settings for this level

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetApplicationConfigurationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var learningStandard = learningStandard_example;  // string | If specified, the request will be scoped to the provided learning standard. (optional) 
            var singleSco = true;  // bool? | Required if learningStandard is specified. Scopes settings to whether a package has only one SCO or assignable unit within it or not. To apply a configuration setting to a learning standard for single and multi-SCO content, it must be set for both scopes. (optional) 
            var includeMetadata = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Returns all configuration settings for this level
                SettingListSchema result = apiInstance.GetApplicationConfiguration(learningStandard, singleSco, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.GetApplicationConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **learningStandard** | **string**| If specified, the request will be scoped to the provided learning standard. | [optional] 
 **singleSco** | **bool?**| Required if learningStandard is specified. Scopes settings to whether a package has only one SCO or assignable unit within it or not. To apply a configuration setting to a learning standard for single and multi-SCO content, it must be set for both scopes. | [optional] 
 **includeMetadata** | **bool?**|  | [optional] [default to false]

### Return type

[**SettingListSchema**](SettingListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationlist"></a>
# **GetApplicationList**
> ApplicationListSchema GetApplicationList ()

Get list of all applications in this realm.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetApplicationListExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();

            try
            {
                // Get list of all applications in this realm.
                ApplicationListSchema result = apiInstance.GetApplicationList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.GetApplicationList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApplicationListSchema**](ApplicationListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredentials"></a>
# **GetCredentials**
> CredentialListSchema GetCredentials (string childAppId)

List of credentials

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCredentialsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var childAppId = childAppId_example;  // string | 

            try
            {
                // List of credentials
                CredentialListSchema result = apiInstance.GetCredentials(childAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.GetCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAppId** | **string**|  | 

### Return type

[**CredentialListSchema**](CredentialListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setapplicationconfiguration"></a>
# **SetApplicationConfiguration**
> void SetApplicationConfiguration (SettingsPostSchema configurationSettings, string learningStandard = null, bool? singleSco = null)

Set configuration settings for this level.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class SetApplicationConfigurationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var configurationSettings = new SettingsPostSchema(); // SettingsPostSchema | 
            var learningStandard = learningStandard_example;  // string | If specified, the request will be scoped to the provided learning standard. (optional) 
            var singleSco = true;  // bool? | Required if learningStandard is specified. Scopes settings to whether a package has only one SCO or assignable unit within it or not. To apply a configuration setting to a learning standard for single and multi-SCO content, it must be set for both scopes. (optional) 

            try
            {
                // Set configuration settings for this level.
                apiInstance.SetApplicationConfiguration(configurationSettings, learningStandard, singleSco);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.SetApplicationConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **configurationSettings** | [**SettingsPostSchema**](SettingsPostSchema.md)|  | 
 **learningStandard** | **string**| If specified, the request will be scoped to the provided learning standard. | [optional] 
 **singleSco** | **bool?**| Required if learningStandard is specified. Scopes settings to whether a package has only one SCO or assignable unit within it or not. To apply a configuration setting to a learning standard for single and multi-SCO content, it must be set for both scopes. | [optional] 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecredential"></a>
# **UpdateCredential**
> void UpdateCredential (string childAppId, string credentialId, CredentialRequestSchema credentialUpdate)

Update the name or status associated with `credentialId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class UpdateCredentialExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationManagementApi();
            var childAppId = childAppId_example;  // string | 
            var credentialId = credentialId_example;  // string | 
            var credentialUpdate = new CredentialRequestSchema(); // CredentialRequestSchema | 

            try
            {
                // Update the name or status associated with `credentialId`
                apiInstance.UpdateCredential(childAppId, credentialId, credentialUpdate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationManagementApi.UpdateCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAppId** | **string**|  | 
 **credentialId** | **string**|  | 
 **credentialUpdate** | [**CredentialRequestSchema**](CredentialRequestSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

