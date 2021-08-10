using Bogus;
using Bogus.Extensions.Brazil;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Tests.Fakers.ValueObjects
{
    public class DocumentCNPJFaker : Faker<Document>
    {
        public DocumentCNPJFaker()
        {
            RuleFor(c => c.Number, f => f.Company.Cnpj());
            RuleFor(c => c.Type, () => EDocumentType.CNPJ);
        }
    }
}