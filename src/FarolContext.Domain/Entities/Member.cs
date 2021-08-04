using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Member : People
    {
        public Member(EMemberType memberType, Guid churchId, Guid ministryId, Guid cellId, Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address)
        : base(name, age, gender, document, email, contact, address)
        {
            MemberType = memberType;
            ChurchId = churchId;
            MinistryId = ministryId;
            CellId = cellId;

            // AddNotifications(new Contract<Member>()
            // .Requires()
            // .IsNotNull(Church, "Member.Church", "Não é possivel criar um Membro sem uma Igreja vinculada"),
            // church, name, document, email, contact, address
            // );
        }

        public EMemberType MemberType { get; private set; }
        public Guid ChurchId { get; private set; }
        public Church Church { get; private set; }
        public Guid MinistryId { get; private set; }
        public Ministry Ministry { get; private set; }
        public Guid CellId { get; private set; }
        public Cell Cell { get; set; }
    }
}