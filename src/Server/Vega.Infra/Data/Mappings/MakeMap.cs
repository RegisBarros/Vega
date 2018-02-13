using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Core.Models;

namespace Vega.Infra.Data.Mappings
{
    public class MakeMap : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.ToTable("Makes");

            builder.HasKey(m => m.Id);

            builder.HasIndex(m => m.Id)
               .IsUnique(true);

            builder.Property(m => m.Id)
              .ValueGeneratedNever();

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasMany(m => m.Models)
                .WithOne(m => m.Make)
                .HasForeignKey(m => m.MakeId);
        }
    }
}
