using System;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Member : People
    {
        public Member(Church church, EMemberType memberType, Name name, DateTime age, EGender gender, Document document, Email email, Contact contact, Address address, Ministry ministry, Cell cell)
        : base(name, age, gender, document, email, contact, address)
        {
            Church = church;
            MemberType = memberType;
            Ministry = ministry;
            Cell = cell;

            // AddNotifications(new Contract<Member>()
            // .Requires()
            // .IsNotNull(Church, "Member.Church", "Não é possivel criar um Membro sem uma Igreja vinculada"),
            // church, name, document, email, contact, address
            // );
        }

        public Church Church { get; private set; }
        public EMemberType MemberType { get; private set; }
        public Ministry Ministry { get; private set; }
        public Cell Cell { get; private set; }
    }
}