using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class MarketOrderbookResponse
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("prevId")]
        public string PrevId { get; set; }
        [JsonPropertyName("ask")]
        public AskResponse[] Ask { get; set; }
        [JsonPropertyName("bid")]
        public BidResponse[] Bid { get; set; }
    }

    internal class AskResponse
    {
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
        [JsonPropertyName("i")]
        public int Index { get; set; }
    }

    internal class BidResponse
    {
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
        [JsonPropertyName("time")]
        public int Index { get; set; }
    }

}
