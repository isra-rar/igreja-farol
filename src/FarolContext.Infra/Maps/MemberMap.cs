using FarolContext.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarolContext.Infra.Maps
{
    public class MemberMap : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("Member");

            builder.HasKey(c => c.Id);

            builder.OwnsOne(m => m.Name, name => {
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

            builder.Property(m => m.MemberType)
            .IsRequired()
            .HasConversion<string>();

            builder.OwnsOne(c => c.Document, cnpj => {
                cnpj.Property(c => c.Number)
                .IsRequired()
                .HasColumnName("Cpf")
                .HasColumnType("varchar(11)");

                cnpj.Property(c => c.Type)
                .HasColumnName("DocumentType")
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

            builder.HasOne(m => m.Church)
            .WithMany(m => m.Members)
            .HasForeignKey(m => m.ChurchId);

            builder.HasOne(m => m.Ministry)
            .WithMany(m => m.Members)
            .HasForeignKey(m => m.MinistryId);

            builder.HasOne(m => m.Cell)
            .WithMany(m => m.Members)
            .HasForeignKey(m => m.CellId);
        }
    }
}