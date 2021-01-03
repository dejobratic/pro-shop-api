using GraphQL.Types;
using ProShop.Core.Services;
using ProShop.Web.GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Queries
{
    public class UserQuery :
        ObjectGraphType
    {
        public UserQuery(
            IUserRepository userRepo)
        {
            FieldAsync<UserType>(
                name: "user",
                resolve: async context =>
                {
                    var id = (Guid)context.Arguments["id"];
                    return await userRepo.Get(id);
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
