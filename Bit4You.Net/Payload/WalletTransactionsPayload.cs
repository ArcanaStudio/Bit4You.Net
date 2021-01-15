using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class WalletTransactionsPayload : SimulablePayloadBase
    {
        [JsonPropertyName("iso")]
        public string ISO { get; set; }
    }
}
