using FarolContext.Shared.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name()
        {
        }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}