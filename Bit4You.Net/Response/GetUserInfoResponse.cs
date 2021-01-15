using System;
using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    public class GetUserInfoResponse
    {
        [JsonPropertyName("sub")]
        public int Sub { get; set; }
        [JsonPropertyName("iss")]
        public string Iss { get; set; }
        [JsonPropertyName("aud")]
        public string Aud { get; set; }
        [JsonPropertyName("iat")]
        public int Iat { get; set; }
        [JsonPropertyName("auth_time")]
        public int AuthTime { get; set; }
        [JsonPropertyName("verified")]
        public bool Verified { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("family_name")]
        public string FamilyName { get; set; }
        [JsonPropertyName("given_name")]
        public string GivenName { get; set; }
        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("birthdate")]
        public string Birthdate { get; set; }
        [JsonPropertyName("birthplace")]
        public string Birthplace { get; set; }
        [JsonPropertyName("zoneinfo")]
        public string ZoneInfo { get; set; }
        [JsonPropertyName("locale")]
        public string Locale { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }
        [JsonPropertyName("id_expiration")]
        public object IdExpiration { get; set; }
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }
    }
}
