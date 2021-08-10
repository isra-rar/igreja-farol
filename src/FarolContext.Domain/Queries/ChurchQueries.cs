using System;
using System.Linq;
using System.Linq.Expressions;
using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Queries
{
    public static class ChurchQueries
    {
        public static Expression<Func<Member, bool>> GetAllMembers(Guid id)
        {
            return x => x.ChurchId == id;
        }
        public static Expression<Func<Ministry, bool>> GetAllMinistries(Guid id)
        {
            return x => x.ChurchId == id;
        }
        public static Expression<Func<Cell, bool>> GetAllCells(Guid id)
        {
            return x => x.ChurchId == id;;
        }
    }
}