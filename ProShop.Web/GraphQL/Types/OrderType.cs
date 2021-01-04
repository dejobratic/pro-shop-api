using GraphQL.Types;
using ProShop.Core.Models;

namespace ProShop.Web.GraphQL.Types
{
    public class OrderType : 
        ObjectGraphType<Order>
    {
        public OrderType()
        {
            Name = "Order";

            Field(_ => _.Id).Description("Order id.");
            Field<ListGraphType<ProductType>>(nameof(Order.Items), "Order items.");
            Field<UserType>(nameof(Order.CreatedBy), "Order creator.");
        }
    }
}
