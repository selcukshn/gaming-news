using Application.Repository;
using AutoMapper;

namespace Application.Mediator.Commands.News.Create
{
    public class CreateNewsCommandHandler : GenericHandler<INewsRepository, CreateNewsCommand, bool>
    {
        private readonly IUserRepository userRepository;
        public CreateNewsCommandHandler(INewsRepository repository, IMapper mapper, IUserRepository userRepository) : base(repository, mapper)
        {
            this.userRepository = userRepository;
        }

        public override async Task<bool> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            var haveAuthor = await userRepository.HaveAsync(e => e.Id == request.UserId);
            if (!haveAuthor)
                throw new Exception("İçeriği oluşturmak isteyen kullanıcı bulunamadı");
            var result = await base.Repository.CreateAsync(base.Mapper.Map<Domain.News>(request));
            return result > 0;
        }
    }
}