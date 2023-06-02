using Domain.Base;

namespace Domain
{
    public class UserLike : BaseEntity
    {
        public Guid NewsId { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
        public virtual News News { get; set; }
    }
}