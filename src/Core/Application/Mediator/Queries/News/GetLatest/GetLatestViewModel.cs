using Application.Models;

namespace Application.Mediator.Queries.News.GetLatest
{
    public class GetLatestViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Cover { get; set; }
        public DateTime? CreatedDate { get; set; }
        public NewsUserViewModel Author { get; set; }
        public IEnumerable<NewsCategoryViewModel> Categories { get; set; }


    }
}