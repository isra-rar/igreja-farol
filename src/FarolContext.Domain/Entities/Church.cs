using System.Collections.Generic;
using System.Linq;
using FarolContext.Domain.ValueObjects;
using Flunt.Validations;

namespace FarolContext.Domain.Entities
{
    public class Church : Entity
    {
        private IList<Member> _members;
        private IList<Ministry> _ministries;
        private IList<Cell> _cells;

        public Church()
        {
            _members = new List<Member>();
            _ministries = new List<Ministry>();
            _cells = new List<Cell>();    
        }

        public Church(string name, Document document, Email email, Contact contact, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Contact = contact;
            Address = address;
            _members = new List<Member>();
            _ministries = new List<Ministry>();
            _cells = new List<Cell>();            
        }

        public string Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<Member> Members { get { return _members.ToArray(); } }
        public IEnumerable<Ministry> Ministries { get { return _ministries.ToArray(); } }
        public IEnumerable<Cell> Cells { get { return _cells.ToArray(); } }

        public void AddMinistryToChurch(Ministry ministry)
        {
            if (ministry == null)
            {
            }

            _ministries.Add(ministry);
        }
        public void AddCellToChurch(Cell cell)
        {
            if (cell == null)
            {
            }

            _cells.Add(cell);
        }
    }
}