using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    public class GetMarketOrderBookResponse
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("prevId")]
        public string PrevId { get; set; }
        [JsonPropertyName("ask")]
        public Ask[] Ask { get; set; }
        [JsonPropertyName("bid")]
        public Bid[] Bid { get; set; }
    }

    public class Ask
    {
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
        [JsonPropertyName("i")]
        public int I { get; set; }
    }

    public class Bid : Ask
    {
    }

}
