# Com.RusticiSoftware.Cloud.V2.Model.LaunchLinkRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expiry** | **int?** | Number of seconds from now this link will expire in. Defaults to 120s. Range 10s:300s | [optional] [default to 120]
**RedirectOnExitUrl** | **string** | The URL the application should redirect to when the learner exits a course. If not specified, configured value will be used. | [optional] 
**Tracking** | **bool?** | Should this launch be tracked? If false, Engine will avoid tracking to the extent possible for the standard being used. | [optional] [default to true]
**StartSco** | **string** | For SCORM, SCO identifier to override launch, overriding the normal sequencing. | [optional] 
**Culture** | **string** | This parameter should specify a culture code. If specified, and supported, the navigation and alerts in the player will be displayed in the associated language. If not specified, the locale of the user’s browser will be used. | [optional] 
**CssUrl** | **string** | A Url pointing to custom css for the player to use. | [optional] 
**LearnerTags** | **List&lt;string&gt;** |  | [optional] 
**CourseTags** | **List&lt;string&gt;** |  | [optional] 
**RegistrationTags** | **List&lt;string&gt;** |  | [optional] 
**Additionalvalues** | [**List&lt;ItemValuePairSchema&gt;**](ItemValuePairSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

