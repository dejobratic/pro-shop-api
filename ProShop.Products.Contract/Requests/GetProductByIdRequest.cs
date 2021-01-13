using ProShop.Contract.Requests;
using System;

namespace ProShop.Products.Contract.Requests
{
    public class GetProductByIdRequest :
        IRequest
    {
        public Guid ProductId { get; set; }
    }
}
