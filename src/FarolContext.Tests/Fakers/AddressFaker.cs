using Bogus;
using FarolContext.Domain.Entities;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Tests.Fakers
{
    public class AddressFaker : Faker<Address>
    {
        public AddressFaker()
        {
            RuleFor(c => c.Street, f => f.Address.StreetName());
            RuleFor(c => c.Number, f => f.Address.BuildingNumber());
            RuleFor(c => c.Neighborhood, f => f.Address.County());
            RuleFor(c => c.City, f => f.Address.City());
            RuleFor(c => c.State, f => f.Address.State());
            RuleFor(c => c.Country, f => f.Address.Country());
            RuleFor(c => c.ZipCode, f => f.Address.ZipCode());
        }
    }
}