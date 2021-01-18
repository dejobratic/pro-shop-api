using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Users.App.UseCases;
using ProShop.Users.Contract.Dtos;
using ProShop.Users.Contract.Requests;
using ProShop.Web.GraphQL.Types.Users;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery
    {
        private void InitializeUserQuery()
        {
            var commandFactory = _provider
                .GetRequiredService<IUserCommandFactory>();

            FieldAsync<UserType>(
                name: "user",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "email"
                    },
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "password"
                    }),
                resolve: async context =>
                {
                    var request = new SignInUserRequest
                    {
                        Email = (string)context.Arguments["email"],
                        Password = (string)context.Arguments["password"]
                    };
                    var command = commandFactory.Create<UserDto>(request);

                    return await command.Execute();
                });
        }
    }
}
