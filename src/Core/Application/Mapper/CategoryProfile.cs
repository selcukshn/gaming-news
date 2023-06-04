using Application.Extensions;
using Application.Mediator.Commands.Category.Create;
using Application.Mediator.Queries.Category.GetCategory;
using AutoMapper;
using Domain;

namespace Application.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Domain.Category, GetCategoryViewModel>().ReverseMap();

            CreateMap<CreateCategoryCommand, Category>()
            .ForMember(e => e.Url, e => e.MapFrom(m => m.Title.ToUrl()));

            CreateMap<Domain.NewsCategory, Models.Base.NewsCategory>();
        }
    }
}