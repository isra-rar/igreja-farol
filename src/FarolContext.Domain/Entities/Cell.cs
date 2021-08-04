using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Cell : Entity
    {
        private IList<Member> _members;

        public Cell(string name, Guid churchId, Guid leaderId, Guid supervisorId)
        {
            Name = name;
            ChurchId = churchId;
            LeaderId = leaderId;
            SupervisorId = supervisorId;
            _members = new List<Member>();

            // AddNotifications(new Contract<Cell>()
            // .Requires()
            // .IsGreaterThan(Name, 3, "Cell.Name", "Nome da celulá deve ser maior que 3 caracteres")
            // .IsNotNull(Church, "Cell.Church", "Não é possivel criar uma celulá sem uma Igreja vinculada")
            // .IsNotNull(Leader, "Cell.Leader", "Não é possivel criar uma celulá sem Lider vinculado")
            // .IsNotNull(Supervisor, "Cell.Supervisor", "Não é possivel criar uma celulá sem Supervisor vinculado")
            // );
        }

        public string Name { get; private set; }
        public Guid ChurchId { get; private set; }
        public Guid LeaderId { get; private set; }
        public Guid SupervisorId { get; private set; }
        public Church Church { get; private set; }
        public Member Leader { get; private set; }
        public Member Supervisor { get; private set; }
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