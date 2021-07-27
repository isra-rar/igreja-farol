using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using FarolContext.Shared.Entities;

namespace FarolContext.Domain.Entities
{
    public abstract class People : Entity
    {
        public Name Name { get; private set; }
        public DateTime Age { get; private set; }
        public EGender Gender { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }
    }
}