using AutoMapper;
using BYNOGAME.API.Domain.Models;
using BYNOGAME.API.Domain.Models.Queries;
using BYNOGAME.API.Resources;

namespace BYNOGAME.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.Kaliteturu, opt => opt.MapFrom(src => (EKaliteturu)src.UnitOfMeasurement));

            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}