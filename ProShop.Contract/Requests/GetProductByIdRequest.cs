using System;

namespace ProShop.Contract.Requests
{
    public class GetProductByIdRequest :
        IRequest
    {
        public Guid ProductId { get; set; }
    }
}
