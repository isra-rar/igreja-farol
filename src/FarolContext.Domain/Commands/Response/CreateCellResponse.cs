using System;
using FarolContext.Domain.Commands.Contracts;

namespace FarolContext.Domain.Commands.Response
{
    public class CreateCellResponse : ICommandResult
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public Guid ChurchId { get; set; }
        public Guid LeaderId { get; set; }
        public Guid SupervisorId { get; set; }
    }
}