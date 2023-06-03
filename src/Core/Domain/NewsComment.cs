using Domain.Base;

namespace Domain
{
    public class NewsComment : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid NewsId { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual User User { get; set; }
        public virtual News News { get; set; }
        public virtual ICollection<NewsCommentReply> NewsCommentReplies { get; set; }
    }
}