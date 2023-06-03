using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class NewsTagRepository : Repository<NewsTag>, INewsTagRepository
    {
        public NewsTagRepository(GamingNewsContext context) : base(context) { }
    }
}