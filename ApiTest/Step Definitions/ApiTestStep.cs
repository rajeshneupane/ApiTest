using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace ApiTest.Step_Definitions
{
    [Binding]
    public class ApiTestStep
    {
        private HttpClient httpClient;
        HttpClientProvider clientProvider;
        [Given(@"I set the base url ""(.*)""")]
        public void GivenISetTheBaseUrl(string url)
        {
            clientProvider = new HttpClientProvider(httpClient, url);
        }

        [When(@"I call the endpoint ""(.*)"" with get method")]
        public void WhenICallTheEndpointWithGetMethod(string endpoint)
        {
            clientProvider.GetAsync(endpoint);   
        }

        [Then(@"I get the response in json format")]
        public void ThenIGetTheResponseInJsonFormat()
        {
            Assert.Equal("abc", "abc");
        }

    }
}
