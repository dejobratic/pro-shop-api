using ProShop.Core.Exceptions;
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
        public decimal Amount { get; }
        public IReadOnlyList<PaymentStatus> Statuses => _statuses;

        public Payment(
            Guid orderId,
            string method,
            decimal amount,
            DateTime createdAt)
            : this(Guid.NewGuid(), orderId, method, amount, new List<PaymentStatus>())
        {
            AddPaymentStatus("Pending", createdAt);
        }

        public Payment(
            Guid id,
            Guid orderId,
            string method,
            decimal amount,
            IEnumerable<PaymentStatus> statuses)
            : base(id)
        {
            OrderId = orderId;
            Method = method;
            Amount = amount;
            _statuses = statuses.ToList();
        }

        public void Pay(DateTime paidAt)
        {
            if (_statuses.Select(s => s.Name).Contains("Completed"))
                throw new InvalidDomainOperationException();

            AddPaymentStatus("Completed", paidAt);
        }

        private void AddPaymentStatus(string name, DateTime createdAt)
            => _statuses.Add(new PaymentStatus(name, createdAt));
    }
}
