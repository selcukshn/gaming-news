using Application.Models;

namespace Application.Mediator.Queries.News.GetFeatured
{
    public class GetFeaturedViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public NewsUserViewModel Author { get; set; }
        public IEnumerable<NewsCategoryViewModel> Categories { get; set; }
    }
}