using GraphQL.Types;
using ProShop.Auth.Contract.Requests;

namespace ProShop.Web.GraphQL.Queries.Types.Users
{
    public class SignInUserType :
        InputObjectGraphType<SignInUserRequest>
    {
        public SignInUserType()
        {
            Name = "SignInUser";

            Field(_ => _.Email).Description("User's e-mail address.");
            Field(_ => _.Password).Description("User's password.");
        }
    }
}
