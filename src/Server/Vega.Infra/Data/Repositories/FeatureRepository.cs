using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var features = await _context.Features.ToListAsync();

            if (features == null || !features.Any())
                return CreateFeatures();

            return features;
        }

        private IEnumerable<Feature> CreateFeatures()
        {
            var feature1 = new Feature()
            {
                Name = "Feature 1"
            };

            var feature2 = new Feature()
            {
                Name = "Feature 2"
            };
            var feature3 = new Feature()
            {
                Name = "Feature 3"
            };

            _context.Features.Add(feature1);
            _context.Features.Add(feature2);
            _context.Features.Add(feature3);

            _context.SaveChanges();

            return new List<Feature>() { feature1, feature2, feature3 };
        }
    }
}
