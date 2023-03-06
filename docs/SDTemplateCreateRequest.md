# Stardust.CoreSDK.Model.SDTemplateCreateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the template (ex. Bronze Axe) | 
**Cap** | **string** | u96 Number as String (ex. 200000000)  | 
**ContractType** | **string** | The type of custom contract to use for this template. Default will use a shared contract. | [optional] 
**Type** | **string** | FT is a currency where every instance is the same, NFT is where every token instance differes (ex. FT) | 
**OwnerAddress** | **string** | Blockchain address to set as owner of the custom contract. Required if contractType is set. | [optional] 
**Props** | [**SDTemplateCreateRequestProps**](SDTemplateCreateRequestProps.md) |  | 
**PublicContractMetadata** | **Object** | Returned to marketplaces as contract metadata | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

