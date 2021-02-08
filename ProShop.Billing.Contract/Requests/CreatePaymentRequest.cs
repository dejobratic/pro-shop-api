using ProShop.Contract.Requests;
using System;

namespace ProShop.Billing.Contract.Requests
{
    public class CreatePaymentRequest :
        IRequest
    {
        public Guid OrderId { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
