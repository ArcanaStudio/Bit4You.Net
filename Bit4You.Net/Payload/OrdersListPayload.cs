using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
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
