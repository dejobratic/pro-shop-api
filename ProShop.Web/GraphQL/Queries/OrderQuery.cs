using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Store.App.UseCases;
using ProShop.Store.Contract.Dtos;
using ProShop.Store.Contract.Requests;
using ProShop.Web.GraphQL.Extensions;
using ProShop.Web.GraphQL.Types.Store;
using System;
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
                    var request = new GetOrderByIdRequest { OrderId = context.GetArgument<Guid>("id") };
                    var command = commandFactory.Create<OrderDto>(request);

                    return await command.Execute();
                })
                .RequiresPermission("Customer");

            FieldAsync<ListGraphType<OrderType>>(
                name: "ordersByCustomerId",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "customerId"
                }),
                resolve: async context =>
                {
                    var request = new GetOrdersByCustomerIdRequest { CustomerId = context.GetArgument<Guid>("customerId") };
                    var command = commandFactory.Create<IEnumerable<OrderDto>>(request);

                    return await command.Execute();
                })
                .RequiresPermission("Customer");
        }
    }
}
