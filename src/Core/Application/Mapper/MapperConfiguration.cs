using Application.Extensions;
using Application.Mediator.Commands.Category.Create;
using Application.Mediator.Commands.News.Create;
using Application.Mediator.Commands.Tag.Create;
using Application.Mediator.Queries.News.GetFeatured;
using Application.Mediator.Queries.News.GetLatest;
using Application.Mediator.Queries.News.GetTrending;
using AutoMapper;
using Domain;

namespace Application.Mapper
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<News, GetTrendingViewModel>()
            .ForMember(e => e.Categories, e => e.MapFrom(m => m.NewsCategories.Select(s => s.Category)));

            CreateMap<News, GetLatestViewModel>()
            .ForMember(e => e.Author, e => e.MapFrom(m => m.User))
            .ForMember(e => e.Categories, e => e.MapFrom(m => m.NewsCategories.Select(s => s.Category)));

            CreateMap<News, GetFeaturedViewModel>()
            .ForMember(e => e.Author, e => e.MapFrom(m => m.User))
            .ForMember(e => e.Categories, e => e.MapFrom(m => m.NewsCategories.Select(s => s.Category)));

            CreateMap<CreateNewsCommand, News>()
            .ForMember(e => e.Url, e => e.MapFrom(m => m.Title.ToUniqueUrl()));

            CreateMap<CreateCategoryCommand, Category>()
            .ForMember(e => e.Url, e => e.MapFrom(m => m.Title.ToUniqueUrl()));

            CreateMap<CreateTagCommand, Tag>()
            .ForMember(e => e.Url, e => e.MapFrom(m => m.Title.ToUniqueUrl()));

            CreateMap<Domain.NewsCategory, Models.Base.NewsCategory>();
            CreateMap<Domain.NewsTag, Models.Base.NewsTag>();
        }
    }
}