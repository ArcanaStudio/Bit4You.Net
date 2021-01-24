using System.Net.Http;

namespace Net.Arcanastudio.Bit4You.Service
{
    public interface IHttpClientFactory
    {
        HttpClient Create();
    }
}
