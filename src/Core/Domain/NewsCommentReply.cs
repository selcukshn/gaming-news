using Domain.Base;

namespace Domain
{
    public class NewsCommentReply : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid CommentId { get; set; }
        public string Reply { get; set; }
        public DateTime? ReplyDate { get; set; }

        public virtual User User { get; set; }
        public virtual NewsComment NewsComment { get; set; }
    }
}