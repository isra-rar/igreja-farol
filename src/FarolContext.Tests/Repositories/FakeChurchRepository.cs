using System;
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

        public IEnumerable<Cell> GetAllCells(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Member> GetAllMembers(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ministry> GetAllMinistries(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public Church GetById(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Church> GetAllChurchs()
        {
            throw new NotImplementedException();
        }
    }
}