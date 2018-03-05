using System.Threading.Tasks;
using Vega.Core.Models;
using Vega.Core.Repositories;
using Vega.Infra.Data.Contexts;

namespace Vega.Infra.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VegaContext _context;

        public VehicleRepository(VegaContext context)
        {
            _context = context;
        }

        public async Task Create(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);

            await _context.SaveChangesAsync();
        }
    }
}