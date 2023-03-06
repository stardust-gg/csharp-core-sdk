# Stardust.CoreSDK.Model.SDTemplateGetResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GameId** | **int?** | Game ID Number (unsigned 32 bit integer) | 
**Id** | **int?** |  | 
**Cap** | **string** | u96 Number as String, min: 0, max: 39614081257132168796771975167 | 
**ContractType** | **string** | The type of custom contract bieng used for this template. | [optional] 
**TotalSupply** | **string** | u96 Number as String, min: 0, max: 39614081257132168796771975167 | 
**Name** | **string** | The name of the template | 
**Type** | **string** |  | 
**Props** | [**SDTemplateGetAllResponseProps**](SDTemplateGetAllResponseProps.md) |  | 
**PublicContractMetadata** | **Object** | Returned to marketplaces as contract metadata | [optional] 
**PublicTokenMetadata** | **Object** | Inherited by tokens, and returned to marketplaces as token metadata | [optional] 
**Fees** | [**List&lt;SDGameGetResponseFees&gt;**](SDGameGetResponseFees.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

