using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Auth.App.UseCases;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Contract.Requests;
using ProShop.Web.GraphQL.Mutations.Types.Users;
using ProShop.Web.GraphQL.Queries.Types.Users;

namespace ProShop.Web.GraphQL.Mutations
{
    public partial class RootMutation
    {
        private void InitializeUserMutation()
        {
            var commandFactory = _provider
                .GetRequiredService<IUserCommandFactory>();

            FieldAsync<UserType>(
                name: "signUpUser",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<SignUpUserType>>
                {
                    Name = "user"
                }),
                resolve: async context =>
                {
                    var request = context.GetArgument<SignUpUserRequest>("user");
                    var command = commandFactory.Create<UserDto>(request);

                    return await command.Execute();
                });
        }
    }
}
