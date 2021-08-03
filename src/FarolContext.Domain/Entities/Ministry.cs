using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Ministry : Entity
    {
        private  IList<Member> _members;

        public Ministry(string name, Church church, Member leader)
        {
            Name = name;
            Church = church;
            Leader = leader;
            _members = new List<Member>();

            // AddNotifications(new Contract<Ministry>()
            // .Requires()
            // .IsGreaterThan(Name, 3, "Ministry.Name", "Nome do Ministerio deve ser maior que 3 caracteres")
            // .IsNotNull(Church, "Ministry.Church", "Não é possivel criar um Ministerio sem uma Igreja vinculada")
            // .IsNotNull(Leader, "Ministry.Leader", "Não é possivel criar uma Ministerio sem Lider vinculado")
            // );
        }

        public string Name { get; private set; }
        public Church Church { get; private set; }
        public Member Leader { get; private set; }
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