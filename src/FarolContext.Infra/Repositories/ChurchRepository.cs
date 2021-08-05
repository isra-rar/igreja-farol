using System.Collections.Generic;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;

namespace FarolContext.Infra.Repositories
{
    public class ChurchRepository : IChurchRepository
    {
        public void Create(Church church)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Church church)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Cell> GetAllCells(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Member> GetAllMembers(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ministry> GetAllMinistries(string id)
        {
            throw new System.NotImplementedException();
        }

        public Church GetById(string id)
        {
            throw new System.NotImplementedException();
        }

    }
}