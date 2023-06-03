using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class UserLikeConfiguration : BaseConfiguration<UserLike>
    {
        public override void Configure(EntityTypeBuilder<UserLike> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.News).WithMany(e => e.NewsLikes).HasForeignKey(e => e.NewsId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User).WithMany(e => e.NewsLikes).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}