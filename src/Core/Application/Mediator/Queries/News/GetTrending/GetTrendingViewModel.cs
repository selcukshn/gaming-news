using Application.Models;

namespace Application.Mediator.Queries.News.GetTrending
{
    public class GetTrendingViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public IEnumerable<NewsCategoryViewModel> Categories { get; set; }
    }
}