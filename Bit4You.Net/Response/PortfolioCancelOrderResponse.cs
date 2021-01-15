using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    public class PortfolioCancelOrderResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
