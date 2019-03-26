# Com.RusticiSoftware.Cloud.V2.Api.CourseApi

All URIs are relative to *https://cloud.scorm.com/api/v2/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuildCoursePreviewLaunchLink**](CourseApi.md#buildcoursepreviewlaunchlink) | **POST** /courses/{courseId}/preview | Returns the launch link to use to preview this course
[**BuildCoursePreviewLaunchLinkWithVersion**](CourseApi.md#buildcoursepreviewlaunchlinkwithversion) | **POST** /courses/{courseId}/versions/{versionId}/preview | Returns the link to use to preview this course
[**CreateFetchAndImportCourseJob**](CourseApi.md#createfetchandimportcoursejob) | **POST** /courses/importJobs | Start a job to fetch and import a course.
[**CreateUploadAndImportCourseJob**](CourseApi.md#createuploadandimportcoursejob) | **POST** /courses/importJobs/upload | Upload a course and start an import job for it.
[**DeleteCourse**](CourseApi.md#deletecourse) | **DELETE** /courses/{courseId} | Delete &#x60;courseId&#x60;
[**DeleteCourseConfigurationSetting**](CourseApi.md#deletecourseconfigurationsetting) | **DELETE** /courses/{courseId}/configuration/{settingId} | Clears the &#x60;settingId&#x60; value for this course
[**DeleteCourseTags**](CourseApi.md#deletecoursetags) | **DELETE** /courses/{courseId}/tags | Delete tags for this course
[**DeleteCourseVersion**](CourseApi.md#deletecourseversion) | **DELETE** /courses/{courseId}/versions/{versionId} | Delete version &#x60;versionId&#x60; of &#x60;courseId&#x60;
[**DeleteCourseVersionConfigurationSetting**](CourseApi.md#deletecourseversionconfigurationsetting) | **DELETE** /courses/{courseId}/versions/{versionId}/configuration/{settingId} | Clears the &#x60;settingId&#x60; value for this course and version.
[**GetCourse**](CourseApi.md#getcourse) | **GET** /courses/{courseId} | Get information about &#x60;courseId&#x60;
[**GetCourseConfiguration**](CourseApi.md#getcourseconfiguration) | **GET** /courses/{courseId}/configuration | Returns all configuration settings for this course
[**GetCourseStatements**](CourseApi.md#getcoursestatements) | **GET** /courses/{courseId}/xAPIStatements | Get xAPI statements for &#x60;courseId&#x60;
[**GetCourseTags**](CourseApi.md#getcoursetags) | **GET** /courses/{courseId}/tags | Get the tags for this course
[**GetCourseVersionConfiguration**](CourseApi.md#getcourseversionconfiguration) | **GET** /courses/{courseId}/versions/{versionId}/configuration | Returns all configuration settings for this course and version.
[**GetCourseVersionInfo**](CourseApi.md#getcourseversioninfo) | **GET** /courses/{courseId}/versions/{versionId} | Get version &#x60;versionId&#x60; of &#x60;courseId&#x60;
[**GetCourseVersionStatements**](CourseApi.md#getcourseversionstatements) | **GET** /courses/{courseId}/versions/{versionId}/xAPIStatements | Get xAPI statements for version &#x60;versionId&#x60; of &#x60;courseId&#x60;
[**GetCourseVersions**](CourseApi.md#getcourseversions) | **GET** /courses/{courseId}/versions | Get all versions of &#x60;courseId&#x60;
[**GetCourses**](CourseApi.md#getcourses) | **GET** /courses | Get all courses for &#x60;appId&#x60;
[**GetImportJobStatus**](CourseApi.md#getimportjobstatus) | **GET** /courses/importJobs/{importJobId} | Check the status of an import job.
[**PutCourseTags**](CourseApi.md#putcoursetags) | **PUT** /courses/{courseId}/tags | Set the tags for this course
[**PutCourseTagsBatch**](CourseApi.md#putcoursetagsbatch) | **PUT** /courses/tags | Sets all of the provided tags on all of the provided courses
[**SetCourseConfiguration**](CourseApi.md#setcourseconfiguration) | **POST** /courses/{courseId}/configuration | Set configuration settings for this course.
[**SetCourseTitle**](CourseApi.md#setcoursetitle) | **PUT** /courses/{courseId}/title | Sets the course title for &#x60;courseId&#x60;
[**SetCourseVersionConfiguration**](CourseApi.md#setcourseversionconfiguration) | **POST** /courses/{courseId}/versions/{versionId}/configuration | Set configuration settings for this course and version.


<a name="buildcoursepreviewlaunchlink"></a>
# **BuildCoursePreviewLaunchLink**
> LaunchLinkSchema BuildCoursePreviewLaunchLink (string courseId, LaunchLinkRequestSchema launchLinkRequest, string cssUrl = null)

Returns the launch link to use to preview this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class BuildCoursePreviewLaunchLinkExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var launchLinkRequest = new LaunchLinkRequestSchema(); // LaunchLinkRequestSchema | 
            var cssUrl = cssUrl_example;  // string |  (optional) 

            try
            {
                // Returns the launch link to use to preview this course
                LaunchLinkSchema result = apiInstance.BuildCoursePreviewLaunchLink(courseId, launchLinkRequest, cssUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.BuildCoursePreviewLaunchLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **launchLinkRequest** | [**LaunchLinkRequestSchema**](LaunchLinkRequestSchema.md)|  | 
 **cssUrl** | **string**|  | [optional] 

### Return type

[**LaunchLinkSchema**](LaunchLinkSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildcoursepreviewlaunchlinkwithversion"></a>
# **BuildCoursePreviewLaunchLinkWithVersion**
> LaunchLinkSchema BuildCoursePreviewLaunchLinkWithVersion (string courseId, int? versionId, LaunchLinkRequestSchema launchLinkRequest)

Returns the link to use to preview this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class BuildCoursePreviewLaunchLinkWithVersionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version
            var launchLinkRequest = new LaunchLinkRequestSchema(); // LaunchLinkRequestSchema | 

            try
            {
                // Returns the link to use to preview this course
                LaunchLinkSchema result = apiInstance.BuildCoursePreviewLaunchLinkWithVersion(courseId, versionId, launchLinkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.BuildCoursePreviewLaunchLinkWithVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 
 **launchLinkRequest** | [**LaunchLinkRequestSchema**](LaunchLinkRequestSchema.md)|  | 

### Return type

[**LaunchLinkSchema**](LaunchLinkSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfetchandimportcoursejob"></a>
# **CreateFetchAndImportCourseJob**
> StringResultSchema CreateFetchAndImportCourseJob (string courseId, ImportFetchRequestSchema importRequest, bool? mayCreateNewVersion = null, string postbackUrl = null)

Start a job to fetch and import a course.

An import job will be started to fetch and import the referenced file, and the import job ID will be returned. If the import is successful, the imported course will be registered using the courseId provided.\"

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateFetchAndImportCourseJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | A unique identifier your application will use to identify the course after import. Your application is responsible both for generating this unique ID and for keeping track of the ID for later use.
            var importRequest = new ImportFetchRequestSchema(); // ImportFetchRequestSchema | 
            var mayCreateNewVersion = true;  // bool? | Is it OK to create a new version of this course? If this is set to false and the course already exists, the upload will fail. If true and the course already exists then a new version will be created. No effect if the course doesn't already exist. (optional)  (default to false)
            var postbackUrl = postbackUrl_example;  // string | An optional parameter that specifies a URL to send a postback to when the course has finished uploading. (optional) 

            try
            {
                // Start a job to fetch and import a course.
                StringResultSchema result = apiInstance.CreateFetchAndImportCourseJob(courseId, importRequest, mayCreateNewVersion, postbackUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.CreateFetchAndImportCourseJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**| A unique identifier your application will use to identify the course after import. Your application is responsible both for generating this unique ID and for keeping track of the ID for later use. | 
 **importRequest** | [**ImportFetchRequestSchema**](ImportFetchRequestSchema.md)|  | 
 **mayCreateNewVersion** | **bool?**| Is it OK to create a new version of this course? If this is set to false and the course already exists, the upload will fail. If true and the course already exists then a new version will be created. No effect if the course doesn&#39;t already exist. | [optional] [default to false]
 **postbackUrl** | **string**| An optional parameter that specifies a URL to send a postback to when the course has finished uploading. | [optional] 

### Return type

[**StringResultSchema**](StringResultSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuploadandimportcoursejob"></a>
# **CreateUploadAndImportCourseJob**
> StringResultSchema CreateUploadAndImportCourseJob (string courseId, bool? mayCreateNewVersion = null, System.IO.Stream file = null, string postbackUrl = null)

Upload a course and start an import job for it.

An import job will be started to import the posted file, and the import job ID will be returned. If the import is successful, the imported course will be registered using the courseId provided.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class CreateUploadAndImportCourseJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | A unique identifier your application will use to identify the course after import. Your application is responsible both for generating this unique ID and for keeping track of the ID for later use.
            var mayCreateNewVersion = true;  // bool? | Is it OK to create a new version of this course? If this is set to false and the course already exists, the upload will fail. If true and the course already exists then a new version will be created. No effect if the course doesn't already exist. (optional)  (default to false)
            var file = new System.IO.Stream(); // System.IO.Stream | The zip file of the course contents to import. (optional) 
            var postbackUrl = postbackUrl_example;  // string | An optional parameter that specifies a URL to send a postback to when the course has finished uploading. (optional) 

            try
            {
                // Upload a course and start an import job for it.
                StringResultSchema result = apiInstance.CreateUploadAndImportCourseJob(courseId, mayCreateNewVersion, file, postbackUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.CreateUploadAndImportCourseJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**| A unique identifier your application will use to identify the course after import. Your application is responsible both for generating this unique ID and for keeping track of the ID for later use. | 
 **mayCreateNewVersion** | **bool?**| Is it OK to create a new version of this course? If this is set to false and the course already exists, the upload will fail. If true and the course already exists then a new version will be created. No effect if the course doesn&#39;t already exist. | [optional] [default to false]
 **file** | **System.IO.Stream**| The zip file of the course contents to import. | [optional] 
 **postbackUrl** | **string**| An optional parameter that specifies a URL to send a postback to when the course has finished uploading. | [optional] 

### Return type

[**StringResultSchema**](StringResultSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecourse"></a>
# **DeleteCourse**
> void DeleteCourse (string courseId)

Delete `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteCourseExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 

            try
            {
                // Delete `courseId`
                apiInstance.DeleteCourse(courseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.DeleteCourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecourseconfigurationsetting"></a>
# **DeleteCourseConfigurationSetting**
> void DeleteCourseConfigurationSetting (string courseId, string settingId)

Clears the `settingId` value for this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteCourseConfigurationSettingExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var settingId = settingId_example;  // string | 

            try
            {
                // Clears the `settingId` value for this course
                apiInstance.DeleteCourseConfigurationSetting(courseId, settingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.DeleteCourseConfigurationSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **settingId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecoursetags"></a>
# **DeleteCourseTags**
> void DeleteCourseTags (string courseId, TagListSchema tags)

Delete tags for this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteCourseTagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var tags = new TagListSchema(); // TagListSchema | 

            try
            {
                // Delete tags for this course
                apiInstance.DeleteCourseTags(courseId, tags);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.DeleteCourseTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **tags** | [**TagListSchema**](TagListSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecourseversion"></a>
# **DeleteCourseVersion**
> void DeleteCourseVersion (string courseId, int? versionId)

Delete version `versionId` of `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteCourseVersionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version

            try
            {
                // Delete version `versionId` of `courseId`
                apiInstance.DeleteCourseVersion(courseId, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.DeleteCourseVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecourseversionconfigurationsetting"></a>
# **DeleteCourseVersionConfigurationSetting**
> void DeleteCourseVersionConfigurationSetting (string courseId, int? versionId, string settingId)

Clears the `settingId` value for this course and version.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class DeleteCourseVersionConfigurationSettingExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version
            var settingId = settingId_example;  // string | 

            try
            {
                // Clears the `settingId` value for this course and version.
                apiInstance.DeleteCourseVersionConfigurationSetting(courseId, versionId, settingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.DeleteCourseVersionConfigurationSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 
 **settingId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourse"></a>
# **GetCourse**
> CourseSchema GetCourse (string courseId, bool? includeRegistrationCount = null, bool? includeCourseMetadata = null)

Get information about `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var includeRegistrationCount = true;  // bool? | Include the registration count in the results (optional)  (default to false)
            var includeCourseMetadata = true;  // bool? | Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. (optional)  (default to false)

            try
            {
                // Get information about `courseId`
                CourseSchema result = apiInstance.GetCourse(courseId, includeRegistrationCount, includeCourseMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **includeRegistrationCount** | **bool?**| Include the registration count in the results | [optional] [default to false]
 **includeCourseMetadata** | **bool?**| Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. | [optional] [default to false]

### Return type

[**CourseSchema**](CourseSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourseconfiguration"></a>
# **GetCourseConfiguration**
> SettingListSchema GetCourseConfiguration (string courseId, bool? includeMetadata = null)

Returns all configuration settings for this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseConfigurationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var includeMetadata = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Returns all configuration settings for this course
                SettingListSchema result = apiInstance.GetCourseConfiguration(courseId, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **includeMetadata** | **bool?**|  | [optional] [default to false]

### Return type

[**SettingListSchema**](SettingListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoursestatements"></a>
# **GetCourseStatements**
> XapiStatementResult GetCourseStatements (string courseId, string learnerId = null, DateTime? since = null, DateTime? until = null, string more = null)

Get xAPI statements for `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseStatementsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var learnerId = learnerId_example;  // string | Only entries for the specified learner id will be included. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 

            try
            {
                // Get xAPI statements for `courseId`
                XapiStatementResult result = apiInstance.GetCourseStatements(courseId, learnerId, since, until, more);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseStatements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **learnerId** | **string**| Only entries for the specified learner id will be included. | [optional] 
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

<a name="getcoursetags"></a>
# **GetCourseTags**
> TagListSchema GetCourseTags (string courseId)

Get the tags for this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseTagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 

            try
            {
                // Get the tags for this course
                TagListSchema result = apiInstance.GetCourseTags(courseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 

### Return type

[**TagListSchema**](TagListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourseversionconfiguration"></a>
# **GetCourseVersionConfiguration**
> SettingListSchema GetCourseVersionConfiguration (string courseId, int? versionId, bool? includeMetadata = null)

Returns all configuration settings for this course and version.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseVersionConfigurationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version
            var includeMetadata = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Returns all configuration settings for this course and version.
                SettingListSchema result = apiInstance.GetCourseVersionConfiguration(courseId, versionId, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseVersionConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 
 **includeMetadata** | **bool?**|  | [optional] [default to false]

### Return type

[**SettingListSchema**](SettingListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourseversioninfo"></a>
# **GetCourseVersionInfo**
> CourseSchema GetCourseVersionInfo (string courseId, int? versionId, bool? includeRegistrationCount = null, bool? includeCourseMetadata = null)

Get version `versionId` of `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseVersionInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version
            var includeRegistrationCount = true;  // bool? | Include the registration count in the results (optional)  (default to false)
            var includeCourseMetadata = true;  // bool? | Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. (optional)  (default to false)

            try
            {
                // Get version `versionId` of `courseId`
                CourseSchema result = apiInstance.GetCourseVersionInfo(courseId, versionId, includeRegistrationCount, includeCourseMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseVersionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 
 **includeRegistrationCount** | **bool?**| Include the registration count in the results | [optional] [default to false]
 **includeCourseMetadata** | **bool?**| Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. | [optional] [default to false]

### Return type

[**CourseSchema**](CourseSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourseversionstatements"></a>
# **GetCourseVersionStatements**
> XapiStatementResult GetCourseVersionStatements (string courseId, int? versionId, string learnerId = null, DateTime? since = null, DateTime? until = null, string more = null)

Get xAPI statements for version `versionId` of `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseVersionStatementsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version
            var learnerId = learnerId_example;  // string | Only entries for the specified learner id will be included. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 

            try
            {
                // Get xAPI statements for version `versionId` of `courseId`
                XapiStatementResult result = apiInstance.GetCourseVersionStatements(courseId, versionId, learnerId, since, until, more);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseVersionStatements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 
 **learnerId** | **string**| Only entries for the specified learner id will be included. | [optional] 
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

<a name="getcourseversions"></a>
# **GetCourseVersions**
> CourseListNonPagedSchema GetCourseVersions (string courseId, DateTime? since = null, DateTime? until = null, bool? includeRegistrationCount = null, bool? includeCourseMetadata = null)

Get all versions of `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCourseVersionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var includeRegistrationCount = true;  // bool? | Include the registration count in the results (optional)  (default to false)
            var includeCourseMetadata = true;  // bool? | Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. (optional)  (default to false)

            try
            {
                // Get all versions of `courseId`
                CourseListNonPagedSchema result = apiInstance.GetCourseVersions(courseId, since, until, includeRegistrationCount, includeCourseMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourseVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **since** | **DateTime?**| Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **until** | **DateTime?**| Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **includeRegistrationCount** | **bool?**| Include the registration count in the results | [optional] [default to false]
 **includeCourseMetadata** | **bool?**| Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. | [optional] [default to false]

### Return type

[**CourseListNonPagedSchema**](CourseListNonPagedSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourses"></a>
# **GetCourses**
> CourseListSchema GetCourses (string more = null, DateTime? since = null, DateTime? until = null, string filter = null, string filterBy = null, string orderBy = null, bool? includeRegistrationCount = null, bool? includeCourseMetadata = null, List<string> tags = null)

Get all courses for `appId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetCoursesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var more = more_example;  // string | Value for this parameter will be provided in the 'more' property of registration lists, where needed. An opaque value, construction and parsing may change without notice. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. (optional) 
            var filter = filter_example;  // string | Optional string which filters results by a specified field (described by filterBy). (optional) 
            var filterBy = filterBy_example;  // string | Optional enum parameter for specifying the field on which to run the filter.  Defaults to course_id. (optional) 
            var orderBy = orderBy_example;  // string | Optional enum parameter for specifying the field and order by which to sort the results.  Defaults to creation_date_desc. (optional) 
            var includeRegistrationCount = true;  // bool? | Include the registration count in the results (optional)  (default to false)
            var includeCourseMetadata = true;  // bool? | Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. (optional)  (default to false)
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get all courses for `appId`
                CourseListSchema result = apiInstance.GetCourses(more, since, until, filter, filterBy, orderBy, includeRegistrationCount, includeCourseMetadata, tags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetCourses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **more** | **string**| Value for this parameter will be provided in the &#39;more&#39; property of registration lists, where needed. An opaque value, construction and parsing may change without notice. | [optional] 
 **since** | **DateTime?**| Only items updated since the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **until** | **DateTime?**| Only items updated before the specified ISO 8601 TimeStamp (inclusive) are included. If a time zone is not specified, UTC time zone will be used. | [optional] 
 **filter** | **string**| Optional string which filters results by a specified field (described by filterBy). | [optional] 
 **filterBy** | **string**| Optional enum parameter for specifying the field on which to run the filter.  Defaults to course_id. | [optional] 
 **orderBy** | **string**| Optional enum parameter for specifying the field and order by which to sort the results.  Defaults to creation_date_desc. | [optional] 
 **includeRegistrationCount** | **bool?**| Include the registration count in the results | [optional] [default to false]
 **includeCourseMetadata** | **bool?**| Include course metadata in the results. If the course has no metadata, adding this parameter has no effect. | [optional] [default to false]
 **tags** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**CourseListSchema**](CourseListSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimportjobstatus"></a>
# **GetImportJobStatus**
> ImportJobResultSchema GetImportJobStatus (string importJobId)

Check the status of an import job.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class GetImportJobStatusExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var importJobId = importJobId_example;  // string | Id received when the import job was submitted to the importJobs resource.

            try
            {
                // Check the status of an import job.
                ImportJobResultSchema result = apiInstance.GetImportJobStatus(importJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.GetImportJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importJobId** | **string**| Id received when the import job was submitted to the importJobs resource. | 

### Return type

[**ImportJobResultSchema**](ImportJobResultSchema.md)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcoursetags"></a>
# **PutCourseTags**
> void PutCourseTags (string courseId, TagListSchema tags)

Set the tags for this course

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class PutCourseTagsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var tags = new TagListSchema(); // TagListSchema | 

            try
            {
                // Set the tags for this course
                apiInstance.PutCourseTags(courseId, tags);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.PutCourseTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **tags** | [**TagListSchema**](TagListSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcoursetagsbatch"></a>
# **PutCourseTagsBatch**
> void PutCourseTagsBatch (CourseTagsBatchSchema batch)

Sets all of the provided tags on all of the provided courses

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class PutCourseTagsBatchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var batch = new CourseTagsBatchSchema(); // CourseTagsBatchSchema | 

            try
            {
                // Sets all of the provided tags on all of the provided courses
                apiInstance.PutCourseTagsBatch(batch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.PutCourseTagsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch** | [**CourseTagsBatchSchema**](CourseTagsBatchSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcourseconfiguration"></a>
# **SetCourseConfiguration**
> void SetCourseConfiguration (string courseId, SettingsPostSchema configurationSettings)

Set configuration settings for this course.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class SetCourseConfigurationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var configurationSettings = new SettingsPostSchema(); // SettingsPostSchema | 

            try
            {
                // Set configuration settings for this course.
                apiInstance.SetCourseConfiguration(courseId, configurationSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.SetCourseConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **configurationSettings** | [**SettingsPostSchema**](SettingsPostSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcoursetitle"></a>
# **SetCourseTitle**
> string SetCourseTitle (string courseId, TitleSchema title)

Sets the course title for `courseId`

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class SetCourseTitleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var title = new TitleSchema(); // TitleSchema | 

            try
            {
                // Sets the course title for `courseId`
                string result = apiInstance.SetCourseTitle(courseId, title);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.SetCourseTitle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **title** | [**TitleSchema**](TitleSchema.md)|  | 

### Return type

**string**

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcourseversionconfiguration"></a>
# **SetCourseVersionConfiguration**
> void SetCourseVersionConfiguration (string courseId, int? versionId, SettingsPostSchema configurationSettings)

Set configuration settings for this course and version.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Example
{
    public class SetCourseVersionConfigurationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAUTH
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseApi();
            var courseId = courseId_example;  // string | 
            var versionId = 56;  // int? | The course version
            var configurationSettings = new SettingsPostSchema(); // SettingsPostSchema | 

            try
            {
                // Set configuration settings for this course and version.
                apiInstance.SetCourseVersionConfiguration(courseId, versionId, configurationSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseApi.SetCourseVersionConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseId** | **string**|  | 
 **versionId** | **int?**| The course version | 
 **configurationSettings** | [**SettingsPostSchema**](SettingsPostSchema.md)|  | 

### Return type

void (empty response body)

### Authorization

[APP_NORMAL](../README.md#APP_NORMAL), [OAUTH](../README.md#OAUTH)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

