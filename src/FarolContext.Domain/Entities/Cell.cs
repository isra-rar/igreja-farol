using System.Collections.Generic;
using FarolContext.Shared.Entities;

namespace FarolContext.Domain.Entities
{
    public class Cell : Entity
    {
        public string Name { get; private set; }
        public Church Church { get; private set; }
        public Member Leader { get; private set; }
        public Member Supervisor { get; private set; }
        public IEnumerable<Member> Members { get; private set; }
    }
}