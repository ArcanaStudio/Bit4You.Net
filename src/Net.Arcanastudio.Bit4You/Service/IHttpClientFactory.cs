using System.Net.Http;

namespace Bit4You.Net.Service
{
    public interface IHttpClientFactory
    {
        HttpClient Create();
    }
}
