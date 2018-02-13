using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Core.Application.Interfaces;
using Vega.Core.Dtos;
using Vega.Core.Models;
using Vega.Core.Repositories;

namespace Vega.Core.Application
{
    public class MakeApplicationService : IMakeApplicationService
    {
        private readonly IMakeRepository _makeRepository;
        private readonly IMapper _mapper;

        public MakeApplicationService(IMakeRepository makeRepository, IMapper mapper)
        {
            _makeRepository = makeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MakeDto>> GetMakes()
        {
            IEnumerable<Make> makes = await _makeRepository.GetMakes();

            if (makes == null)
                return null;

            return _mapper.Map<IEnumerable<MakeDto>>(makes);
        }
    }
}
