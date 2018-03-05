using Microsoft.EntityFrameworkCore;
using Vega.Core.Models;
using Vega.Infra.Data.Mappings;

namespace Vega.Infra.Data.Contexts
{
    public class VegaContext : DbContext
    {
        public VegaContext(DbContextOptions<VegaContext> options)
            : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ModelMap());
            modelBuilder.ApplyConfiguration(new MakeMap());
            modelBuilder.ApplyConfiguration(new FeatureMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
            modelBuilder.ApplyConfiguration(new VehicleFeatureMap());
        }
    }
}
