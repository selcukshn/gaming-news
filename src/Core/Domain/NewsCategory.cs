using Domain.Base;

namespace Domain
{
    public class NewsCategory : BaseEntity
    {
        public Guid NewsId { get; set; }
        public Guid CategoryId { get; set; }

        public virtual News News { get; set; }
        public virtual Category Category { get; set; }
    }
}