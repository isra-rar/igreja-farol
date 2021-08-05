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

            builder.HasOne(c => c.Church)
             .WithMany(c => c.Ministries)
             .HasForeignKey(c => c.ChurchId);

            builder.HasOne(c => c.Leader)
          .WithOne(c => c.Ministry)
          .HasForeignKey<Member>(b => b.Id);

            builder.HasMany(c => c.Members)
              .WithOne(c => c.Ministry)
              .HasForeignKey(c => c.MinistryId);
        }
    }
}