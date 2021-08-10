using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Visitor : Entity
    {
        public Visitor()
        {
            
        }
        public Visitor(Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address, DateTime visitDate, Guid memberInvitedId, Guid churchId)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Document = document;
            Email = email;
            Contact = contact;
            Address = address;
            VisitDate = visitDate;
            MemberInvitedId = memberInvitedId;
            ChurchId = churchId;
        }

        public Name Name { get; private set; }
        public DateTime Age { get; private set; }
        public EGender Gender { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }
        public DateTime VisitDate { get; private set; }
        public Guid? MemberInvitedId { get; private set; }
        public Guid ChurchId { get; private set; }
        public Member MemberInvited { get; private set; }
        public Church Church { get; private set; }
    }
}