using ProShop.Contract.Requests;
using System;

namespace ProShop.Orders.Contract.Requests
{
    public class GetOrdersByCustomerIdRequest :
        IRequest
    {
        public Guid CustomerId { get; set; }
    }
}
