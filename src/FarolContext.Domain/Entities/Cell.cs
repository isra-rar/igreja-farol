using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Cell : Entity
    {
        private IList<Member> _members;

        public Cell()
        {
            _members = new List<Member>();
        }
        public Cell(string name, Guid churchId)
        {
            Name = name;
            ChurchId = churchId;
            _members = new List<Member>();
        }

        public string Name { get; private set; }
        public Guid ChurchId { get; private set; }
        public Church Church { get; private set; }
        public IEnumerable<Member> Members { get { return _members.ToArray(); } }

        public void AddMemberToCell(Member member)
        {
            if (member == null)
            {
                // AddNotifications(new Contract<Cell>()
                // .Requires()
                // .IsNotNull(member, "Member", "Objeto Membro está nulo")
                // );
            }

            _members.Add(member);
        }
    }
}