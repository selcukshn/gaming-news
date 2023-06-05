using Application.Repository.Base;
using AutoMapper;
using MediatR;

namespace Application.Mediator
{
    public abstract class GenericHandler<TRepository, TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRepository : IBaseRepository
    where TRequest : IRequest<TResponse>
    {
        protected readonly TRepository Repository;
        protected readonly IMapper Mapper;

        public GenericHandler(TRepository repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}