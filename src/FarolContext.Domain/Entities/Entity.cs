using System;

namespace FarolContext.Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }
        public Guid Id { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}