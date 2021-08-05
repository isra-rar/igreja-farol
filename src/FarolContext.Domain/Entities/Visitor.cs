using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Visitor : People
    {
        public Visitor(DateTime visitDate, Guid memberInvitedId, Guid churchId, Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address)
        : base(name, age, gender, document, email, contact, address)
        {
            VisitDate = visitDate;
            MemberInvitedId = memberInvitedId;
            ChurchId = churchId;

            // AddNotifications(new Contract<Visitor>()
            // .Requires()
            // .IsNotNull(Church, "Member.Church", "Não é possivel criar um Membro sem uma Igreja vinculada"), 
            // church, name, document, email, contact, address
            // );
        }

        public DateTime VisitDate { get; private set; }
        public Member MemberInvited { get; private set; }
        public Guid MemberInvitedId { get; private set; }
        public Church Church { get; private set; }
        public Guid ChurchId { get; private set; }
    }
}