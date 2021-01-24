using System.Net.Http;
using Arcana.Toolkit.Testing.MsTest;
using Net.Arcanastudio.Bit4You.Service;

namespace Net.Arcanastudio.Bit4You.Tests.Helpers
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
