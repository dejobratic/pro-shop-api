using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Shopping.App.UseCases;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Contract.Requests;
using ProShop.Web.Extensions;
using ProShop.Web.GraphQL.Queries.Types.Orders;
using System.Collections.Generic;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery
    {
        private void InitializeOrderQuery()
        {
            var commandFactory = _provider
                .GetRequiredService<IOrderCommandFactory>();

            FieldAsync<OrderType>(
                name: "order",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "id"
                }),
                resolve: async context =>
                {
                    var request = new GetOrderByIdRequest { OrderId = context.Arguments.GetGuid("id") };
                    var command = commandFactory.Create<OrderDto>(request);

                    return await command.Execute();
                });

            FieldAsync<ListGraphType<OrderType>>(
                name: "ordersByCustomerId",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "customerId"
                }),
                resolve: async context =>
                {
                    var request = new GetOrdersByCustomerIdRequest { CustomerId = context.Arguments.GetGuid("customerId") };
                    var command = commandFactory.Create<IEnumerable<OrderDto>>(request);

                    return await command.Execute();
                });
        }
    }
}
