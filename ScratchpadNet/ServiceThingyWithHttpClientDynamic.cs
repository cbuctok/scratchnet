namespace ScratchpadNet;

using System;

public class ServiceThingyWithHttpClientDynamic : IServiceThingy
{
    HttpClient _httpClient = new HttpClient();

    public ServiceThingyWithHttpClientDynamic()
    {
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
        Console.WriteLine($"{nameof(ServiceThingyWithHttpClientDynamic)} created with {_httpClient.DefaultRequestHeaders.Count()} headers");
    }

    public int GetNumberOfHeaders()
    {
        return _httpClient.DefaultRequestHeaders.Count();
    }
}
