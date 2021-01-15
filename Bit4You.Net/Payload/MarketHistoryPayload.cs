using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class MarketHistoryPayload
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("limit")]
        public int Limit { get; set; }
        [JsonPropertyName("from")]
        public string From { get; set; }
        [JsonPropertyName("to")]
        public string To { get; set; }
    }
}
