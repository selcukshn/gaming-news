using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class NewsCommentReplyRepository : Repository<NewsCommentReply>, INewsCommentReplyRepository
    {
        public NewsCommentReplyRepository(GamingNewsContext context) : base(context) { }
    }
}