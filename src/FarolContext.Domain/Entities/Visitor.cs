using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Visitor : People
    {
        public Visitor(Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address, Member memberInvited, Church church) 
        : base(name, age, gender, document, email, contact, address)
        {
            VisitDate = DateTime.Now;
            MemberInvited = memberInvited;
            Church = church;

            // AddNotifications(new Contract<Visitor>()
            // .Requires()
            // .IsNotNull(Church, "Member.Church", "Não é possivel criar um Membro sem uma Igreja vinculada"), 
            // church, name, document, email, contact, address
            // );
        }

        public DateTime VisitDate { get; private set; }
        public Member MemberInvited { get; private set; }
        public Church Church { get; private set; }
    }
}