using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload.Generic
{
    internal abstract class SimulablePayloadBase
    {
        [JsonPropertyName("simulation")]
        public bool Simulation { get; set; }
    }
}
