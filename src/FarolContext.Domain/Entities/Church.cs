using System.Collections.Generic;
using FarolContext.Domain.ValueObjects;
using FarolContext.Shared.Entities;

namespace FarolContext.Domain.Entities
{
    public class Church : Entity
    {
        public string Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }
        public List<Member> Members { get; private set; }
        public List<Ministry> Ministries { get; private set; }
        public List<Cell> Cells { get; private set; }
    }
}