using FarolContext.Shared.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email()
        {
            
        }
        public Email(string address)
        {
            Address = address;
        }
        public string Address { get; private set; }

    }
}