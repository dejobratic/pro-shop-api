using GraphQL.Types;
using ProShop.Core.Models;

namespace ProShop.Web.GraphQL.Types
{
    public class ProductType :
        ObjectGraphType<Product>
    {
        public ProductType()
        {
            Name = "Product";
            Field(_ => _.Id).Description("Product id.");
            Field(_ => _.Name).Description("Product name.");
            Field(_ => _.Brand).Description("Product brand.");
            Field(_ => _.Category).Description("Product category.");
            Field(_ => _.Description).Description("Product description.");
            Field(_ => _.Price).Description("Product price.");
            Field(_ => _.Quantity).Description("Product quantity.");
        }
    }
}
