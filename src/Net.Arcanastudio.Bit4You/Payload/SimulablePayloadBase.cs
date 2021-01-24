using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    public abstract class SimulablePayloadBase
    {
        [JsonPropertyName("simulation")]
        public bool Simulation { get; set; }
    }
}
