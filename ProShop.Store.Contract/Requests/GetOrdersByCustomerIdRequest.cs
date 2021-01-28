using ProShop.Contract.Requests;
using System;

namespace ProShop.Store.Contract.Requests
{
    public class GetOrdersByCustomerIdRequest :
        IRequest
    {
        public Guid CustomerId { get; set; }
    }
}
