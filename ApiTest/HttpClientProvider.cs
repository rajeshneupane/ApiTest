﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
        public class HttpClientProvider
        {
            private readonly HttpClient _httpClient;

            public HttpClientProvider(HttpClient httpClient, string baseuri)
            {
                _httpClient = httpClient;
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
