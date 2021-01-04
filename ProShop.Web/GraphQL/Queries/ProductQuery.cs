using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Core.Services;
using ProShop.Web.GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery
    {
        private void InitializeProductQuery()
        {
            var productRepo = _provider
                .GetRequiredService<IProductRepository>();

            FieldAsync<ProductType>(
                name: "product",
                resolve: async context =>
                {
                    var id = (Guid)context.Arguments["id"];
                    return await productRepo.Get(id);
                });

            FieldAsync<ListGraphType<ProductType>>(
                name: "products",
                resolve: async context =>
                {
                    return await productRepo.GetAll();
                });
        }
    }
}
