namespace ScratchpadNet;

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

public class ServiceThingyWithHttpClientStatic : IServiceThingy
{
    static HttpClient _httpClient = new HttpClient();

    static ServiceThingyWithHttpClientStatic()
    {
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public ServiceThingyWithHttpClientStatic()
    {
        Console.WriteLine(
            $"{nameof(ServiceThingyWithHttpClientStatic)} created with {_httpClient.DefaultRequestHeaders.Count()} headers"
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
