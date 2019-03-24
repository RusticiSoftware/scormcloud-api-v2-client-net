# Com.RusticiSoftware.Cloud.V2.Api.AuthenticationApi

All URIs are relative to *https://dev.cloud.scorm.com/api/v2/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppToken**](AuthenticationApi.md#getapptoken) | **POST** /oauth/authenticate/application/token | Authenticates for a oauth token


<a name="getapptoken"></a>
# **GetAppToken**
> ApplicationToken GetAppToken (string scope, int? expiration = null)

Authenticates for a oauth token

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetAppTokenExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthenticationApi();
            var scope = scope_example;  // string | 
            var expiration = 56;  // int? |  (optional)  (default to 300)

            try
            {
                // Authenticates for a oauth token
                ApplicationToken result = apiInstance.GetAppToken(scope, expiration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetAppToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**|  | 
 **expiration** | **int?**|  | [optional] [default to 300]

### Return type

[**ApplicationToken**](ApplicationToken.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

