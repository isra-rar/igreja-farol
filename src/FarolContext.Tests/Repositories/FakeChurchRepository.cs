using System.Collections.Generic;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;

namespace FarolContext.Tests.Repositories
{
    public class FakeChurchRepository : IChurchRepository
    {
        public void Create(Church church)
        {
            
        }
        public void Update(Church church)
        {
            
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