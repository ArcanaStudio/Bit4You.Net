using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload
{
    public abstract class SimulablePayloadBase
    {
        [JsonPropertyName("simulation")]
        public bool Simulation { get; set; }
    }
}
