using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;
using FarolContext.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace FarolContext.Infra.Repositories
{
    public class CellRepository : ICellRepository
    {
        private readonly DataContext _context;

        public CellRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Cell cell)
        {
            _context.Cells.Add(cell);
            _context.SaveChanges();
        }

        public void Update(Cell cell)
        {
            _context.Entry(cell).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}