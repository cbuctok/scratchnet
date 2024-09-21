namespace ScratchpadNetTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScratchpadNet;

[TestClass]
public class ServiceThingyTests
{
    [TestMethod]
    public void SimpleTest()
    {
        var serviceThingy = new ServiceThingyWithHttpClientStatic();
        Assert.AreEqual(1, serviceThingy.GetNumberOfHeaders());
    }

    [TestMethod]
    public void StaticTest10()
    {
        const int expected = 10;

        var arrayOfServiceThingies = new IServiceThingy[expected];

        for (var i = 0; i < expected; i++)
        {
            var serviceThingy = new ServiceThingyWithHttpClientStatic();
            arrayOfServiceThingies[i] = serviceThingy;
        }

        // assert all have the same number of headers
        foreach (var serviceThingy in arrayOfServiceThingies)
        {
            Assert.AreEqual(1, serviceThingy.GetNumberOfHeaders());
        }
    }

    [TestMethod]
    public void DynamicTest10()
    {
        const int expected = 10;

        var arrayOfServiceThingies = new IServiceThingy[expected];

        for (var i = 0; i < expected; i++)
        {
            var serviceThingy = new ServiceThingyWithHttpClientDynamic();
            arrayOfServiceThingies[i] = serviceThingy;
        }

        // assert all have the same number of headers
        foreach (var serviceThingy in arrayOfServiceThingies)
        {
            Assert.AreEqual(1, serviceThingy.GetNumberOfHeaders());
        }
    }
}