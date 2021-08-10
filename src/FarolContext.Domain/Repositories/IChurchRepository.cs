using System;
using System.Collections.Generic;
using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Repositories
{
    public interface IChurchRepository
    {
        void Create(Church church);
        void Update(Church church);
        Church GetById(Guid id);
        IEnumerable<Church> GetAllChurchs();
        IEnumerable<Member> GetAllMembers(Guid id);
        IEnumerable<Ministry> GetAllMinistries(Guid id);
        IEnumerable<Cell> GetAllCells(Guid id);
    }
}