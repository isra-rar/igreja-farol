using FarolContext.Shared.ValueObjects;

namespace FarolContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }
        public string Address { get; private set; }

    }
}