using AutoMapper;
using Vega.Core.Dtos;
using Vega.Core.Models;

namespace Vega.Core.AutoMapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Make, MakeDto>();

            //CreateMap<Model, ModelDto>();

            CreateMap<Feature, FeatureDto>();
        }
    }
}
