using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class NewsCommentConfiguration : BaseConfiguration<NewsComment>
    {
        public override void Configure(EntityTypeBuilder<NewsComment> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Comment).HasMaxLength(500).IsRequired();
            builder.Property(e => e.CommentDate).HasDefaultValueSql("getdate()").IsRequired(false);

            builder.HasOne(e => e.News).WithMany(e => e.NewsComments).HasForeignKey(e => e.NewsId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User).WithMany(e => e.NewsComments).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}