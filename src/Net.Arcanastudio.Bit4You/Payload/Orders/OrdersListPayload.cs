using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Payload.Generic;

namespace Net.Arcanastudio.Bit4You.Payload.Orders
{
    internal class OrdersListPayload : SimulablePayloadBase
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }
        [JsonPropertyName("limit")]
        public int Limit { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
    }
}
