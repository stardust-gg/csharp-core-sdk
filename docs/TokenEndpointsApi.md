# Stardust.CoreSDK.Api.TokenEndpointsApi

All URIs are relative to *https://core-api.stardust.gg/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokenBurnPost**](TokenEndpointsApi.md#tokenburnpost) | **POST** /token/burn | Burn Token
[**TokenGetGet**](TokenEndpointsApi.md#tokengetget) | **GET** /token/get | Get Token
[**TokenMintBulkPost**](TokenEndpointsApi.md#tokenmintbulkpost) | **POST** /token/mint-bulk | Mint Tokens
[**TokenMutatePut**](TokenEndpointsApi.md#tokenmutateput) | **PUT** /token/mutate | Mutate Token
[**TokenPropsRemoveDelete**](TokenEndpointsApi.md#tokenpropsremovedelete) | **DELETE** /token/props-remove | Remove Token Property
[**TokenTransferPost**](TokenEndpointsApi.md#tokentransferpost) | **POST** /token/transfer | Transfer Tokens

<a name="tokenburnpost"></a>
# **TokenBurnPost**
> Empty TokenBurnPost (SDTokenBurnRequest body)

Burn Token

Burns token on-chain. Cannot be reversed.

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TokenBurnPostExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TokenEndpointsApi();
            var body = new SDTokenBurnRequest(); // SDTokenBurnRequest | 

            try
            {
                // Burn Token
                Empty result = apiInstance.TokenBurnPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenEndpointsApi.TokenBurnPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDTokenBurnRequest**](SDTokenBurnRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tokengetget"></a>
# **TokenGetGet**
> SDTokenGetResponses TokenGetGet (string tokenIds)

Get Token

Some of the details of this token are based upon the Template that it was created from (using token/mint)

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TokenGetGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TokenEndpointsApi();
            var tokenIds = tokenIds_example;  // string | Stringify Array of token ids (ex. '[3589, 3580]')

            try
            {
                // Get Token
                SDTokenGetResponses result = apiInstance.TokenGetGet(tokenIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenEndpointsApi.TokenGetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenIds** | **string**| Stringify Array of token ids (ex. &#x27;[3589, 3580]&#x27;) | 

### Return type

[**SDTokenGetResponses**](SDTokenGetResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tokenmintbulkpost"></a>
# **TokenMintBulkPost**
> SDTokenMintBulkResponses TokenMintBulkPost (SDTokenMintBulkRequest body)

Mint Tokens

Mint tokens to a player.

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TokenMintBulkPostExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TokenEndpointsApi();
            var body = new SDTokenMintBulkRequest(); // SDTokenMintBulkRequest | 

            try
            {
                // Mint Tokens
                SDTokenMintBulkResponses result = apiInstance.TokenMintBulkPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenEndpointsApi.TokenMintBulkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDTokenMintBulkRequest**](SDTokenMintBulkRequest.md)|  | 

### Return type

[**SDTokenMintBulkResponses**](SDTokenMintBulkResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tokenmutateput"></a>
# **TokenMutatePut**
> Empty TokenMutatePut (SDTokenMutateRequest body)

Mutate Token

Mutates a Property of a Token

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TokenMutatePutExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TokenEndpointsApi();
            var body = new SDTokenMutateRequest(); // SDTokenMutateRequest | 

            try
            {
                // Mutate Token
                Empty result = apiInstance.TokenMutatePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenEndpointsApi.TokenMutatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDTokenMutateRequest**](SDTokenMutateRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tokenpropsremovedelete"></a>
# **TokenPropsRemoveDelete**
> Empty TokenPropsRemoveDelete (string tokenId, string props)

Remove Token Property

Removes a Tokens Property from Your Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TokenPropsRemoveDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TokenEndpointsApi();
            var tokenId = tokenId_example;  // string | Token Id returned from token/create (ex. 5)
            var props = props_example;  // string | Stringify Array of token mutable property names ex: '[\"exp\", \"health\"]' }

            try
            {
                // Remove Token Property
                Empty result = apiInstance.TokenPropsRemoveDelete(tokenId, props);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenEndpointsApi.TokenPropsRemoveDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| Token Id returned from token/create (ex. 5) | 
 **props** | **string**| Stringify Array of token mutable property names ex: &#x27;[\&quot;exp\&quot;, \&quot;health\&quot;]&#x27; } | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tokentransferpost"></a>
# **TokenTransferPost**
> Empty TokenTransferPost (SDTokenTransferRequest body)

Transfer Tokens

Use this Endpoint to Facilitate Moving Tokens from one Player to Another

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TokenTransferPostExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TokenEndpointsApi();
            var body = new SDTokenTransferRequest(); // SDTokenTransferRequest | 

            try
            {
                // Transfer Tokens
                Empty result = apiInstance.TokenTransferPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenEndpointsApi.TokenTransferPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDTokenTransferRequest**](SDTokenTransferRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
