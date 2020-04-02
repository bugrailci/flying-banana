using AutoMapper;
using BYNOGAME.API.Domain.Models;
using BYNOGAME.API.Domain.Models.Queries;
using BYNOGAME.API.Extensions;
using BYNOGAME.API.Resources;

namespace BYNOGAME.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.Kaliteturu.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<ProductResource>>();
        }
    }
}