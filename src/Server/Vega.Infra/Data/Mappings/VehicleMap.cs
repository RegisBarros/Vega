using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Core.Models;

namespace Vega.Infra.Data.Mappings
{
    internal class VehicleMap : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(m => m.Id);

            builder.HasIndex(m => m.Id)
                .IsUnique(true);

            builder.Property(m => m.Id)
              .ValueGeneratedNever();

            builder.OwnsOne(m => m.Contact)
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.OwnsOne(m => m.Contact)
                .Property(m => m.Email)
                .HasMaxLength(255);

            builder.OwnsOne(m => m.Contact)
                .Property(m => m.Phone)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(m => m.LastUpdate)
                .IsRequired()
                .HasColumnType("smalldatetime");

            builder.HasOne(m => m.Model)
                .WithMany(m => m.Vehicles)
                .HasForeignKey(m => m.ModelId);
        }
    }
}