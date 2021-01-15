using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    public class PortfolioClosePositionResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
