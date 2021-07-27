using System.Collections.Generic;
using FarolContext.Shared.Entities;

namespace FarolContext.Domain.Entities
{
    public class Ministry : Entity
    {
        public string Name { get; private set; }
        public Church Church { get; private set; }
        public Member Leader { get; private set; }
        public IEnumerable<Member> Members { get; private set; }
    }
}