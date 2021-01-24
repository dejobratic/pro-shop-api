using GraphQL.Types;
using ProShop.Users.Contract.Requests;

namespace ProShop.Web.GraphQL.Mutations.Types.Users
{
    public class SignUpUserType :
        InputObjectGraphType<SignUpUserRequest>
    {
        public SignUpUserType()
        {
            Name = "SignUpUser";

            Field(_ => _.FirstName).Description("User's first name.");
            Field(_ => _.LastName).Description("User's last name.");
            Field(_ => _.Email).Description("User's e-mail address.");
            Field(_ => _.Password).Description("User's password.");
        }
    }
}
