using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class ClosePortfolioOrderPayload : SimulablePayloadBase
    {
        [JsonPropertyName("id")]
        public int OrderId { get; set; }
    }
}
