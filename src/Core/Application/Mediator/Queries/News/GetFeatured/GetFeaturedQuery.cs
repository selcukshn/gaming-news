using Application.Mediator.Queries.Base.Countable;
using MediatR;

namespace Application.Mediator.Queries.News.GetFeatured
{
    public class GetFeaturedQuery : CountableQuery, IRequest<IEnumerable<GetFeaturedViewModel>>
    {
        public GetFeaturedQuery(int count) : base(count)
        {
        }
    }
}