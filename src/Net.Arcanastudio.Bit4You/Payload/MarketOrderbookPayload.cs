using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class MarketOrderbookPayload
    {
        [JsonPropertyName("time")]
        public string market { get; set; }
        [JsonPropertyName("time")]
        public int limit { get; set; }
        [JsonPropertyName("time")]
        public bool state { get; set; }
    }
}
