using System.Net;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Generic
{
    public class RequestResponse
    {
        public bool HasError => !string.IsNullOrEmpty(Error);
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public string Data { get; set; }
    }
}
