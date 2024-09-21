namespace ScratchpadNet;

using System;
using System.Linq;
using System.Net.Http;

public class ServiceThingyWithHttpClientIncorrect : IServiceThingy
{
    private static readonly HttpClient _httpClient = new HttpClient();
    private static int _instanceCount = 0;

    public ServiceThingyWithHttpClientIncorrect()
    {
        _instanceCount++;
        _httpClient.DefaultRequestHeaders.Add($"Custom-Header-{_instanceCount}", "value");
        Console.WriteLine(
            $"{nameof(ServiceThingyWithHttpClientIncorrect)} created with {_httpClient.DefaultRequestHeaders.Count()} headers"
        );
    }

    public int GetNumberOfHeaders()
    {
        return _httpClient.DefaultRequestHeaders.Count();
    }
}
