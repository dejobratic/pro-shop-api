using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Core.Services;
using ProShop.Web.Extensions;
using ProShop.Web.GraphQL.Types;

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
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "id"
                }),
                resolve: async context =>
                {
                    return await productRepo.Get(context.Arguments.GetId());
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
