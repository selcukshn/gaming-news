using Application.Extensions;
using Application.Mediator.Commands.News.Create;
using Application.Mediator.Queries.News.GetFeatured;
using Application.Mediator.Queries.News.GetLatest;
using Application.Mediator.Queries.News.GetMostLiked;
using Application.Mediator.Queries.News.GetNews;
using Application.Mediator.Queries.News.GetTrending;
using AutoMapper;
using Domain;

namespace Application.Mapper
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<News, GetNewsViewModel>()
           .ForMember(e => e.Categories, e => e.MapFrom(m => m.NewsCategories.Select(s => s.Category)))
           .ForMember(e => e.Tags, e => e.MapFrom(m => m.NewsTags.Select(s => s.Tag)));

            CreateMap<News, GetMostLikedViewModel>()
            .ForMember(e => e.Categories, e => e.MapFrom(m => m.NewsCategories.Select(s => s.Category)))
            .ForMember(e => e.Tags, e => e.MapFrom(m => m.NewsTags.Select(s => s.Tag)));

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
        }
    }
}