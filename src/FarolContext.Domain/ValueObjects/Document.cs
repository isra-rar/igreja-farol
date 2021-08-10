using FarolContext.Domain.Enums;
using FarolContext.Shared.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {

        public Document()
        {
            
        }
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;
            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}