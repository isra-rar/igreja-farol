using FarolContext.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarolContext.Infra.Maps
{
    public class CellMap : IEntityTypeConfiguration<Cell>
    {
        public void Configure(EntityTypeBuilder<Cell> builder)
        {
            builder.ToTable("Cell");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
            .IsRequired()
            .HasColumnType("varchar(120)");

            builder.HasMany(c => c.Members)
            .WithOne(c => c.Cell)
            .HasForeignKey(c => c.CellId)
            .IsRequired(false);
        }
    }
}