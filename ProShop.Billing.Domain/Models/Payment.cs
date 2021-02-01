using ProShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProShop.Billing.Domain.Models
{
    public class Payment :
        AggregateRoot
    {
        private readonly List<PaymentStatus> _statuses;

        public Guid OrderId { get; }
        public string Method { get; }
        public decimal Amount { get;}
        public IReadOnlyList<PaymentStatus> Statuses => _statuses;

        public Payment(
            Guid orderId,
            string method,
            decimal amount,
            DateTime createdAt)
            : base(Guid.NewGuid())
        {
            OrderId = orderId;
            Method = method;
            Amount = amount;
            _statuses.Add(new PaymentStatus("Pending", createdAt));
        }

        public void Pay(DateTime paidAt)
        {
            if (_statuses.Select(s => s.Name).Contains("Completed"))
                throw new Exception("Already paid.");

            _statuses.Add(new PaymentStatus("Completed", paidAt));
        }
    }
}
