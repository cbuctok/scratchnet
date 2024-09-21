namespace ScratchpadNetTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScratchpadNet;

[TestClass]
public class ServiceThingyTests
{
    private const int sampleSize = 10;

    [TestMethod]
    public void StaticTest10()
    {
        var arrayOfServiceThingies = CreateServiceThingies<ServiceThingyWithHttpClientStatic>(
            sampleSize
        );

        // assert all have the same number of headers
        foreach (var serviceThingy in arrayOfServiceThingies)
        {
            Assert.AreEqual(1, serviceThingy.GetNumberOfHeaders());
        }
    }

    [TestMethod]
    public void DynamicTest10()
    {
        var arrayOfServiceThingies = CreateServiceThingies<ServiceThingyWithHttpClientDynamic>(
            sampleSize
        );

        // assert all have the same number of headers
        foreach (var serviceThingy in arrayOfServiceThingies)
        {
            Assert.AreEqual(1, serviceThingy.GetNumberOfHeaders());
        }
    }

    [TestMethod]
    public void IncorrectTest10()
    {
        var arrayOfServiceThingies = CreateServiceThingies<ServiceThingyWithHttpClientIncorrect>(
            sampleSize
        );

        // assert all have the same number of headers
        foreach (var serviceThingy in arrayOfServiceThingies)
        {
            Assert.AreEqual(sampleSize, serviceThingy.GetNumberOfHeaders());
        }
    }

    // CreateServiceThingies creates a number of ServiceThingies of a given type and returns them in an array
    private static IServiceThingy[] CreateServiceThingies<T>(int count)
        where T : IServiceThingy, new()
    {
        var arrayOfServiceThingies = new IServiceThingy[count];

        for (var i = 0; i < count; i++)
        {
            arrayOfServiceThingies[i] = new T();
        }

        return arrayOfServiceThingies;
    }
}
