using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class NewsCommentReplyConfiguration : BaseConfiguration<NewsCommentReply>
    {
        public override void Configure(EntityTypeBuilder<NewsCommentReply> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Reply).HasMaxLength(500).IsRequired();
            builder.Property(e => e.ReplyDate).HasDefaultValueSql("getdate()").IsRequired(false);

            builder.HasOne(e => e.NewsComment).WithMany(e => e.NewsCommentReplies).HasForeignKey(e => e.CommentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User).WithMany(e => e.NewsCommentReplies).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}