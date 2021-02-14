using Net.Arcanastudio.Bit4You.Model.Responses.Token;
using Net.Arcanastudio.Bit4You.Response.Token;

namespace Net.Arcanastudio.Bit4You.Extensions
{
    internal static class ResponseExtensions
    {
        public static TokenItem ToModel(this GetTokenResponse request)
        {
            var model = new TokenItem
            {
                Token = request.Token,
                TokenType = request.TokenType,
                IdToken = request.IDToken,
                Code = request.Code,
                AuthenticationExpiration = request.AuthenticationExpiration,
                Expiration = request.Expiration
            };

            return model;
        }
    }
}
