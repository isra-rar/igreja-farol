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
        }

        public string Cellphone { get; private set; }
        public string Telephone { get; private set; }

    }
}