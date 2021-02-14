using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Payload.Token
{
    internal class GetTokenPayload
    {
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
        [JsonPropertyName("username")]
        public string Client { get; set; }
        [JsonPropertyName("password")]
        public string Secret { get; set; }
    }
}
