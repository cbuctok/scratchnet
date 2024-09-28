namespace ScratchpadNet;

using System;
using System.Net.Http.Headers;

public class ServiceThingyWithHttpClientDynamic : IServiceThingy
{
    HttpClient _httpClient = new HttpClient();

    public ServiceThingyWithHttpClientDynamic()
    {
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        Console.WriteLine($"{nameof(ServiceThingyWithHttpClientDynamic)} created with {_httpClient.DefaultRequestHeaders.Count()} headers");
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
