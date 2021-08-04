using System;
using System.Linq;
using System.Linq.Expressions;
using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Queries
{
    public static class ChurchQueries
    {
        public static Expression<Func<Church, bool>> GetById(string id)
        {
            return x => x.Id.Equals(id);
        }
        public static Expression<Func<Church, bool>> GetAllMembers(string id)
        {
            return x => x.Members.All(m => m.ChurchId.Equals(id));
        }
        public static Expression<Func<Church, bool>> GetAllMinistries(string id)
        {
            return x => x.Ministries.All(m => m.ChurchId.Equals(id));
        }
        public static Expression<Func<Church, bool>> GetAllCells(string id)
        {
            return x => x.Cells.All(m => m.ChurchId.Equals(id));
        }

    }
}