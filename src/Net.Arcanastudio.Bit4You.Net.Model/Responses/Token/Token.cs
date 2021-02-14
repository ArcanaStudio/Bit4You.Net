namespace Net.Arcanastudio.Bit4You.Model.Responses.Token
{
    public class TokenItem
    {
        public string Token { get; set; }
        public string TokenType { get; set; }
        public string IdToken { get; set; }
        public int Expiration { get; set; }
        public int AuthenticationExpiration { get; set; }
        public int Code { get; set; }
    }
}