# Stardust.CoreSDK.Api.GameEndpointsApi

All URIs are relative to *https://core-api.stardust.gg/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GameGetGet**](GameEndpointsApi.md#gamegetget) | **GET** /game/get | Get Game
[**GameMutatePut**](GameEndpointsApi.md#gamemutateput) | **PUT** /game/mutate | Mutate Game

<a name="gamegetget"></a>
# **GameGetGet**
> SDGameGetResponse GameGetGet ()

Get Game

Get the Details of Your Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class GameGetGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GameEndpointsApi();

            try
            {
                // Get Game
                SDGameGetResponse result = apiInstance.GameGetGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameEndpointsApi.GameGetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SDGameGetResponse**](SDGameGetResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gamemutateput"></a>
# **GameMutatePut**
> Empty GameMutatePut (SDGameMutateRequest body)

Mutate Game

Change a games data

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class GameMutatePutExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GameEndpointsApi();
            var body = new SDGameMutateRequest(); // SDGameMutateRequest | 

            try
            {
                // Mutate Game
                Empty result = apiInstance.GameMutatePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameEndpointsApi.GameMutatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDGameMutateRequest**](SDGameMutateRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
