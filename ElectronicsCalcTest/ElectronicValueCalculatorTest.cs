using System;
using System.Net.Http;
using ElectronicsCalc.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy.Json;
using Newtonsoft.Json;

namespace ElectronicsCalcTest
{
  
    [TestClass]
    public class ElectronicValueCalculatorTest
    {
        private readonly HttpClient client = ElectronicsCalcApiHelper.CreateTestClient();

        [TestMethod]
        public void TesstHelloOhms()
        {
            Assert.AreEqual("resistor calculator", GetResponseBody("/ohms"));
        }

        [TestMethod]
        public void TestGetThreeThousandSevenHundredOhmsToleranceTenPercent()
        {
           var valueData = JsonConvert.DeserializeObject<ValueData>(GetResponseBody("/ohms/orange/violet/red/silver"));
            Assert.AreEqual(valueData.Value, 3700);
            Assert.AreEqual(valueData.Tolerance, "10%");
        }

        private string GetResponseBody(string path)
        {
            return client.GetAsync(path).Result
                            .Content
                            .ReadAsStringAsync().Result;
        }
    }
}
