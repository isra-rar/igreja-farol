using Bogus;
using Bogus.Extensions.Brazil;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Xunit;

namespace FarolContext.Tests.CommandTests
{
    public class CreateChurchCommandTests
    {
        private static Faker faker = new Faker("pt_BR");
        private readonly CreateChurchRequest _invalidCommand = new CreateChurchRequest("", "", EDocumentType.CNPJ, "", "", "", "", "", "", "", "", "", "");
        private readonly CreateChurchRequest _validCommand = new CreateChurchRequest("Farol", faker.Company.Cnpj().Replace(".", "").Replace("-", "").Replace("/", ""), EDocumentType.CNPJ, faker.Person.Email, faker.Address.StreetName(), faker.Phone.PhoneNumber(), faker.Phone.PhoneNumber(),
        faker.Address.BuildingNumber(), faker.Address.County(), faker.Address.City(), faker.Address.State(), faker.Address.Country(), faker.Address.ZipCode());

        public CreateChurchCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [Fact]
        public void Given_Invalid_Church() => Assert.Equal(_invalidCommand.IsValid, false);

        [Fact]
        public void Given_Valid_Church() => Assert.Equal(_validCommand.IsValid, true);

    }
}