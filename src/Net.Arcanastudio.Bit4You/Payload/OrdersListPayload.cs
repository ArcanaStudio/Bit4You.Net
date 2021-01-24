using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
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
