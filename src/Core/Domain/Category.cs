using Domain.Base;

namespace Domain
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public virtual ICollection<NewsCategory> NewsCategories { get; set; }
    }
}