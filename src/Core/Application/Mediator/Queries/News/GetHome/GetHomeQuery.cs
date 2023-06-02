using Application.Mediator.Queries.Base;
using MediatR;

namespace Application.Mediator.Queries.News.GetHome
{
    public class GetHomeQuery : CountableQuery, IRequest<IEnumerable<GetHomeViewModel>>
    {
        public GetHomeQuery(int count) : base(count)
        {
        }
    }
}