using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using FarolContext.Shared.Entities;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public abstract class People : Entity
    {
        protected People(Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Document = document;
            Email = email;
            Contact = contact;
            Address = address;

            AddNotifications(new Contract<People>()
            .Requires()
            .IsNotNull(Age, "People.Age", "Idade é obrigatório")
            .IsNotNull(Gender, "People.Gender", "Sexo é obrigatório"),
                name, document, email, contact, address);
        }

        public Name Name { get; private set; }
        public DateTime Age { get; private set; }
        public EGender Gender { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }
    }
}