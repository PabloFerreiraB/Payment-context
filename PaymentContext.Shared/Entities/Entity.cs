using PaymentContext.Shared.ValueObjects;
using System;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : ValueObject
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
