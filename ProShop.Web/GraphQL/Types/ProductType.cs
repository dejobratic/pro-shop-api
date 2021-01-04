using GraphQL.Types;
using ProShop.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types
{
    public class ProductType :
        ObjectGraphType<ProductDto>
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
            Field(_ => _.QuantityInStock).Description("Product quantity in stock.");
            //Field<ListGraphType<ProductReviewType>>(nameof(Product.Reviews), "Product reviews.");
        }
    }
}
