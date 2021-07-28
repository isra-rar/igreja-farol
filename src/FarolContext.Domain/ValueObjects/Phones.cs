using FarolContext.Shared.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.ValueObjects
{
    public class Phones : ValueObject
    {
        public Phones(string cellPhone, string telephone)
        {
            Cellphone = cellPhone;
            Telephone = telephone;

            AddNotifications(new Contract<Phones>()
            .Requires()
            .IsGreaterThan(Cellphone, 14, "Phones.Cellphone", "Numero de celular incorreto")
            .IsGreaterThan(Telephone, 13, "Phones.Cellphone", "Numero de telefone incorreto")
            );
        }

        public string Cellphone { get; private set; }
        public string Telephone { get; private set; }
    }
}