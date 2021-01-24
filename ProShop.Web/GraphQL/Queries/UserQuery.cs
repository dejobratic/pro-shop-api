﻿using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Users.App.UseCases;
using ProShop.Users.Contract.Dtos;
using ProShop.Users.Contract.Requests;
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
