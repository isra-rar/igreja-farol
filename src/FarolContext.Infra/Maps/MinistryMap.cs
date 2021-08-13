using FarolContext.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarolContext.Infra.Maps
{
    public class MinistryMap : IEntityTypeConfiguration<Ministry>
    {
        public void Configure(EntityTypeBuilder<Ministry> builder)
        {
            builder.ToTable("Ministry");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
            .IsRequired()
            .HasColumnType("varchar(120)");

            builder.Property(c => c.LeaderId)
            .IsRequired();

            builder.HasMany(c => c.Members)
              .WithOne(c => c.Ministry)
              .HasForeignKey(c => c.MinistryId)
              .IsRequired(false);
        }
    }
}