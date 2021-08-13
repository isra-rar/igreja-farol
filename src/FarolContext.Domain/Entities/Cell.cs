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
        public Cell(string name, Guid churchId, Guid leaderId, Guid supervisorId)
        {
            Name = name;
            ChurchId = churchId;
            LeaderId = leaderId;
            SupervisorId = supervisorId;
            _members = new List<Member>();
        }

        public string Name { get; private set; }
        public Guid ChurchId { get; private set; }
        public Guid LeaderId { get; private set; }
        public Guid SupervisorId { get; private set; }
        public Church Church { get; private set; }
        public IEnumerable<Member> Members { get { return _members.ToArray(); } }

        public void AddMemberToCell(Member member)
        {
            if (member == null)
            {
            }

            _members.Add(member);
        }
    }
}