using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Core.Models;

namespace Vega.Infra.Data.Mappings
{
    internal class ModelMap : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.ToTable("Models");

            builder.HasKey(m => m.Id);

            builder.HasIndex(m => m.Id)
                .IsUnique(true);

            builder.Property(m => m.Id)
              .ValueGeneratedNever();

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(m => m.Make)
                .WithMany(m => m.Models)
                .HasForeignKey(m => m.MakeId);
        }
    }
}
