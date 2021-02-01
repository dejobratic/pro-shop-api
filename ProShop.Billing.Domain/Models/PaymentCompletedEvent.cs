using ProShop.Core.Models;
using System;

namespace ProShop.Billing.Domain.Models
{
    public class PaymentCompletedEvent :
        IDomainEvent
    {
        public Guid OrderId { get; }
        public DateTime PaidAt { get; }

        public PaymentCompletedEvent(
            Guid orderId, 
            DateTime paidAt)
        {
            OrderId = orderId;
            PaidAt = paidAt;
        }
    }
}
