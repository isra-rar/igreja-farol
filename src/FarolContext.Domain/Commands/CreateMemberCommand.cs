using System;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Enums;
using Flunt.Notifications;
using Flunt.Validations;

namespace FarolContext.Domain.Commands
{
    public class CreateMemberCommand : Notifiable<Notification>, ICommand
    {
        public CreateMemberCommand(Guid churchId, string firstName, string lastName, DateTime age, EGender gender, string docNumber, EDocumentType type, string address, string cellphone, string telephone, EMemberType memberType)
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

        public void Validate()
        {
            AddNotifications(
                new Contract<CreateMemberCommand>()
                .Requires()
                .IsNotNull(ChurchId, "ChurchId", "Id da Igreja não pode ser nulo")
                .IsNotNullOrEmpty(FirstName, "FirstName", "Primeiro nome não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(LastName, "LastName", "Ultimo nome não pode ser nulo ou vazio")
                .IsNotNull(Age, "Age", "Idade não pode ser Nulo")
                .IsNotNull(Gender, "Gender", "Sexo não pode ser Nulo")
                .IsNotNull(Age, "Age", "Idade não pode ser Nulo")
                .IsGreaterThan(DocNumber, 11, "DocNumber", "CPF invalido")
                .IsNotNull(Type, "Type", "Tipo do Documento não pode ser Nulo")
                .IsEmail(Address, "Address", "E-mail invalido")
                .IsNotNull(MemberType, "MemberType", "Tipo do membro não pode ser Nulo")
            );
        }
    }
}