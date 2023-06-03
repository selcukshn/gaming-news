using Application.Mediator.Queries.Base;
using Application.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application.Mediator.Queries.News.GetTrending
{
    public class GetTrendingQueryHandler : GenericHandler<INewsRepository, GetTrendingQuery, IEnumerable<GetTrendingViewModel>>
    {
        public GetTrendingQueryHandler(INewsRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<IEnumerable<GetTrendingViewModel>> Handle(GetTrendingQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.AsQueryable()
            .Include(e => e.NewsCategories).ThenInclude(e => e.Category)
            .OrderByDescending(e => e.NewsComments.Count())
            .Take(request.Count)
            .ToListAsync();

            if (result is null)
                throw new Exception("Trendleri getirirken bir sorun oluştu");

            return base.Mapper.Map<IEnumerable<GetTrendingViewModel>>(result);
            // return result.Select(e => new GetTrendingViewModel()
            // {
            //     Cover = e.Cover,
            //     Description = e.Description,
            //     Title = e.Title,
            //     Url = e.Title,
            //     Categories = e.NewsCategories.Select(c => new NewsCategoryViewModel()
            //     {
            //         Title = c.Category.Title,
            //         Url = c.Category.Url
            //     })
            // });
        }
    }
}