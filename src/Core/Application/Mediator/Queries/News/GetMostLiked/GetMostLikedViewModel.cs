using Application.Models;

namespace Application.Mediator.Queries.News.GetMostLiked
{
    public class GetMostLikedViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public NewsDetailUserViewModel Author { get; set; }
        public IEnumerable<NewsCategoryViewModel> Categories { get; set; }
        public IEnumerable<NewsTagViewModal> Tags { get; set; }
    }
}