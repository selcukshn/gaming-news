using Application.Repository;
using AutoMapper;

namespace Application.Mediator.Commands.Category.Create
{
    public class CreateCategoryCommandHandler : GenericHandler<ICategoryRepository, CreateCategoryCommand, bool>
    {
        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.CreateAsync(base.Mapper.Map<Domain.Category>(request));
            return result > 0;
        }
    }
}