using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Ministry : Entity
    {
        private IList<Member> _members;

        public Ministry()
        {
            _members = new List<Member>();
        }
        public Ministry(string name, Guid churchId, Guid leaderId)
        {
            Name = name;
            ChurchId = churchId;
            LeaderId = leaderId;
            _members = new List<Member>();
        }

        public string Name { get; private set; }
        public Guid ChurchId { get; private set; }
        public Guid LeaderId { get; private set; }
        public Church Church { get; private set; }
        public IEnumerable<Member> Members { get { return _members.ToArray(); } }

        public void AddMemberToMinistry(Member member)
        {
            if (member == null)
            {
                // AddNotifications(new Contract<Ministry>()
                // .Requires()
                // .IsNotNull(member, "Member", "Objeto Membro está nulo")
                // );
            }

            _members.Add(member);
        }
    }
}