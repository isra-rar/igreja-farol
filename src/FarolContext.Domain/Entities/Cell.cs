using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Cell : Entity
    {
        private  IList<Member> _members;
        public Cell(string name, Church church, Member leader, Member supervisor)
        {
            Name = name;
            Church = church;
            Leader = leader;
            Supervisor = supervisor;
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