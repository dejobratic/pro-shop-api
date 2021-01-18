using GraphQL.Types;
using ProShop.Orders.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types.Orders
{
    public class ProductType :
        ObjectGraphType<ProductDto>
    {
        public ProductType()
        {
            Name = "OrderProduct";

            Field(_ => _.Id).Description("Product id.");
            Field(_ => _.Name).Description("Product name.");
        }
    }
}