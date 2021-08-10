using System;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Enums;

namespace FarolContext.Domain.Commands.Response
{
    public class CreateChurchResponse : ICommandResult
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public string DocNumber { get; set; }
        public EDocumentType Type { get; set; }
    }
}