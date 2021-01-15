using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class CreateOrderPayload : SimulablePayloadBase
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
        [JsonPropertyName("quantity_iso")]
        public string QuantityIso { get; set; }
        [JsonPropertyName("rate")]
        public string Rate { get; set; }
    }
}
