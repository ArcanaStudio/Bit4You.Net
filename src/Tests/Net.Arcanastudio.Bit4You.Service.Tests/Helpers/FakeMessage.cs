using System.Text.Json.Serialization;

namespace Bit4You.Service.Tests.Helpers
{
    public class FakeMessage<T>
    {
        [JsonPropertyName("returncode")]
        public int ReturnCode { get; set; }
        [JsonPropertyName("content")]
        public T Content { get; set; }
    }
}
