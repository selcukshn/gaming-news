using Application.Mediator.Queries.Base.Countable;
using MediatR;

namespace Application.Mediator.Queries.News.GetLatest
{
    public class GetLatestQuery : CountableQuery, IRequest<IEnumerable<GetLatestViewModel>>
    {
        public GetLatestQuery(int count) : base(count)
        {
        }
    }
}