using System.Net;

namespace Net.Arcanastudio.Bit4You.Response
{
    public class RequestResponse
    {
        public bool HasError => !string.IsNullOrEmpty(Error);
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public string Data { get; set; }
    }
}
