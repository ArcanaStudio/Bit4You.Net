using Net.Arcanastudio.Bit4You.Model.Request.Token;
using Net.Arcanastudio.Bit4You.Payload.Token;

namespace Net.Arcanastudio.Bit4You.Extensions
{
    internal static class RequestExtensions
    {
        public static GetTokenPayload ToPayload(this GetTokenRequest request)
        {
            var payload = new GetTokenPayload
            {
                Client = request.Client,
                GrantType = request.GrantType,
                Scope = request.Scope,
                Secret = request.Secret
            };

            return payload;
        }
    }
}
