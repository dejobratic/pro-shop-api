using ProShop.Contract.Requests;
using System;

namespace ProShop.Billing.Contract.Requests
{
    public class CompletePaymentRequest :
        IRequest
    {
        public Guid PaymentId { get; set; }
        public DateTime PaidAt { get; set; }
    }
}
