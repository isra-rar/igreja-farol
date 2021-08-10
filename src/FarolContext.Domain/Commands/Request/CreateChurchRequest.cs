using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Enums;
using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace FarolContext.Domain.Commands.Request
{
    public class CreateChurchRequest : Notifiable<Notification>, IRequest<GenericCommandResult<CreateChurchResponse>> , ICommand
    {
        public CreateChurchRequest(string name, string docNumber, EDocumentType type, string address, string cellphone, string telephone, string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Name = name;
            DocNumber = docNumber;
            Type = type;
            Address = address;
            Cellphone = cellphone;
            Telephone = telephone;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public string Name { get; set; }
        public string DocNumber { get; set; }
        public EDocumentType Type { get; set; }
        public string Address { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
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
                new Contract<CreateChurchRequest>()
                .Requires()
                .IsGreaterThan(Name, 3, "Name", "Nome da Igreja deve ser maior que 3 caracteres")
                .IsEmail(Address, "Email", "E-mail invalido")
                .IsNotNullOrEmpty(Street, "Street", "Nome da rua não pode ser Nulo ou Vazio")
                .IsNotNullOrEmpty(Number, "Number", "Numero não pode ser Nulo ou Vazio")
                .IsNotNullOrEmpty(Neighborhood, "Neighborhood", "Bairro não pode ser Nulo ou Vazio")
                .IsNotNullOrEmpty(City, "City", "Cidade não pode ser Nulo ou Vazio")
                .IsNotNullOrEmpty(State, "State", "Estado não pode ser Nulo ou Vazio")
                .IsNotNullOrEmpty(Country, "Country", "Pais não pode ser Nulo ou Vazio")
                .IsNotNullOrEmpty(ZipCode, "ZipCode", "CEP não pode ser Nulo ou Vazio")
            );
        }
    }
}