# Stardust.CoreSDK.Model.SDTemplateCreateBulk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the template (ex. Bronze Axe) | 
**Cap** | **string** | u96 Number as String (ex. 200000000), default 39614081257132168796771975168  | [optional] 
**ContractType** | **string** | The type of custom contract to use for this template. Default will use a shared contract. | [optional] 
**Type** | **string** | FT is a currency where every instance is the same, NFT is where every token instance differes (ex. FT) | [optional] 
**Image** | **string** | image url | 
**Description** | **string** | Description of template | [optional] 
**ActiveListing** | **bool?** | Set if the Template is active or not | [optional] 
**OwnerAddress** | **string** | Blockchain address to set as owner of the custom contract, if contractType is passed in. | [optional] 
**Props** | [**SDTemplateCreateBulkProps**](SDTemplateCreateBulkProps.md) |  | [optional] 
**PublicContractMetadata** | **Object** | Returned to marketplaces as contract metadata | [optional] 
**PublicTokenMetadata** | **Object** | Inherited by tokens, and returned to marketplaces as token metadata | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

