using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response.Market
{
    internal class MarketTicksResponse
    {
        [JsonPropertyName("time")]
        public int Time { get; set; }
        [JsonPropertyName("open")]
        public float Open { get; set; }
        [JsonPropertyName("close")]
        public float Close { get; set; }
        [JsonPropertyName("low")]
        public float Low { get; set; }
        [JsonPropertyName("high")]
        public float High { get; set; }
        [JsonPropertyName("volume")]
        public float Volume { get; set; }
        [JsonPropertyName("marketVolume")]
        public float MarketVolume { get; set; }
    }
}
