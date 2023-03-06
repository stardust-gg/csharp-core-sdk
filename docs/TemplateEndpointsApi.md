# Stardust.CoreSDK.Api.TemplateEndpointsApi

All URIs are relative to *https://core-api.stardust.gg/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplateCountGet**](TemplateEndpointsApi.md#templatecountget) | **GET** /template/count | Get Template Count
[**TemplateCreatePost**](TemplateEndpointsApi.md#templatecreatepost) | **POST** /template/create | Create Template
[**TemplateGetAllGet**](TemplateEndpointsApi.md#templategetallget) | **GET** /template/get-all | Get All Templates
[**TemplateGetGet**](TemplateEndpointsApi.md#templategetget) | **GET** /template/get | Get Template
[**TemplateGetTokensGet**](TemplateEndpointsApi.md#templategettokensget) | **GET** /template/get-tokens | Get Template Tokens
[**TemplateMutatePut**](TemplateEndpointsApi.md#templatemutateput) | **PUT** /template/mutate | Mutate Template
[**TemplatePropsRemoveDelete**](TemplateEndpointsApi.md#templatepropsremovedelete) | **DELETE** /template/props-remove | Remove Template Property
[**TemplateRemoveDelete**](TemplateEndpointsApi.md#templateremovedelete) | **DELETE** /template/remove | Remove Template

<a name="templatecountget"></a>
# **TemplateCountGet**
> SDTemplateCountResponse TemplateCountGet (string filter = null)

Get Template Count

Get a Template's Count Within a Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateCountGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var filter = filter_example;  // string | Find a substring within the Template name field (optional) 

            try
            {
                // Get Template Count
                SDTemplateCountResponse result = apiInstance.TemplateCountGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Find a substring within the Template name field | [optional] 

### Return type

[**SDTemplateCountResponse**](SDTemplateCountResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templatecreatepost"></a>
# **TemplateCreatePost**
> SDTemplateCreateResponse TemplateCreatePost (SDTemplateCreateRequest body)

Create Template

Adds a New Token Template that lets Players Acquire that Token using the Token/Mint Endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateCreatePostExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var body = new SDTemplateCreateRequest(); // SDTemplateCreateRequest | 

            try
            {
                // Create Template
                SDTemplateCreateResponse result = apiInstance.TemplateCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDTemplateCreateRequest**](SDTemplateCreateRequest.md)|  | 

### Return type

[**SDTemplateCreateResponse**](SDTemplateCreateResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templategetallget"></a>
# **TemplateGetAllGet**
> SDTemplateGetAllResponses TemplateGetAllGet (string start, string limit, string filter = null)

Get All Templates

Get All of the Templates Within a Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateGetAllGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var start = start_example;  // string | position in list
            var limit = limit_example;  // string | maximum templates returned in list
            var filter = filter_example;  // string | Find a substring within the Template name field (optional) 

            try
            {
                // Get All Templates
                SDTemplateGetAllResponses result = apiInstance.TemplateGetAllGet(start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateGetAllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **string**| position in list | 
 **limit** | **string**| maximum templates returned in list | 
 **filter** | **string**| Find a substring within the Template name field | [optional] 

### Return type

[**SDTemplateGetAllResponses**](SDTemplateGetAllResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templategetget"></a>
# **TemplateGetGet**
> SDTemplateGetResponse TemplateGetGet (string templateId)

Get Template

Get the Details of a Template

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateGetGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var templateId = templateId_example;  // string | Template Id such as 3589)

            try
            {
                // Get Template
                SDTemplateGetResponse result = apiInstance.TemplateGetGet(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateGetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| Template Id such as 3589) | 

### Return type

[**SDTemplateGetResponse**](SDTemplateGetResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templategettokensget"></a>
# **TemplateGetTokensGet**
> SDTemplateGetTokensResponses TemplateGetTokensGet (string templateId, string start = null, string limit = null, string includeDeleted = null)

Get Template Tokens

Get a List of All Minted Tokens from a Given Template

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateGetTokensGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var templateId = templateId_example;  // string | The ID of the Template
            var start = start_example;  // string | position in list (optional) 
            var limit = limit_example;  // string | maximum templates returned in list (optional) 
            var includeDeleted = includeDeleted_example;  // string | If true tokens from deleted players are included in the response (optional) 

            try
            {
                // Get Template Tokens
                SDTemplateGetTokensResponses result = apiInstance.TemplateGetTokensGet(templateId, start, limit, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateGetTokensGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The ID of the Template | 
 **start** | **string**| position in list | [optional] 
 **limit** | **string**| maximum templates returned in list | [optional] 
 **includeDeleted** | **string**| If true tokens from deleted players are included in the response | [optional] 

### Return type

[**SDTemplateGetTokensResponses**](SDTemplateGetTokensResponses.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templatemutateput"></a>
# **TemplateMutatePut**
> Empty TemplateMutatePut (SDTemplateMutateRequest body)

Mutate Template

Mutates a Property of a Template, Which in Turn will Affect the Inherited Property on All of the Tokens Created from this Template (via token/mint)

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateMutatePutExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var body = new SDTemplateMutateRequest(); // SDTemplateMutateRequest | 

            try
            {
                // Mutate Template
                Empty result = apiInstance.TemplateMutatePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateMutatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SDTemplateMutateRequest**](SDTemplateMutateRequest.md)|  | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templatepropsremovedelete"></a>
# **TemplatePropsRemoveDelete**
> Empty TemplatePropsRemoveDelete (string templateId, string props)

Remove Template Property

Removes a Templates Property from Your Game

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplatePropsRemoveDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var templateId = templateId_example;  // string | Template Id returned from template/create (ex. 5)
            var props = props_example;  // string | Stringify Array of template mutable property names ex: '[\"exp\", \"health\"]' }

            try
            {
                // Remove Template Property
                Empty result = apiInstance.TemplatePropsRemoveDelete(templateId, props);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplatePropsRemoveDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| Template Id returned from template/create (ex. 5) | 
 **props** | **string**| Stringify Array of template mutable property names ex: &#x27;[\&quot;exp\&quot;, \&quot;health\&quot;]&#x27; } | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="templateremovedelete"></a>
# **TemplateRemoveDelete**
> Empty TemplateRemoveDelete (string templateId)

Remove Template

Removes a Template from Your Game. If Players have Instances of this Template from the token/mint Command, Their Tokens will NOT be Removed

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class TemplateRemoveDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TemplateEndpointsApi();
            var templateId = templateId_example;  // string | Template Id returned from template/create (ex. 5)

            try
            {
                // Remove Template
                Empty result = apiInstance.TemplateRemoveDelete(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateEndpointsApi.TemplateRemoveDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| Template Id returned from template/create (ex. 5) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
