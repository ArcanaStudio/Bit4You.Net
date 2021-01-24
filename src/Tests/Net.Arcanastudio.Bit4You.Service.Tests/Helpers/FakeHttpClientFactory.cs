using System.Net.Http;
using Bit4You.Net.Service;

namespace Bit4You.Service.Tests.Helpers
{
    public class FakeHttpClientFactory<T> : IHttpClientFactory
    {
        private readonly FakeHttpMessageHandler<T> _fakeHttpMessageHandler;

        public FakeHttpClientFactory(FakeHttpMessageHandler<T> fakeHttpMessageHandler)
        {
            _fakeHttpMessageHandler = fakeHttpMessageHandler;
        }

        public HttpClient Create()
        {
            var httpclient = new HttpClient(_fakeHttpMessageHandler);

            return httpclient;
        }
    }
}
