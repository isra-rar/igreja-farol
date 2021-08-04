using FarolContext.Domain.Entities;
using FarolContext.Infra.Maps;
using Microsoft.EntityFrameworkCore;

namespace FarolContext.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<Church> Churches { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Ministry> Ministries { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new ChurchMap());
        }
    }
}