using System;

namespace ProShop.Orders.Domain.Models
{
    public class Payment
    {
        public string Method { get; }
        public bool IsCompleted { get; }
        public DateTime CompletedAt { get; }

        public Payment(
            string method, 
            bool isCompleted, 
            DateTime completedAt)
        {
            Method = method;
            IsCompleted = isCompleted;
            CompletedAt = completedAt;
        }

    }
}
