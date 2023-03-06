# Stardust.CoreSDK.Api.HealthEndpointsApi

All URIs are relative to *https://core-api.stardust.gg/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HealthGet**](HealthEndpointsApi.md#healthget) | **GET** /health | Get Health

<a name="healthget"></a>
# **HealthGet**
> SDHealthResponse HealthGet ()

Get Health

Get system health info

### Example
```csharp
using System;
using System.Diagnostics;
using Stardust.CoreSDK.Api;
using Stardust.CoreSDK.Client;
using Stardust.CoreSDK.Model;

namespace Example
{
    public class HealthGetExample
    {
        public void main()
        {
            var apiInstance = new HealthEndpointsApi();

            try
            {
                // Get Health
                SDHealthResponse result = apiInstance.HealthGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthEndpointsApi.HealthGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SDHealthResponse**](SDHealthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
