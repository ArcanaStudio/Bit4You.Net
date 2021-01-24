using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class CancelOrderPayload : SimulablePayloadBase
    {
        [JsonPropertyName("txid")]
        public string TransactionId { get; set; }
    }
}