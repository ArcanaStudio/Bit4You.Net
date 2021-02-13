using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    internal class ClosePortfolioPositionPayload : SimulablePayloadBase
    {
        [JsonPropertyName("id")]
        public int OrderId { get; set; }
    }
}
