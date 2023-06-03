using MediatR;

namespace Application.Mediator.Queries.News.GetWithUrl
{
    public class GetWithUrlQuery : IRequest<GetWithUrlViewModel>
    {
        public string Url { get; set; }

        public GetWithUrlQuery(string url)
        {
            Url = url;
        }
    }
}