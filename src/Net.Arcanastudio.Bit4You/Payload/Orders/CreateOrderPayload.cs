using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Payload.Generic;

namespace Net.Arcanastudio.Bit4You.Payload.Orders
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
