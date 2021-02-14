using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload.Market
{
    internal class GetMarketOrderBookPayload
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("limit")]
        public int Limit { get; set; }
        [JsonPropertyName("state")]
        public bool State { get; set; }
    }
}
