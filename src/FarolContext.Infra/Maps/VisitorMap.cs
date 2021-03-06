using FarolContext.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarolContext.Infra.Maps
{
    public class VisitorMap : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {
            builder.ToTable("Visitor");

            builder.HasKey(c => c.Id);

            builder.OwnsOne(m => m.Name, name =>
            {
                name.Property(n => n.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("varchar(150)");

                name.Property(n => n.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("varchar(150)");
            });

            builder.Property(m => m.Age)
            .IsRequired()
            .HasColumnType("datetime");

            builder.Property(m => m.Gender)
            .IsRequired()
            .HasConversion<string>();

            builder.OwnsOne(c => c.Document, cnpj =>
            {
                cnpj.Property(c => c.Number)
                .IsRequired()
                .HasColumnName("Cpf")
                .HasColumnType("varchar(11)");

                cnpj.Property(c => c.Type)
                .HasColumnName("DocumentType")
                .IsRequired();
            });

            builder.OwnsOne(c => c.Email, email =>
            {
                email.Property(c => c.Address)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("varchar(150)");
            });

            builder.OwnsOne(c => c.Contact, contact =>
            {
                contact.Property(c => c.Cellphone)
                .HasColumnName("Cellphone")
                .HasColumnType("varchar(12)");

                contact.Property(c => c.Telephone)
                .HasColumnName("Telephone")
                .HasColumnType("varchar(12)");
            });

           builder.OwnsOne(c => c.Address, adrress => {
                adrress.Property(c => c.Street)
                .HasColumnName("Street")
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.Number)
                .HasColumnName("Number")
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.Neighborhood)
                .HasColumnName("Neighborhood")
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.City)
                .HasColumnName("City")
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.State)
                .HasColumnName("State")
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.Country)
                .HasColumnName("Country")
                .HasColumnType("varchar(150)");
                adrress.Property(c => c.ZipCode)
                .HasColumnName("ZipCode")
                .HasColumnType("varchar(150)");
            });

            builder.Property(v => v.VisitDate)
            .IsRequired()
            .HasColumnType("datetime");
        }
    }
}