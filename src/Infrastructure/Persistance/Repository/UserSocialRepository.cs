using Application.Repository;
using Domain;
using Persistance.Context;
using Persistance.Repository.Base;

namespace Persistance.Repository
{
    public class UserSocialRepository : Repository<UserSocial>, IUserSocialRepository
    {
        public UserSocialRepository(GamingNewsContext context) : base(context) { }
    }
}