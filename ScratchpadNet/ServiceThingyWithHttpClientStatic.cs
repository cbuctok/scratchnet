namespace ScratchpadNet;

using System;
using System.Linq;
using System.Net.Http;

public class ServiceThingyWithHttpClientStatic : IServiceThingy
{
    static HttpClient _httpClient = new HttpClient();

    static ServiceThingyWithHttpClientStatic()
    {
        Console.WriteLine("ServiceThingy created");
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
    }

    public ServiceThingyWithHttpClientStatic()
    {
        Console.WriteLine("ServiceThingy created");
    }

    public int GetNumberOfHeaders()
    {
        return _httpClient.DefaultRequestHeaders.Count();
    }
}
