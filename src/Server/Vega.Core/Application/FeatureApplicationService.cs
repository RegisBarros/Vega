using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Core.Application.Interfaces;
using Vega.Core.Dtos;
using Vega.Core.Models;
using Vega.Core.Repositories;

namespace Vega.Core.Application
{
    public class FeatureApplicationService : IFeatureApplicationService
    {
        private readonly IFeatureRepository _featureRepository;
        private readonly IMapper _mapper;

        public FeatureApplicationService(IFeatureRepository featureRepository, IMapper mapper)
        {
            _featureRepository = featureRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FeatureDto>> GetFeatures()
        {
            IEnumerable<Feature> features = await _featureRepository.GetFeatures();

            if (features == null)
                return null;

            return _mapper.Map<IEnumerable<FeatureDto>>(features);
        }
    }
}
