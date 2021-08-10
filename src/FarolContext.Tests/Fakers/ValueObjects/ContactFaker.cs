using Bogus;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Tests.Fakers.ValueObjects
{
    public class ContactFaker : Faker<Contact>
    {
        public ContactFaker()
        {
            RuleFor(c => c.Cellphone, f => f.Phone.PhoneNumber());
            RuleFor(c => c.Telephone, f => f.Phone.PhoneNumber());
        }
    }
}