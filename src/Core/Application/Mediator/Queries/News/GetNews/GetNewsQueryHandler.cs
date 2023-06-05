using Application.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application.Mediator.Queries.News.GetNews
{
    public class GetNewsQueryHandler : GenericHandler<INewsRepository, GetNewsQuery, List<GetNewsViewModel>>
    {
        public GetNewsQueryHandler(INewsRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<List<GetNewsViewModel>> Handle(GetNewsQuery request, CancellationToken cancellationToken)
        {
            var result = base.Repository.AsQueryable()
            .Include(e => e.NewsCategories).ThenInclude(e => e.Category)
            .Include(e => e.NewsTags).ThenInclude(e => e.Tag)
            .Include(e => e.User);

            if (request.AfterDate is not null)
                result.Where(e => e.CreatedDate < request.AfterDate);
            if (request.BeforeDate is not null)
                result.Where(e => e.CreatedDate > request.BeforeDate);
            if (request.Author is not null)
                result.Where(e => e.User.Username == request.Author);
            if (request.Category is not null)
                result.Where(e => e.NewsCategories.Where(c => c.Category.Url == request.Category).Any());
            if (request.Tag is not null)
                result.Where(e => e.NewsTags.Where(c => c.Tag.Url == request.Tag).Any());
            if (request.Search is not null)
                result.Where(e => e.Title.Contains(request.Search));

            var news = await result.OrderByDescending(e => e.CreatedDate).Skip(request.Skip).Take(request.Count).ToListAsync();
            if (news is null)
                throw new Exception("Bu parametrelere uygun kayıt bulunamadı");
            return base.Mapper.Map<List<GetNewsViewModel>>(news);


        }
    }
}