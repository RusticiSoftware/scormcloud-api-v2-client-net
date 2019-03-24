# Com.RusticiSoftware.Cloud.V2.Model.CreateRegistrationSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CourseId** | **string** |  | 
**Learner** | [**LearnerSchema**](LearnerSchema.md) |  | 
**RegistrationId** | **string** |  | 
**XapiRegistrationId** | **string** | The xapiRegistrationId to be associated with this registration. If not specified, the system will assign an xapiRegistrationId. As per the xApi specification, this must be a UUID. | [optional] 
**LearnerTags** | **List&lt;string&gt;** |  | [optional] 
**CourseTags** | **List&lt;string&gt;** |  | [optional] 
**RegistrationTags** | **List&lt;string&gt;** |  | [optional] 
**PostBack** | [**PostBackSchema**](PostBackSchema.md) | Specifies an optional override URL for which to post activity and status data in real time as the course is completed. By default all of these settings are read from your configuration. | [optional] 
**InitialRegistrationState** | [**RegistrationSchema**](RegistrationSchema.md) |  | [optional] 
**InitialSettings** | [**SettingsPostSchema**](SettingsPostSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

