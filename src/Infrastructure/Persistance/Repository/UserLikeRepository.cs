using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class UserLikeRepository : Repository<UserLike>, IUserLikeRepository
    {
        public UserLikeRepository(GamingNewsContext context) : base(context) { }
    }
}