using System;

namespace ProShop.Core.Models
{
    public class Entity
    {
        public Guid Id { get; }

        public Entity(
            Guid id)
        {
            Id = id;

            // TODO: add validation logic
        }

        // TODO: add equality operator overrides
    }
}
