# Com.RusticiSoftware.Cloud.V2.Api.PingApi

All URIs are relative to *https://cloud.scorm.com/api/v2/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PingAppId**](PingApi.md#pingappid) | **GET** /ping | Get back a message indicating that the API is working.


<a name="pingappid"></a>
# **PingAppId**
> PingSchema PingAppId ()

Get back a message indicating that the API is working.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class PingAppIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PingApi();

            try
            {
                // Get back a message indicating that the API is working.
                PingSchema result = apiInstance.PingAppId();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PingApi.PingAppId: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PingSchema**](PingSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

