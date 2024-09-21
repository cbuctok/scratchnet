namespace ScratchpadNet;

using System;
using System.Net.Http;

public class ServiceThingyWithHttpClientIncorrect : IServiceThingy
{
    private static HttpClient _httpClient = new HttpClient();

    public ServiceThingyWithHttpClientIncorrect()
    {
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
        Console.WriteLine("ServiceThingyWithHttpClientIncorrect created");
    }

    public int GetNumberOfHeaders()
    {
        return _httpClient.DefaultRequestHeaders.Count();
    }
}