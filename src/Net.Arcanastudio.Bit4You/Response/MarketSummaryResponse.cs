using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class MarketSummaryResponse
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("marketCap")]
        public long MarketCap { get; set; }
        [JsonPropertyName("high")]
        public float High { get; set; }
        [JsonPropertyName("low")]
        public float Low { get; set; }
        [JsonPropertyName("volume")]
        public float Volume { get; set; }
        [JsonPropertyName("last")]
        public float Last { get; set; }
        [JsonPropertyName("prevDay")]
        public float PreviousDay { get; set; }
        [JsonPropertyName("bid")]
        public float Bid { get; set; }
        [JsonPropertyName("ask")]
        public float Ask { get; set; }
        [JsonPropertyName("open")]
        public float Open { get; set; }
    }
}
