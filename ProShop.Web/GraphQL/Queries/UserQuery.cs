using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.App.Services;
using ProShop.Web.Extensions;
using ProShop.Web.GraphQL.Types;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery
    {
        private void InitializeUserQuery()
        {
            var userRepo = _provider
                .GetRequiredService<IUserRepository>();

            FieldAsync<UserType>(
                name: "user",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "id"
                }),
                resolve: async context =>
                {
                    return await userRepo.Get(context.Arguments.GetId());
                });

            FieldAsync<ListGraphType<UserType>>(
                name: "users",
                resolve: async context =>
                {
                    return await userRepo.GetAll();
                });
        }
    }
}
