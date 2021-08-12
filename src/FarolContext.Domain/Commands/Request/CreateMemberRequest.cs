using System;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Enums;
using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace FarolContext.Domain.Commands.Request
{
    public class CreateMemberRequest : Notifiable<Notification>, IRequest<GenericCommandResult<CreateMemberResponse>>, ICommand
    {
        public CreateMemberRequest(Guid churchId, string firstName, string lastName, DateTime age, EGender gender, string docNumber, EDocumentType type, string address, string cellphone, string telephone, EMemberType memberType, string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            ChurchId = churchId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            DocNumber = docNumber;
            Type = type;
            Address = address;
            Cellphone = cellphone;
            Telephone = telephone;
            MemberType = memberType;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public Guid ChurchId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Age { get; set; }
        public EGender Gender { get; set; }
        public string DocNumber { get; set; }
        public EDocumentType Type { get; set; }
        public string Address { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
        public EMemberType MemberType { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<CreateMemberRequest>()
                .Requires()
                .IsNotNull(ChurchId, "ChurchId", "Id da Igreja não pode ser nulo")
                .IsNotNullOrEmpty(FirstName, "FirstName", "Primeiro nome não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(LastName, "LastName", "Ultimo nome não pode ser nulo ou vazio")
                .IsNotNull(Age, "Age", "Idade não pode ser Nulo")
                .IsNotNull(Gender, "Gender", "Sexo não pode ser Nulo")
                .IsNotNull(Age, "Age", "Idade não pode ser Nulo")
                .IsGreaterOrEqualsThan(DocNumber, 11, "DocNumber", "CPF invalido")
                .IsNotNull(Type, "Type", "Tipo do Documento não pode ser Nulo")
                .IsEmail(Address, "Address", "E-mail invalido")
                .IsNotNull(MemberType, "MemberType", "Tipo do membro não pode ser Nulo")
            );
        }
    }
}