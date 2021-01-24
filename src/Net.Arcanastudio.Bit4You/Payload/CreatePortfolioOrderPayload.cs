using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
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
