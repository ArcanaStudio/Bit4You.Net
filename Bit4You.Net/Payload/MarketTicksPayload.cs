using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class MarketTicksPayload
    {
        [JsonPropertyName("time")]
        public string market { get; set; }
        [JsonPropertyName("time")]
        public string interval { get; set; }
    }
}
