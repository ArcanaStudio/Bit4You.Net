using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    public class PortfolioClosePositionResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
