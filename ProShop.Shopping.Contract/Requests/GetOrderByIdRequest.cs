using ProShop.Contract.Requests;
using System;

namespace ProShop.Shopping.Contract.Requests
{
    public class GetOrderByIdRequest :
        IRequest
    {
        public Guid OrderId { get; set; }
    }
}
