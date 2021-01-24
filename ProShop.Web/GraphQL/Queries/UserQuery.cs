using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Auth.App.UseCases;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Contract.Requests;
using ProShop.Web.GraphQL.Queries.Types.Users;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery
    {
        private void InitializeUserQuery()
        {
            var commandFactory = _provider
                .GetRequiredService<IUserCommandFactory>();

            FieldAsync<UserType>(
                name: "signInUser",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<SignInUserType>>
                {
                    Name = "user"
                }),
                resolve: async context =>
                {
                    var request = context.GetArgument<SignInUserRequest>("user");
                    var command = commandFactory.Create<UserDto>(request);

                    return await command.Execute();
                });
        }
    }
}
