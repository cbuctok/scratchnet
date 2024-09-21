namespace ScratchpadNet;

using System;
using System.Linq;
using System.Net.Http;

public class ServiceThingyWithHttpClientStatic : IServiceThingy
{
    static HttpClient _httpClient = new HttpClient();

    static ServiceThingyWithHttpClientStatic()
    {
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
    }

    public ServiceThingyWithHttpClientStatic()
    {
        Console.WriteLine(
            $"{nameof(ServiceThingyWithHttpClientStatic)} created with {_httpClient.DefaultRequestHeaders.Count()} headers"
        );
    }

    public int GetNumberOfHeaders()
    {
        return _httpClient.DefaultRequestHeaders.Count();
    }
}
