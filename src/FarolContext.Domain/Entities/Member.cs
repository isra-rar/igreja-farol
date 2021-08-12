using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Member : Entity
    {
        private IList<Visitor> _visitors;

        public Member()
        {
            _visitors = new List<Visitor>();
        }

        public Member(Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address, EMemberType memberType, Guid churchId)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Document = document;
            Email = email;
            Contact = contact;
            Address = address;
            MemberType = memberType;
            ChurchId = churchId;
            _visitors = new List<Visitor>();
        }

        public Name Name { get; private set; }
        public DateTime Age { get; private set; }
        public EGender Gender { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }

        public EMemberType MemberType { get; private set; }
        public Church Church { get; private set; }
        public Ministry Ministry { get; private set; }
        public Cell Cell { get; private set; }
        public Guid ChurchId { get; private set; }
        public Guid? CellId { get; private set; }
        public Guid? MinistryId { get; private set; }
        public IEnumerable<Visitor> Visitors { get { return _visitors.ToArray(); } }
    }
}