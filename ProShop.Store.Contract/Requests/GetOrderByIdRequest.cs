using ProShop.Contract.Requests;
using System;

namespace ProShop.Store.Contract.Requests
{
    public class GetOrderByIdRequest :
        IRequest
    {
        public Guid OrderId { get; set; }
    }
}
