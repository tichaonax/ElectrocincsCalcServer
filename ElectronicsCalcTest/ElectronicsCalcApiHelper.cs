using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ElectronicsCalc;
using Microsoft.Owin.Builder;
using Nancy;

namespace ElectronicsCalcTest
{
    internal static class ElectronicsCalcApiHelper
    {
        public static HttpClient CreateTestClient()
        {
            return new HttpClient(CreateOwinHttpMessageHandler())
            {
                BaseAddress = new Uri("http://colorcodestest")
            };
        }

        private static OwinHttpMessageHandler CreateOwinHttpMessageHandler()
        {
            var app = new AppBuilder();
            new StartUp().Configuration(app);
            return new OwinHttpMessageHandler(app.Build());
        }
    }
}
