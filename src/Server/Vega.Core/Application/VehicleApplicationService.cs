using System.Threading.Tasks;
using Vega.Core.Application.Interfaces;
using Vega.Core.Dtos;
using Vega.Core.Models;
using Vega.Core.Repositories;

namespace Vega.Core.Application
{
    public class VehicleApplicationService : IVehicleApplicationService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleApplicationService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task Create(VehicleDto vehicleDto)
        {
            var vehicle = Vehicle.Create(vehicleDto.ModelId, vehicleDto.ContactName,
                vehicleDto.ContactPhone, vehicleDto.ContactEmail, vehicleDto.Features);

            await _vehicleRepository.Create(vehicle);
        }
    }
}