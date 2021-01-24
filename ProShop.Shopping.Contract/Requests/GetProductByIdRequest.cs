using ProShop.Contract.Requests;
using System;

namespace ProShop.Shopping.Contract.Requests
{
    public class GetProductByIdRequest :
        IRequest
    {
        public Guid ProductId { get; set; }
    }
}
