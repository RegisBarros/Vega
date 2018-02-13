using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Core.Application.Interfaces;
using Vega.Core.Dtos;

namespace Vega.Web.Controllers
{
    [Route("api/makes")]
    public class MakesController : Controller
    {
        private readonly IMakeApplicationService _makeApplicationService;

        public MakesController(IMakeApplicationService makeApplicationService)
        {
            _makeApplicationService = makeApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<MakeDto> makes = await _makeApplicationService.GetMakes();

            if (makes != null && makes.Any())
                return Ok(makes);

            return NotFound();
        }
    }
}
