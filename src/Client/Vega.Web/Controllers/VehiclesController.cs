using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vega.Core.Application.Interfaces;
using Vega.Core.Dtos;

namespace Vega.Web.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IVehicleApplicationService _vehicleApplicationService;

        public VehiclesController(IVehicleApplicationService vehicleApplicationService)
        {
            _vehicleApplicationService = vehicleApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VehicleDto vehicle)
        {
            await _vehicleApplicationService.Create(vehicle);

            return Ok(vehicle);
        }
    }
}