using Application.Extensions;
using Application.Repository;
using AutoMapper;

namespace Application.Mediator.Commands.Tag.Create
{
    public class CreateTagCommandHandler : GenericHandler<ITagRepository, CreateTagCommand, bool>
    {
        public CreateTagCommandHandler(ITagRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<bool> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var haveTag = await base.Repository.HaveAsync(e => e.Url == request.Title.ToUrl());
            if (haveTag)
                throw new Exception("Zaten bu ad'a sahip bir etiket mevcut");
            var result = await base.Repository.CreateAsync(base.Mapper.Map<Domain.Tag>(request));
            return result > 0;
        }
    }
}