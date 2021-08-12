using System;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Enums;
using FarolContext.Domain.ValueObjects;

namespace FarolContext.Domain.Commands.Response
{
    public class CreateMemberResponse : ICommandResult
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Name Name { get; set; }
        public DateTime Age { get; set; }
        public EGender Gender { get; set; }
        public Document Document { get; set; }
        public Email Email { get; set; }
        public EMemberType MemberType { get; set; }
        public Guid ChurchId { get; set; }
    }
}