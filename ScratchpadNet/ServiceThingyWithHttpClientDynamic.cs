namespace ScratchpadNet;

using System;

public class ServiceThingyWithHttpClientDynamic : IServiceThingy
{
    HttpClient httpClient = new HttpClient();

    public ServiceThingyWithHttpClientDynamic()
    {
        Console.WriteLine("ServiceThingy created");
        httpClient.DefaultRequestHeaders.Add("User-Agent", "ServiceThingy");
    }

    public int GetNumberOfHeaders()
    {
        return httpClient.DefaultRequestHeaders.Count();
    }
}
