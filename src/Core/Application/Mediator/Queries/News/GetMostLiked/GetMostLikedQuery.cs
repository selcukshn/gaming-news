using Application.Mediator.Queries.Base.Countable;
using Application.Mediator.Queries.Base.Skipable;
using MediatR;

namespace Application.Mediator.Queries.News.GetMostLiked
{
    public class GetMostLikedQuery : ICountableQuery, ISkipableQuery, IRequest<List<GetMostLikedViewModel>>
    {
        private int _skip = 0;
        public int Skip
        {
            get => _skip;
            set
            {
                if (int.TryParse(value.ToString(), out int skip))
                {
                    if (skip > 0)
                        _skip = skip;
                }
            }
        }

        private int _count = 20;
        public int Count
        {
            get => _count;
            set
            {
                if (int.TryParse(value.ToString(), out int count))
                {
                    if (count > 0)
                        _count = count;
                }
            }
        }
    }
}