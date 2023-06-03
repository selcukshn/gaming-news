using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(GamingNewsContext context) : base(context) { }
    }
}