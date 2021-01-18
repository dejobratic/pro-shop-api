using GraphQL.Types;
using ProShop.Orders.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types.Orders
{
    public class OrderItemType :
        ObjectGraphType<OrderItemDto>
    {
        public OrderItemType()
        {
            Name = "OrderItem";

            Field(_ => _.Id).Description("Order item id.");
            Field<ProductType>(nameof(OrderItemDto.Product), "Order item product.");
            Field(_ => _.Price).Description("Order item unit price.");
            Field(_ => _.Quantity).Description("Order item quantity.");
        }
    }
}
