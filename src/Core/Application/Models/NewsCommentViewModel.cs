namespace Application.Models
{
    public class NewsCommentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Image { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }
        public IEnumerable<NewsCommentReplyViewModel>? Replies { get; set; }
    }
}