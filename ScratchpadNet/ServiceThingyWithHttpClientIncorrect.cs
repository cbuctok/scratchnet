namespace ScratchpadNet;

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

public class ServiceThingyWithHttpClientIncorrect : IServiceThingy
{
    private static readonly HttpClient _httpClient = new HttpClient();
    private static int _instanceCount = 0;

    public ServiceThingyWithHttpClientIncorrect()
    {
        _instanceCount++;
        _httpClient.DefaultRequestHeaders.Add($"Custom-Header-{_instanceCount}", "value");
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        Console.WriteLine(
            $"{nameof(ServiceThingyWithHttpClientIncorrect)} created with {_httpClient.DefaultRequestHeaders.Count()} headers"
        );
    }

    public int GetNumberOfAcceptArguments()
    {
        return _httpClient.DefaultRequestHeaders.Accept.Count;
    }
    
    public int GetNumberOfHeaders()
    {
        return _httpClient.DefaultRequestHeaders.Count();
    }
}
