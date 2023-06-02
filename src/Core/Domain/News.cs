using Domain.Base;

namespace Domain
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Cover { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool Featured { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<NewsCategory> NewsCategories { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<UserLike> NewsLikes { get; set; }

    }
}