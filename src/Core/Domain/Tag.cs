using Domain.Base;

namespace Domain
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
    }
}