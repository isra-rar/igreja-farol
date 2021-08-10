using FarolContext.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarolContext.Infra.Maps
{
    public class ChurchMap : IEntityTypeConfiguration<Church>
    {
        public void Configure(EntityTypeBuilder<Church> builder)
        {
            builder.ToTable("Church");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
            .IsRequired()
            .HasColumnType("varchar(120)");

            builder.OwnsOne(c => c.Document, cnpj => {
                cnpj.Property(c => c.Number)
                .IsRequired()
                .HasColumnName("Cnpj")
                .HasColumnType("varchar(14)");

                cnpj.Property(c => c.Type)
                .HasColumnName("DocumentType")
                .HasConversion<string>()
                .IsRequired();
            });

            builder.OwnsOne(c => c.Email, email => {
                email.Property(c => c.Address)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("varchar(150)");
            });

            builder.OwnsOne(c => c.Contact, contact => {
                contact.Property(c => c.Cellphone)
                .HasColumnName("Cellphone")
                .HasColumnType("varchar(12)");

                contact.Property(c => c.Telephone)
                .HasColumnName("Telephone")
                .HasColumnType("varchar(12)");
            });

            builder.OwnsOne(c => c.Address, adrress => {

                adrress.Property(c => c.Street)
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.Number)
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.Neighborhood)
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.City)
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.State)
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.Country)
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.ZipCode)
                .HasColumnType("varchar(150)");
            });

            builder.HasMany(c => c.Members)
            .WithOne(c => c.Church)
            .HasForeignKey(c => c.ChurchId);

            builder.HasMany(c => c.Ministries)
            .WithOne(c => c.Church)
            .HasForeignKey(c => c.ChurchId);

            builder.HasMany(c => c.Cells)
            .WithOne(c => c.Church)
            .HasForeignKey(c => c.ChurchId);
        }
    }
}