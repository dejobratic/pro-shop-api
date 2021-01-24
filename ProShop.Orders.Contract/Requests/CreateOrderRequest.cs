using ProShop.Contract.Requests;
using ProShop.Orders.Contract.Dtos;

namespace ProShop.Orders.Contract.Requests
{
    public class CreateOrderRequest :
        IRequest
    {
        public OrderDto Order { get; set; }
    }
}
