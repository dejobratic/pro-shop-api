using GraphQL.Types;
using ProShop.Auth.Contract.Dtos;

namespace ProShop.Web.GraphQL.Queries.Types.Users
{
    public class UserType :
        ObjectGraphType<UserDto>
    {
        public UserType()
        {
            Name = "User";

            Field(_ => _.Id).Description("User's Id.");
            Field(_ => _.FirstName).Description("User's first name.");
            Field(_ => _.LastName).Description("User's last name.");
            Field(_ => _.Email).Description("User's email.");
        }
    }
}
