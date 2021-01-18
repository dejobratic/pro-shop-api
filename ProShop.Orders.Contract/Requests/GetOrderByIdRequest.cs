using ProShop.Contract.Requests;
using System;

namespace ProShop.Orders.Contract.Requests
{
    public class GetOrderByIdRequest :
        IRequest
    {
        public Guid OrderId { get; set; }
    }
}
