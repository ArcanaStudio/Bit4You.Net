using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class OrderInfoPayload : SimulablePayloadBase
    {
        [JsonPropertyName("txid")]
        public string TransactionId { get; set; }
    }
}
