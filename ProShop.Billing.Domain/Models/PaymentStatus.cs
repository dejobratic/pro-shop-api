using ProShop.Core.Models;
using System;

namespace ProShop.Billing.Domain.Models
{
    public class PaymentStatus :
        Entity<Guid>
    {
        public string Name { get; }
        public DateTime CreatedAt { get;}

        public PaymentStatus(
            string name,
            DateTime createdAt)
            : base(Guid.NewGuid())
        {
            Name = name;
            CreatedAt = createdAt;
        }
    }
}
