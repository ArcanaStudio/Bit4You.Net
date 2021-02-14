using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Payload.Generic;

namespace Net.Arcanastudio.Bit4You.Payload.Portfolio
{
    internal class ClosePortfolioPositionPayload : SimulablePayloadBase
    {
        [JsonPropertyName("id")]
        public int OrderId { get; set; }
    }
}
