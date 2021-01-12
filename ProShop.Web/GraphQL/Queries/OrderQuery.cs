using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Orders.App.Services;
using ProShop.Web.Extensions;
using ProShop.Web.GraphQL.Types;

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
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "id"
                }),
                resolve: async context =>
                {
                    return await orderRepo.Get(context.Arguments.GetId());
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
