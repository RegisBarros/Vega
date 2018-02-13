using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Core.Dtos;

namespace Vega.Core.Application.Interfaces
{
    public interface IFeatureApplicationService
    {
        Task<IEnumerable<FeatureDto>> GetFeatures();
    }
}
