using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class NewsTagConfiguration : BaseConfiguration<NewsTag>
    {
        public override void Configure(EntityTypeBuilder<NewsTag> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.News).WithMany(e => e.NewsTags).HasForeignKey(e => e.NewsId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Tag).WithMany(e => e.NewsTags).HasForeignKey(e => e.TagId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}