# Stardust.CoreSDK.Api.PlayerEndpointsApi

All URIs are relative to *https://core-api.stardust.gg/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PlayerCountGet**](PlayerEndpointsApi.md#playercountget) | **GET** /player/count | Get Player Count
[**PlayerCreatePost**](PlayerEndpointsApi.md#playercreatepost) | **POST** /player/create | Create Player
[**PlayerGetAllGet**](PlayerEndpointsApi.md#playergetallget) | **GET** /player/get-all | Get All Players
[**PlayerGetGet**](PlayerEndpointsApi.md#playergetget) | **GET** /player/get | Get Player
[**PlayerGetIdGet**](PlayerEndpointsApi.md#playergetidget) | **GET** /player/get-id | Get Player ID
[**PlayerGetIdsGet**](PlayerEndpointsApi.md#playergetidsget) | **GET** /player/get-ids | Get All Player IDs
[**PlayerGetInventoryGet**](PlayerEndpointsApi.md#playergetinventoryget) | **GET** /player/get-inventory | Get Player Inventory
[**PlayerMutatePut**](PlayerEndpointsApi.md#playermutateput) | **PUT** /player/mutate | Mutate Player
[**PlayerRemoveDelete**](PlayerEndpointsApi.md#playerremovedelete) | **DELETE** /player/remove | Remove Player
[**PlayerWalletGetGet**](PlayerEndpointsApi.md#playerwalletgetget) | **GET** /player/wallet-get | Get Player Wallet
[**PlayerWithdrawPost**](PlayerEndpointsApi.md#playerwithdrawpost) | **POST** /player/withdraw | Withdraw From Player

<a name="playercountget"></a>
# **PlayerCountGet**
> SDPlayerCountResponse PlayerCountGet ()

Get Player Count

Get Player count within a game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerCountGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();

            try
            {
                // Get Player Count
                SDPlayerCountResponse result = apiInstance.PlayerCountGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SDPlayerCountResponse**](SDPlayerCountResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playercreatepost"></a>
# **PlayerCreatePost**
> SDPlayerCreateResponse PlayerCreatePost (SDPlayerCreateRequest body)

Create Player

Create a Player for a game. Returns their player id which can be used to reference them later in Stardust's system

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerCreatePostExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var body = new SDPlayerCreateRequest(); // SDPlayerCreateRequest | 

            try
            {
                // Create Player
                SDPlayerCreateResponse result = apiInstance.PlayerCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDPlayerCreateRequest**](SDPlayerCreateRequest.md)|  | 

### Return type

[**SDPlayerCreateResponse**](SDPlayerCreateResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playergetallget"></a>
# **PlayerGetAllGet**
> SDPlayerGetAllResponses PlayerGetAllGet (string start = null, string filter = null, string limit = null)

Get All Players

Get the List of All Players in Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerGetAllGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var start = start_example;  // string | position in list (optional) 
            var filter = filter_example;  // string | Find a substring within the Player unique ID field (optional) 
            var limit = limit_example;  // string | maximum items returned in list (optional) 

            try
            {
                // Get All Players
                SDPlayerGetAllResponses result = apiInstance.PlayerGetAllGet(start, filter, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerGetAllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **string**| position in list | [optional] 
 **filter** | **string**| Find a substring within the Player unique ID field | [optional] 
 **limit** | **string**| maximum items returned in list | [optional] 

### Return type

[**SDPlayerGetAllResponses**](SDPlayerGetAllResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playergetget"></a>
# **PlayerGetGet**
> SDPlayerGetResponse PlayerGetGet (string playerId)

Get Player

Get Details of a Player Within a Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerGetGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var playerId = playerId_example;  // string | Player id

            try
            {
                // Get Player
                SDPlayerGetResponse result = apiInstance.PlayerGetGet(playerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerGetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **string**| Player id | 

### Return type

[**SDPlayerGetResponse**](SDPlayerGetResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playergetidget"></a>
# **PlayerGetIdGet**
> SDPlayerGetIdResponse PlayerGetIdGet (string uniqueId)

Get Player ID

Get a Player's ID via their Unique ID

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerGetIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var uniqueId = uniqueId_example;  // string | Player's Unique ID

            try
            {
                // Get Player ID
                SDPlayerGetIdResponse result = apiInstance.PlayerGetIdGet(uniqueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerGetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueId** | **string**| Player&#x27;s Unique ID | 

### Return type

[**SDPlayerGetIdResponse**](SDPlayerGetIdResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playergetidsget"></a>
# **PlayerGetIdsGet**
> SDPlayerGetIdsResponses PlayerGetIdsGet ()

Get All Player IDs

Get All Player IDs for a Given Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerGetIdsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();

            try
            {
                // Get All Player IDs
                SDPlayerGetIdsResponses result = apiInstance.PlayerGetIdsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerGetIdsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SDPlayerGetIdsResponses**](SDPlayerGetIdsResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playergetinventoryget"></a>
# **PlayerGetInventoryGet**
> SDPlayerGetInventoryResponses PlayerGetInventoryGet (string playerId, string start = null, string tokenIds = null, string limit = null)

Get Player Inventory

Get a players inventory and all the items it holds

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerGetInventoryGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var playerId = playerId_example;  // string | Player id
            var start = start_example;  // string | position in list (optional) 
            var tokenIds = tokenIds_example;  // string | Comma-Separated String of token ids (ex. '3589, 3580') (optional) 
            var limit = limit_example;  // string | maximum items returned in list (optional) 

            try
            {
                // Get Player Inventory
                SDPlayerGetInventoryResponses result = apiInstance.PlayerGetInventoryGet(playerId, start, tokenIds, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerGetInventoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **string**| Player id | 
 **start** | **string**| position in list | [optional] 
 **tokenIds** | **string**| Comma-Separated String of token ids (ex. &#x27;3589, 3580&#x27;) | [optional] 
 **limit** | **string**| maximum items returned in list | [optional] 

### Return type

[**SDPlayerGetInventoryResponses**](SDPlayerGetInventoryResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playermutateput"></a>
# **PlayerMutatePut**
> Empty PlayerMutatePut (SDPlayerMutateRequest body)

Mutate Player

Change player data

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerMutatePutExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var body = new SDPlayerMutateRequest(); // SDPlayerMutateRequest | 

            try
            {
                // Mutate Player
                Empty result = apiInstance.PlayerMutatePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerMutatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDPlayerMutateRequest**](SDPlayerMutateRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playerremovedelete"></a>
# **PlayerRemoveDelete**
> Empty PlayerRemoveDelete (string playerId)

Remove Player

Removes (hides) a player from your game. This is not permanent.

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerRemoveDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var playerId = playerId_example;  // string | Player Id returned from player/create a UUID, i.e. 802760b0-2bb5-4fba-9237-895ed02cf8d8

            try
            {
                // Remove Player
                Empty result = apiInstance.PlayerRemoveDelete(playerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerRemoveDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **string**| Player Id returned from player/create a UUID, i.e. 802760b0-2bb5-4fba-9237-895ed02cf8d8 | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playerwalletgetget"></a>
# **PlayerWalletGetGet**
> SDPlayerWalletGetResponse PlayerWalletGetGet (string playerId)

Get Player Wallet

Get player's wallet within a game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerWalletGetGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var playerId = playerId_example;  // string | Player id

            try
            {
                // Get Player Wallet
                SDPlayerWalletGetResponse result = apiInstance.PlayerWalletGetGet(playerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerWalletGetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **string**| Player id | 

### Return type

[**SDPlayerWalletGetResponse**](SDPlayerWalletGetResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playerwithdrawpost"></a>
# **PlayerWithdrawPost**
> Empty PlayerWithdrawPost (SDPlayerWithdrawRequest body)

Withdraw From Player

Withdraw a Player's Tokens from their Stardust Wallet

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class PlayerWithdrawPostExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerEndpointsApi();
            var body = new SDPlayerWithdrawRequest(); // SDPlayerWithdrawRequest | 

            try
            {
                // Withdraw From Player
                Empty result = apiInstance.PlayerWithdrawPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerEndpointsApi.PlayerWithdrawPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDPlayerWithdrawRequest**](SDPlayerWithdrawRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
