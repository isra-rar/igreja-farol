using FarolContext.Shared.ValueObjects;

namespace FarolContext.Domain.ValueObjects
{
    public class Contact : ValueObject
    {
        public Contact(Phones phones)
        {
            Phones = phones;

            AddNotifications(phones);
        }
        public Phones Phones { get; private set; }

    }
}