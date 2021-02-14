using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Payload.Generic;

namespace Net.Arcanastudio.Bit4You.Payload.Orders
{
    internal class CancelOrderPayload : SimulablePayloadBase
    {
        [JsonPropertyName("txid")]
        public string TransactionId { get; set; }
    }
}