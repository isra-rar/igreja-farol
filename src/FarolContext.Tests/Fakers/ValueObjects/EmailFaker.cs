using Bogus;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Tests.Fakers.ValueObjects
{
    public class EmailFaker : Faker<Email>
    {
        public EmailFaker()
        {
            RuleFor(e => e.Address, f => f.Person.Email);
        }
    }
}