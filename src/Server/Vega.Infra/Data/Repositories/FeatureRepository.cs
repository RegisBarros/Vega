using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Core.Models;
using Vega.Core.Repositories;
using Vega.Infra.Data.Contexts;

namespace Vega.Infra.Data.Repositories
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly VegaContext _context;

        public FeatureRepository(VegaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Feature>> GetFeatures()
        {
            return await _context.Features.ToListAsync();
        }
    }
}
