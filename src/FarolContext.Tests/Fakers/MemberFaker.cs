using System;
using Bogus;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Enums;
using FarolContext.Tests.Fakers.ValueObjects;

namespace FarolContext.Tests.Fakers
{
    public class MemberFaker : Faker<Member>
    {
        public MemberFaker()
        {
            RuleFor(m => m.Name, () => new NameFaker().Generate());
            RuleFor(m => m.Age, f => f.Person.DateOfBirth);
            RuleFor(m => m.Gender, f => f.PickRandom<EGender>());
            RuleFor(m => m.Document, () => new DocumentCPFFaker().Generate());
            RuleFor(m => m.Email, () => new EmailFaker().Generate());
            RuleFor(m => m.Contact, () => new ContactFaker().Generate());
            RuleFor(m => m.Address, () => new AdrressFaker().Generate());
            RuleFor(m => m.MemberType, f => f.PickRandom<EMemberType>());
        }
    }
}