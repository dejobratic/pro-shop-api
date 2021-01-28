using ProShop.Contract.Requests;
using ProShop.Store.Contract.Dtos;

namespace ProShop.Store.Contract.Requests
{
    public class CreateOrderRequest :
        IRequest
    {
        public OrderDto Order { get; set; }
    }
}
