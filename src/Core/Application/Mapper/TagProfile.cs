using Application.Extensions;
using Application.Mediator.Commands.Tag.Create;
using Application.Mediator.Queries.Tag.GetTag;
using AutoMapper;
using Domain;

namespace Application.Mapper
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Domain.Tag, GetTagViewModel>().ReverseMap();

            CreateMap<CreateTagCommand, Tag>()
            .ForMember(e => e.Url, e => e.MapFrom(m => m.Title.ToUrl()));

            CreateMap<Domain.NewsTag, Models.Base.NewsTag>();
        }
    }
}