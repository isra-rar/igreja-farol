using Bogus;
using Bogus.Extensions.Brazil;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Tests.Fakers.ValueObjects
{
    public class DocumentCPFFaker : Faker<Document>
    {
        public DocumentCPFFaker()
        {
            RuleFor(c => c.Number, f => f.Person.Cpf());
            RuleFor(c => c.Type, () => EDocumentType.CPF);
        }
    }
}