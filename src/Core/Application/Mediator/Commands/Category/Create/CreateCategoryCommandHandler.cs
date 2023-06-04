using Application.Extensions;
using Application.Repository;
using AutoMapper;

namespace Application.Mediator.Commands.Category.Create
{
    public class CreateCategoryCommandHandler : GenericHandler<ICategoryRepository, CreateCategoryCommand, bool>
    {
        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var haveCategory = await base.Repository.HaveAsync(e => e.Url == request.Title.ToUrl());
            if (haveCategory)
                throw new Exception("Zaten bu ad'a sahip bir kategori mevcut");
            var result = await base.Repository.CreateAsync(base.Mapper.Map<Domain.Category>(request));
            return result > 0;
        }
    }
}