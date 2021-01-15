using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class OrderInfoPayload : SimulablePayloadBase
    {
        [JsonPropertyName("txid")]
        public string TransactionId { get; set; }
    }
}
