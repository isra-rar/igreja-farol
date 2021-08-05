using System.Collections.Generic;
using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Repositories
{
    public interface IChurchRepository
    {
        void Create(Church church);
        void Update(Church church);
        Church GetById(string id);
        IEnumerable<Member> GetAllMembers(string id);
        IEnumerable<Ministry> GetAllMinistries(string id);
        IEnumerable<Cell> GetAllCells(string id);
    }
}