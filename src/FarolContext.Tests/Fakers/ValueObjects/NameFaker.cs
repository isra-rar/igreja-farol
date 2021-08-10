using Bogus;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Tests.Fakers.ValueObjects
{
    public class NameFaker : Faker<Name>
    {
        public NameFaker()
        {
            RuleFor(n => n.FirstName, f => f.Person.FirstName);
            RuleFor(n => n.LastName, f => f.Person.LastName);
        }
    }
}