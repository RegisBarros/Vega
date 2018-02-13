using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Core.Application.Interfaces;
using Vega.Core.Dtos;

namespace Vega.Web.Controllers
{
    [Route("api/features")]
    public class FeaturesController : Controller
    {
        private readonly IFeatureApplicationService _featureApplicationService;

        public FeaturesController(IFeatureApplicationService featureApplicationService)
        {
            _featureApplicationService = featureApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<FeatureDto> features = await _featureApplicationService.GetFeatures();

            if (features != null && features.Any())
                return Ok(features);

            return NotFound();
        }
    }
}
