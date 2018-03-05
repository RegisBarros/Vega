using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Core.Models;

namespace Vega.Infra.Data.Mappings
{
    public class VehicleFeatureMap : IEntityTypeConfiguration<VehicleFeature>
    {
        public void Configure(EntityTypeBuilder<VehicleFeature> builder)
        {
            builder.ToTable("VehicleFeatures");

            builder.HasKey(vf => new { vf.VehicleId, vf.FeatureId });
        }
    }
}