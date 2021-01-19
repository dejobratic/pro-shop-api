using System;

namespace ProShop.Orders.Domain.Models
{
    public class Payment
    {
        public PaymentMethod Method { get; }
        public bool IsCompleted { get; }
        public DateTime CompletedAt { get; }

        public Payment(
            PaymentMethod method, 
            bool isCompleted = false, 
            DateTime? completedAt = null)
        {
            Method = method;
            IsCompleted = isCompleted;
            CompletedAt = completedAt ?? DateTime.MinValue;
        }

    }
}
