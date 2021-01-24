using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
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
