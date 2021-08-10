using System.Collections.Generic;
using Bogus;

using FarolContext.Domain.Entities;

using FarolContext.Tests.Fakers.ValueObjects;

namespace FarolContext.Tests.Fakers
{
    public class ChurchFaker : Faker<Church>
    {
        public ChurchFaker()
        {
            RuleFor(c => c.Name, f => f.Company.CompanyName());
            RuleFor(c => c.Document, () => new DocumentCNPJFaker().Generate());


            RuleFor(c => c.Email, () => new EmailFaker().Generate());
            RuleFor(c => c.Contact, () => new ContactFaker().Generate());

            RuleFor(c => c.Address, () => new AdrressFaker().Generate());

            RuleFor(c => c.Members, () => new List<Member>());
            RuleFor(c => c.Cells, () => new List<Cell>());
            RuleFor(c => c.Ministries, () => new List<Ministry>());
        }
    }
}