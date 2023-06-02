using Domain.Base;

namespace Domain
{
    public class NewsTag : BaseEntity
    {
        public Guid NewsId { get; set; }
        public Guid TagId { get; set; }

        public virtual News News { get; set; }
        public virtual Tag Tag { get; set; }
    }
}