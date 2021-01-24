using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class MarketTicksPayload
    {
        [JsonPropertyName("time")]
        public string market { get; set; }
        [JsonPropertyName("time")]
        public string interval { get; set; }
    }
}
