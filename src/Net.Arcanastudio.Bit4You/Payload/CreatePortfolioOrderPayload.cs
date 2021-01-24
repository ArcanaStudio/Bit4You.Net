using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
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
