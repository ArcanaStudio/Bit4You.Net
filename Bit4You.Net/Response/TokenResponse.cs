using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string Token { get; set; }
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
        [JsonPropertyName("id_token")]
        public string IDToken { get; set; }
        [JsonPropertyName("expires_in")]
        public int Expiration { get; set; }
        [JsonPropertyName("auth_exp")]
        public int AuthenticationExpiration { get; set; }
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}