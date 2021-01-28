using ProShop.Contract.Requests;
using System;

namespace ProShop.Store.Contract.Requests
{
    public class GetProductByIdRequest :
        IRequest
    {
        public Guid ProductId { get; set; }
    }
}
