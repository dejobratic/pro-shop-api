using GraphQL.Types;
using ProShop.Auth.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types.Auth
{
    public class TokenType :
        ObjectGraphType<TokenDto>
    {
        public TokenType()
        {
            Name = "Token";

            Field(_ => _.Value).Description("Token.");
            Field(_ => _.Type).Description("Token type.");
            Field(_ => _.ExpiresAt).Description("Token expiration date.");
        }
    }
}
