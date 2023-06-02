using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class NewsCommentRepository : Repository<NewsComment>, INewsCommentRepository
    {
        public NewsCommentRepository(GamingNewsContext context) : base(context) { }
    }
}