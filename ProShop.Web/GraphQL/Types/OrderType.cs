using GraphQL.Types;
using ProShop.Orders.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types
{
    public class OrderType : 
        ObjectGraphType<OrderDto>
    {
        public OrderType()
        {
            Name = "Order";

            Field(_ => _.Id).Description("Order id.");
            Field<ListGraphType<ProductType>>(nameof(OrderDto.Items), "Order items.");
            //Field<UserType>(nameof(Order.CreatedBy), "Order creator.");
        }
    }
}
