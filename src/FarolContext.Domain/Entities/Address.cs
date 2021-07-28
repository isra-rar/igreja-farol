using FarolContext.Shared.Entities;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Address : Entity
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract<Address>()
            .Requires()
            .IsGreaterThan(Street, 3, "Address.Street", "Nome da rua deve ser maior que 3 caracteres")
            .IsGreaterThan(Neighborhood, 3, "Address.Neighborhood", "Nome do Bairro deve ser maior que 3 caracteres")
            .IsGreaterThan(City, 3, "Address.City", "Nome da Cidade deve ser maior que 3 caracteres")
            .IsGreaterThan(State, 3, "Address.State", "Nome do Estado deve ser maior que 3 caracteres")
            .IsGreaterThan(Country, 3, "Address.Country", "Nome do Pais deve ser maior que 3 caracteres")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}