using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class MarketHistoryResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("time")]
        public int Time { get; set; }
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
        [JsonPropertyName("buy")]
        public bool Buy { get; set; }
    }
}
