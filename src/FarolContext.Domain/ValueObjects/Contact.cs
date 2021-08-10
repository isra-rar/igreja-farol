using FarolContext.Shared.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.ValueObjects
{
    public class Contact : ValueObject
    {
        public Contact()
        {
            
        }
        public Contact(string cellPhone, string telephone)
        {
            Cellphone = cellPhone;
            Telephone = telephone;

            // AddNotifications(new Contract<Contact>()
            // .Requires()
            // .IsGreaterThan(Cellphone, 14, "Cellphone", "Numero de celular incorreto")
            // .IsGreaterThan(Telephone, 13, "Cellphone", "Numero de telefone incorreto")
            // );
        }

        public string Cellphone { get; private set; }
        public string Telephone { get; private set; }

    }
}