using System;

namespace Net.Arcanastudio.Bit4You.Model.Request.Token
{
    public class GetTokenRequest
    {
        public string GrantType { get; }
        public string Scope { get; }
        public string Client { get; }
        public string Secret { get; }

        public GetTokenRequest(string grantType = null, string scope = null, string client = null, string secret = null)
        {
            GrantType = grantType ?? throw new ArgumentNullException(nameof(grantType));
            Scope = scope ?? throw new ArgumentNullException(nameof(scope));
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Secret = secret ?? throw new ArgumentNullException(nameof(secret));
        }
    }
}
