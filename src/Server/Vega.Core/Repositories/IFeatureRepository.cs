using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Core.Models;

namespace Vega.Core.Repositories
{
    public interface IFeatureRepository
    {
        Task<IEnumerable<Feature>> GetFeatures();
    }
}
