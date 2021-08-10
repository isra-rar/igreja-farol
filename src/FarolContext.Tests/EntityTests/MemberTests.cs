using System;
using Bogus;
using Bogus.Extensions.Brazil;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;
using Xunit;

namespace FarolContext.Tests
{
    public class MemberTests
    {
        [Fact]
        public void CreateMemberIsSucess()
        {
            var faker = new Faker("pt_BR");
            var newCNPJ = faker.Company.Cnpj().Replace(".", "").Replace("-", "").Replace("/", "");
            var newCPF = faker.Person.Cpf().Replace(".", "").Replace("-", "");

            var document = new Document(newCNPJ, EDocumentType.CNPJ);
            var email = new Email(faker.Person.Email);
            var contact = new Contact(faker.Phone.PhoneNumber(), faker.Phone.PhoneNumber());
            var address = new Address(faker.Address.StreetName(), faker.Address.BuildingNumber(),
             faker.Address.County(), faker.Address.City(), faker.Address.State(),
              faker.Address.Country(), faker.Address.ZipCode());
            var church = new Church("Farol", document, email, contact, address);

            // var member = new Member(EMemberType.PASTOR, church.Id, 
            // new Name(faker.Person.FirstName, faker.Person.LastName),
            // faker.Person.DateOfBirth, EGender.MEN,
            // new Document(newCPF, EDocumentType.CPF),
            // new Email(faker.Person.Email),
            // new Contact(faker.Phone.PhoneNumber(), faker.Phone.PhoneNumber()),
            // new Address(faker.Address.StreetName(), faker.Address.BuildingNumber(),
            //  faker.Address.County(), faker.Address.City(), faker.Address.State(),
            //   faker.Address.Country(), faker.Address.ZipCode()));

            //Assert.True(member.);
        }
    }
}