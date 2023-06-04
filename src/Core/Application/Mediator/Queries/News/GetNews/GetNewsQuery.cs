using Application.Mediator.Queries.Base.Countable;
using Application.Mediator.Queries.Base.Skipable;
using MediatR;

namespace Application.Mediator.Queries.News.GetNews
{
    public class GetNewsQuery : ICountableQuery, ISkipableQuery, IRequest<List<GetNewsViewModel>>
    {

        public string? Search { get; set; }
        public DateTime? AfterDate { get; set; }
        public DateTime? BeforeDate { get; set; }
        public string? Category { get; set; }
        public string? Author { get; set; }
        public string? Tag { get; set; }

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

        private int _count = 5;
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