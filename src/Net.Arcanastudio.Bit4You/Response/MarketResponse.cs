using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class MarketResponse
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("precision")]
        public int Precision { get; set; }
        [JsonPropertyName("value")]
        public float Value { get; set; }
        [JsonPropertyName("change")]
        public float Change { get; set; }
        [JsonPropertyName("spread")]
        public float Spread { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
    }
}
