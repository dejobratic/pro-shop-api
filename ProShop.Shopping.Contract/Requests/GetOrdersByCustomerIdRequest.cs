using ProShop.Contract.Requests;
using System;

namespace ProShop.Shopping.Contract.Requests
{
    public class GetOrdersByCustomerIdRequest :
        IRequest
    {
        public Guid CustomerId { get; set; }
    }
}
