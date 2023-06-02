using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(GamingNewsContext context) : base(context) { }
    }
}