using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class ClosePortfolioOrderPayload : SimulablePayloadBase
    {
        [JsonPropertyName("id")]
        public int OrderId { get; set; }
    }
}
