using System;

namespace ProShop.Core.Models
{
    public class AggregateRoot :
        Entity<Guid>
    {
        public AggregateRoot(Guid id)
            : base(id)
        {
        }
    }
}
