using Application.Repository;
using AutoMapper;

namespace Application.Mediator.Queries.Category.GetCategory
{
    public class GetCategoryQueryHandler : GenericHandler<ICategoryRepository, GetCategoryQuery, List<GetCategoryViewModel>>
    {
        public GetCategoryQueryHandler(ICategoryRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<List<GetCategoryViewModel>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.GetAllAsync();
            if (result is null)
                throw new Exception("Herhangi bir kategori bulunamadı");
            return base.Mapper.Map<List<GetCategoryViewModel>>(result);
        }
    }
}