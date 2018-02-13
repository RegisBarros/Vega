using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Core.Models;
using Vega.Core.Repositories;
using Vega.Infra.Data.Contexts;

namespace Vega.Infra.Data.Repositories
{
    public class MakeRepository : IMakeRepository
    {
        private readonly VegaContext _context;

        public MakeRepository(VegaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await _context.Makes
                .Include(m => m.Models)
                .ToListAsync();
        }
    }
}
