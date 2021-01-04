using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Core.Services;
using ProShop.Web.GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery
    {
        private void InitializeOrderQuery()
        {
            var orderRepo = _provider
                .GetRequiredService<IOrderRepository>();

            FieldAsync<OrderType>(
                name: "order",
                resolve: async context =>
                {
                    var id = (Guid)context.Arguments["id"];
                    return await orderRepo.Get(id);
                });

            FieldAsync<ListGraphType<OrderType>>(
                name: "orders",
                resolve: async context =>
                {
                    return await orderRepo.GetAll();
                });
        }
    }
}
