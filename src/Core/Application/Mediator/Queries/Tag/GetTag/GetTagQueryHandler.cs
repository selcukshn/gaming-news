using Application.Repository;
using AutoMapper;

namespace Application.Mediator.Queries.Tag.GetTag
{
    public class GetTagQueryHandler : GenericHandler<ITagRepository, GetTagQuery, List<GetTagViewModel>>
    {
        public GetTagQueryHandler(ITagRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<List<GetTagViewModel>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.GetAllAsync();
            if (result is null)
                throw new Exception("Herhangi bir etiket bulunamadı");

            return base.Mapper.Map<List<GetTagViewModel>>(result);
        }
    }
}