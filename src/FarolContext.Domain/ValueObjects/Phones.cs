using FarolContext.Shared.ValueObjects;

namespace FarolContext.Domain.ValueObjects
{
    public class Phones : ValueObject
    {
        public string CellPhone { get; private set; }
        public string Telephone { get; private set; }
    }
}