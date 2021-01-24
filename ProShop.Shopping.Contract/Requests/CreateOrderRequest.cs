using ProShop.Contract.Requests;
using ProShop.Shopping.Contract.Dtos;

namespace ProShop.Shopping.Contract.Requests
{
    public class CreateOrderRequest :
        IRequest
    {
        public OrderDto Order { get; set; }
    }
}
