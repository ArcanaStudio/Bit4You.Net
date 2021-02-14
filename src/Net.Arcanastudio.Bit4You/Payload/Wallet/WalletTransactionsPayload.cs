using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Payload.Generic;

namespace Net.Arcanastudio.Bit4You.Payload.Wallet
{
    internal class WalletTransactionsPayload : SimulablePayloadBase
    {
        [JsonPropertyName("iso")]
        public string ISO { get; set; }
    }
}
