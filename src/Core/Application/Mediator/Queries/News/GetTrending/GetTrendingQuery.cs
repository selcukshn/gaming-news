using Application.Mediator.Queries.Base.Countable;
using MediatR;

namespace Application.Mediator.Queries.News.GetTrending
{
    public class GetTrendingQuery : CountableQuery, IRequest<IEnumerable<GetTrendingViewModel>>
    {
        public GetTrendingQuery(int count) : base(count)
        {
        }
    }
}