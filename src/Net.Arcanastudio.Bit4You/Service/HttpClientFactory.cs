using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Net.Arcanastudio.Bit4You.Service
{
    internal class HttpClientFactory : IHttpClientFactory
    {
        public HttpClient Create()
        {
            var client = new HttpClient { BaseAddress = new Uri(Constants.Base.BaseUrl) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
