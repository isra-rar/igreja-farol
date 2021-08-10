using System;
using System.Collections.Generic;
using System.Linq;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Queries;
using FarolContext.Domain.Repositories;
using FarolContext.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace FarolContext.Infra.Repositories
{
    public class ChurchRepository : IChurchRepository
    {
        private readonly DataContext _context;

        public ChurchRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Church church)
        {
            _context.Churches.Add(church);
            _context.SaveChanges();
        }

        public void Update(Church church)
        {
            _context.Entry(church).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public IEnumerable<Cell> GetAllCells(Guid id)
        {
            return _context
            .Cells.AsNoTracking().Where(ChurchQueries.GetAllCells(id))
            .OrderBy(x => x.CreationDate);
        }

        public IEnumerable<Member> GetAllMembers(Guid id)
        {
            return _context
            .Members.AsNoTracking().Where(ChurchQueries.GetAllMembers(id))
            .OrderBy(x => x.CreationDate);
        }

        public IEnumerable<Ministry> GetAllMinistries(Guid id)
        {
            return _context
            .Ministries.AsNoTracking().Where(ChurchQueries.GetAllMinistries(id))
            .OrderBy(x => x.CreationDate);
        }

        public Church GetById(Guid id)
        {
            return _context.Churches.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Church> GetAllChurchs()
        {
            return _context.Churches.AsNoTracking().OrderBy(x => x.CreationDate);
        }
    }
}