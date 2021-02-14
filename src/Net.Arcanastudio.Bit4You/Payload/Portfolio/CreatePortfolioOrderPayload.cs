using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Payload.Generic;

namespace Net.Arcanastudio.Bit4You.Payload.Portfolio
{
    internal class CreatePortfolioOrderPayload : SimulablePayloadBase
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("amount")]
        public float Amount { get; set; }
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
    }
}
