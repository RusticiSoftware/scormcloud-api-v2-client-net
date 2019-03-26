# Com.RusticiSoftware.Cloud.V2.Model.LaunchHistorySchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Instance** | **int?** |  | [optional] 
**Score** | [**ScoreSchema**](ScoreSchema.md) |  | [optional] 
**CompletionStatus** | **string** |  | [optional] [default to CompletionStatusEnum.UNKNOWN]
**SuccessStatus** | **string** |  | [optional] [default to SuccessStatusEnum.UNKNOWN]
**HistoryLog** | **string** |  | [optional] 
**TotalSecondsTracked** | **double?** |  | [optional] 
**LaunchTime** | **DateTime?** | The time of the launch in UTC | [optional] 
**ExitTime** | **DateTime?** | The time of the exit in UTC | [optional] 
**LastRuntimeUpdate** | **DateTime?** | The time of the last runtime update in UTC | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

