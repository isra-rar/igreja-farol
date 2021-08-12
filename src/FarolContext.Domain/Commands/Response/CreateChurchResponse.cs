using System;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Domain.Commands.Response
{
    public class CreateChurchResponse : ICommandResult
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public Document Document { get; set; }
    }
}