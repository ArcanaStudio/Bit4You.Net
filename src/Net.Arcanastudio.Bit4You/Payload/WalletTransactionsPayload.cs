using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class WalletTransactionsPayload : SimulablePayloadBase
    {
        [JsonPropertyName("iso")]
        public string ISO { get; set; }
    }
}
