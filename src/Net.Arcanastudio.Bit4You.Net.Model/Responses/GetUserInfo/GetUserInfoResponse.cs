using System;

namespace Net.Arcanastudio.Bit4You.Model.Responses.GetUserInfo
{
    public class GetUserInfoResponse
    {
        public int Sub { get; set; }
        public string Iss { get; set; }
        public string Aud { get; set; }
        public int Iat { get; set; }
        public int AuthTime { get; set; }
        public bool Verified { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string Birthplace { get; set; }
        public string ZoneInfo { get; set; }
        public string Locale { get; set; }
        public string Currency { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string IdNumber { get; set; }
        public object IdExpiration { get; set; }
        public string Nationality { get; set; }
    }
}
