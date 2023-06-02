using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(GamingNewsContext context) : base(context) { }
    }
}