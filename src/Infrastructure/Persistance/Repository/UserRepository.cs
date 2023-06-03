using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GamingNewsContext context) : base(context) { }
    }
}