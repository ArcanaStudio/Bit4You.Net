using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
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
