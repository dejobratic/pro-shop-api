using GraphQL.Types;
using ProShop.Shopping.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types.Shopping
{
    public class OrderType :
        ObjectGraphType<OrderDto>
    {
        public OrderType()
        {
            Name = "Order";

            Field(_ => _.Id).Description("Order id.");
            Field<ListGraphType<OrderItemType>>(nameof(OrderDto.Items), "Order items.");
            Field<AddressType>(nameof(OrderDto.ShippingAddress), "Shipping address.");
            Field<PaymentType>(nameof(OrderDto.Payment), "Payment.");
            Field<CustomerType>(nameof(OrderDto.Customer), "Customer.");
        }
    }
}
