using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class ClosePortfolioPositionResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
