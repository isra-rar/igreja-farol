using Bogus;
using FarolContext.Domain.Commands;
using Bogus.Extensions.Brazil;
using FarolContext.Domain.Enums;
using FarolContext.Domain.Handler;
using FarolContext.Tests.Repositories;
using Xunit;

namespace FarolContext.Tests.HandlerTests
{
    public class CreateChurchHandlerTests
    {
        private static Faker faker = new Faker("pt_BR");
        private readonly CreateChurchCommand _invalidCommand = new CreateChurchCommand("", "", EDocumentType.CNPJ, "", "", "", "", "", "", "", "", "", "");
        private readonly CreateChurchCommand _validCommand = new CreateChurchCommand("Farol", faker.Company.Cnpj().Replace(".", "").Replace("-", "").Replace("/", ""), EDocumentType.CNPJ, faker.Person.Email, faker.Address.StreetName(), faker.Phone.PhoneNumber(), faker.Phone.PhoneNumber(),
        faker.Address.BuildingNumber(), faker.Address.County(), faker.Address.City(), faker.Address.State(), faker.Address.Country(), faker.Address.ZipCode());

        private readonly CreateChurchRequestHandler _handler = new CreateChurchRequestHandler(new FakeChurchRepository());

        [Fact]
        public void Given_Invalid_Command_Must_Stop_Execution()
        {
            var handler = new CreateChurchRequestHandler(new FakeChurchRepository());
            var result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.Equal(result.Sucess, false);
        }

        [Fact]
        public void Given_Valid_Command_Must_Create_Church()
        {
            var result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.Equal(result.Sucess, true);
        }
    }
}