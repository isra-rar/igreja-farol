using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;
using FarolContext.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace FarolContext.Infra.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DataContext _context;

        public MemberRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void Update(Member member)
        {
            _context.Entry(member).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}