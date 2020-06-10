using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPTestProject
{
    public class HttpClientProvider
    {
        private readonly HttpClient _httpClient;

        //Constructor that takes HttpClient and BaseURL as a parameter
        public HttpClientProvider(HttpClient httpClient, string baseuri)
        {
            //setting httpClient
            _httpClient = httpClient;
            //setting base url
            _httpClient.BaseAddress = new Uri(baseuri);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return _httpClient.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return _httpClient.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return _httpClient.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return _httpClient.DeleteAsync(requestUri);
        }
    }
}
