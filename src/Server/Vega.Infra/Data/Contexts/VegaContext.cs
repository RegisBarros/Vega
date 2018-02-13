using Microsoft.EntityFrameworkCore;
using Vega.Core.Models;

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
    }
}
