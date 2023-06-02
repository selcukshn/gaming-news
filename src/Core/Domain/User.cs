using Domain.Base;

namespace Domain
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }

        public virtual UserSocial UserSocial { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<UserLike> NewsLikes { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<NewsCommentReply> NewsCommentReplies { get; set; }
    }
}