using FarolContext.Shared.ValueObjects;

namespace FarolContext.Domain.ValueObjects
{
    public class Contact : ValueObject
    {
        public Phones Phones { get; private set; }
    }
}