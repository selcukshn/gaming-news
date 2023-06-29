using Application.Extensions;
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
            // var haveAuthor = await userRepository.HaveAsync(e => e.Id == request.UserId);
            // if (!haveAuthor)
            //     throw new Exception("İçeriği oluşturmak isteyen kullanıcı bulunamadı");

            // var result = await base.Repository.CreateAsync(base.Mapper.Map<Domain.News>(request));
            var result = await base.Repository.CreateAsync(new Domain.News()
            {
                Content = request.Content,
                Cover = request.Cover,
                Description = request.Description,
                Featured = request.Featured,
                Title = request.Title,
                Url = request.Title.ToUniqueUrl(),
                UserId = new Guid("ad46b0c3-e37d-4b34-aaa9-fb22e380b923"),
            });
            return result > 0;
        }
    }
}