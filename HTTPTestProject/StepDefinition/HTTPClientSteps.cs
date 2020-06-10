using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace HTTPTestProject.StepDefinition
{
    [Binding]
    public class HTTPClientSteps
    {
        private HttpClient httpClient;
        HttpClientProvider clientProvider;
        HttpResponseMessage response;
        [Given(@"I set the base url ""(.*)""")]
        public void GivenISetTheBaseUrl(string url)
        {
            httpClient = new HttpClient();
            clientProvider = new HttpClientProvider(httpClient, url);
        }

        [When(@"I call the endpoint ""(.*)"" with get method")]
        public async Task WhenICallTheEndpointWithGetMethod(string endpoint)
        {
            response = await clientProvider.GetAsync(endpoint);
        }

        [Then(@"I get the endpoint url ""(.*)"" in the response")]
        public void ThenIGetTheEndpointUrlInTheResponse(string expectedUrl)
        {
            var result = response.Content.ReadAsStringAsync().Result;
            Assert.Contains(expectedUrl, result);
        }

        [Then(@"I get the response status code as (.*)")]
        public void ThenIGetTheResponseStatusCodeAs(int expectedStatusCode)
        {
            Assert.Equal(expectedStatusCode, (int)response.StatusCode);
        }
    }
}
