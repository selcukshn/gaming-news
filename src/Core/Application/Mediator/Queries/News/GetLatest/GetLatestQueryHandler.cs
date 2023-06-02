using Application.Mediator.Queries.Base;
using Application.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application.Mediator.Queries.News.GetLatest
{
    public class GetLatestQueryHandler : GenericHandler<INewsRepository, GetLatestQuery, IEnumerable<GetLatestViewModel>>
    {
        public GetLatestQueryHandler(INewsRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<IEnumerable<GetLatestViewModel>> Handle(GetLatestQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.AsQueryable()
            .Include(e => e.User)
            .Include(e => e.NewsCategories).ThenInclude(e => e.Category)
            .OrderByDescending(e => e.CreatedDate)
            .Take(request.Count)
            .ToListAsync();

            if (result is null)
                throw new Exception("En son yüklenen içerikleri getirirken bir sorun oluştu");

            return base.Mapper.Map<IEnumerable<GetLatestViewModel>>(result);
        }
    }
}