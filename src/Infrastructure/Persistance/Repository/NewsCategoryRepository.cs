using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class NewsCategoryRepository : Repository<NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(GamingNewsContext context) : base(context) { }
    }
}