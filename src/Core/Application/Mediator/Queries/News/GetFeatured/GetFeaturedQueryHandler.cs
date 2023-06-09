using Application.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application.Mediator.Queries.News.GetFeatured
{
    public class GetFeaturedQueryHandler : GenericHandler<INewsRepository, GetFeaturedQuery, IEnumerable<GetFeaturedViewModel>>
    {
        public GetFeaturedQueryHandler(INewsRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<IEnumerable<GetFeaturedViewModel>> Handle(GetFeaturedQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.AsQueryable()
            .Include(e => e.User)
            .Include(e => e.NewsCategories).ThenInclude(e => e.Category)
            .Where(e => e.Featured)
            .Take(request.Count)
            .ToListAsync();

            if (result is null)
                throw new Exception("Öne çıkan içerik bulunamadı");

            return base.Mapper.Map<IEnumerable<GetFeaturedViewModel>>(result);
            // return result.Select(e => new GetHomeViewModel()
            // {
            //     Id = e.Id,
            //     Title = e.Title,
            //     Url = e.Url,
            //     Cover = e.Cover,
            //     CreatedDate = e.CreatedDate,
            //     Description = e.Description,
            //     Author = new NewsUserViewModel()
            //     {
            //         FirstName = e.User.FirstName,
            //         LastName = e.User.LastName,
            //         Username = e.User.Username,
            //         Image = e.User.Image
            //     },
            //     Categories = e.NewsCategories.Select(c => new NewsCategoryViewModel()
            //     {
            //         Title = c.Category.Title,
            //         Url = c.Category.Url
            //     })
            // });
        }
    }
}