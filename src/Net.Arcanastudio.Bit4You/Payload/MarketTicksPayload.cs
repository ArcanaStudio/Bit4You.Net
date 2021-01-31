using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class MarketTicksPayload
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("interval")]
        public string Interval { get; set; }
    }
}
