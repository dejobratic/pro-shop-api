using GraphQL.Types;
using ProShop.Core.Services;
using ProShop.Web.GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Queries
{
    public class ProductQuery :
        ObjectGraphType
    {
        public ProductQuery(
            IProductRepository productRepo)
        {
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
