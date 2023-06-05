using Application.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application.Mediator.Queries.News.GetMostLiked
{
    public class GetMostLikedQueryHandler : GenericHandler<INewsRepository, GetMostLikedQuery, List<GetMostLikedViewModel>>
    {
        public GetMostLikedQueryHandler(INewsRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<List<GetMostLikedViewModel>> Handle(GetMostLikedQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.AsQueryable()
            .Include(e => e.NewsCategories).ThenInclude(e => e.Category)
            .Include(e => e.NewsTags).ThenInclude(e => e.Tag)
            .Include(e => e.User)
            .Include(e => e.NewsLikes)
            .OrderByDescending(e => e.NewsLikes.Count)
            .Take(request.Count)
            .ToListAsync();

            return base.Mapper.Map<List<GetMostLikedViewModel>>(result);
        }
    }
}